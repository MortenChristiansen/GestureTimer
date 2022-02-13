using Newtonsoft.Json;

namespace GestureTimer;

public partial class Form1 : Form
{
    private static string[] Images = new string[0];
    private static readonly Random Rnd = new Random();
    private static readonly UserSettings Settings = LoadSettings();

    private TimeSpan _timeLeft;

    public Form1()
    {
        InitializeComponent();

        Text = "Gesture Timer";

        splitContainer1.IsSplitterFixed = true;
        splitContainer1.FixedPanel = FixedPanel.Panel1;

        ImagePath.Text = Settings.ImagePath;
        PoseFilter.Text = Settings.ImageFilter;

        UpdateImagePaths();

        ImagePath.KeyUp += (o, e) => SaveSettings();
        PoseFilter.KeyUp += (o, e) => SaveSettings();
    }

    private void StartButton_Click(object sender, EventArgs e)
    {
        _timeLeft = GetTimeLeft();
        UpdateTimeLabel();
        drawTimer.Interval = 1000;
        drawTimer.Start();

        SetRandomImage();
    }

    private void drawTimer_Tick(object sender, EventArgs e)
    {
        _timeLeft -= TimeSpan.FromMilliseconds(drawTimer.Interval);
        if (_timeLeft <= TimeSpan.Zero)
        {
            _timeLeft = TimeSpan.Zero;
            drawTimer.Stop();
        }

        UpdateTimeLabel();
    }

    private void StopButton_Click(object sender, EventArgs e)
    {
        PoseImage.Image = null;
        _timeLeft = TimeSpan.Zero;
        drawTimer.Stop();
        UpdateTimeLabel();
    }

    private void PathButton_Click(object sender, EventArgs e)
    {
        UpdateImagePaths();
    }

    private TimeSpan GetTimeLeft() =>
        Option30Sec.Checked ? TimeSpan.FromSeconds(30) :
        Option2Min.Checked ? TimeSpan.FromMinutes(2) :
        TimeSpan.FromMinutes(5);

    private void UpdateTimeLabel() =>
        TimeLabel.Text = _timeLeft.ToString("mm\\:ss");

    private void UpdateImagePaths()
    {
        Images = Directory.Exists(ImagePath.Text) ? Directory.GetFiles(ImagePath.Text, "*", SearchOption.AllDirectories).Where(f =>
            (string.IsNullOrWhiteSpace(PoseFilter.Text) || f.Contains(PoseFilter.Text)) &&
            (f.ToLower().EndsWith(".jpg") || f.ToLower().EndsWith(".jpeg"))
        ).ToArray() : new string[0];

        ImageCountLabel.Text = Images.Length.ToString();
    }

    private string? GetRandomImage()
    {
        return Images.Length > 0 ? Images[Rnd.Next(Images.Length)] : null;
    }

    private void SetRandomImage()
    {
        var imagePath = GetRandomImage();
        PoseImage.Image = imagePath != null ? new Bitmap(imagePath) : null;
    }

    private static UserSettings LoadSettings()
    {
        string settingsFile = GetSettingsFilePath();

        if (!File.Exists(settingsFile))
            return new UserSettings();

        try
        {
            var fileContent = File.ReadAllText(settingsFile);
            if (string.IsNullOrEmpty(fileContent))
                return new UserSettings();

            return JsonConvert.DeserializeObject<UserSettings>(fileContent) ?? new UserSettings();

        }
        catch (Exception)
        {
            return new UserSettings();
        }
    }

    private static string GetSettingsFilePath()
    {
        var settingsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "GestureTimer");
        var settingsFile = Path.Combine(settingsPath, "settings.json");
        return settingsFile;
    }

    private void SaveSettings()
    {
        string settingsFile = GetSettingsFilePath();
        var updatedSettings = new UserSettings { ImageFilter = PoseFilter.Text, ImagePath = ImagePath.Text };
        var json = JsonConvert.SerializeObject(updatedSettings);

        var dir = Path.GetDirectoryName(settingsFile);
        if (dir == null)
            return;

        if (!Directory.Exists(dir))
            Directory.CreateDirectory(dir);

        File.WriteAllText(settingsFile, json);
    }
}

public class UserSettings
{
    public string ImagePath { get; set; } = "";
    public string ImageFilter { get; set; } = "";
}