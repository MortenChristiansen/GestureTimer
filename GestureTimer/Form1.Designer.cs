namespace GestureTimer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.drawTimer = new System.Windows.Forms.Timer(this.components);
            this.StartButton = new System.Windows.Forms.Button();
            this.PoseImage = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.PoseFilter = new System.Windows.Forms.TextBox();
            this.StopButton = new System.Windows.Forms.Button();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.Option5Min = new System.Windows.Forms.RadioButton();
            this.Option2Min = new System.Windows.Forms.RadioButton();
            this.Option30Sec = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.ImagePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ImageCountLabel = new System.Windows.Forms.Label();
            this.PathButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PoseImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawTimer
            // 
            this.drawTimer.Tick += new System.EventHandler(this.drawTimer_Tick);
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartButton.Location = new System.Drawing.Point(12, 635);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(245, 63);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start new session";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // PoseImage
            // 
            this.PoseImage.BackColor = System.Drawing.Color.Black;
            this.PoseImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PoseImage.Location = new System.Drawing.Point(0, 0);
            this.PoseImage.Name = "PoseImage";
            this.PoseImage.Size = new System.Drawing.Size(822, 758);
            this.PoseImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PoseImage.TabIndex = 1;
            this.PoseImage.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.PathButton);
            this.splitContainer1.Panel1.Controls.Add(this.ImageCountLabel);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.ImagePath);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.PoseFilter);
            this.splitContainer1.Panel1.Controls.Add(this.StopButton);
            this.splitContainer1.Panel1.Controls.Add(this.TimeLabel);
            this.splitContainer1.Panel1.Controls.Add(this.Option5Min);
            this.splitContainer1.Panel1.Controls.Add(this.Option2Min);
            this.splitContainer1.Panel1.Controls.Add(this.Option30Sec);
            this.splitContainer1.Panel1.Controls.Add(this.StartButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.PoseImage);
            this.splitContainer1.Size = new System.Drawing.Size(1090, 758);
            this.splitContainer1.SplitterDistance = 264;
            this.splitContainer1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Image path filter (case sensitive)";
            // 
            // PoseFilter
            // 
            this.PoseFilter.Location = new System.Drawing.Point(9, 216);
            this.PoseFilter.Name = "PoseFilter";
            this.PoseFilter.Size = new System.Drawing.Size(245, 27);
            this.PoseFilter.TabIndex = 5;
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(87, 711);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(94, 31);
            this.StopButton.TabIndex = 4;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeLabel.Location = new System.Drawing.Point(12, 520);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(245, 112);
            this.TimeLabel.TabIndex = 3;
            this.TimeLabel.Text = "00:00";
            // 
            // Option5Min
            // 
            this.Option5Min.AutoSize = true;
            this.Option5Min.Location = new System.Drawing.Point(12, 72);
            this.Option5Min.Name = "Option5Min";
            this.Option5Min.Size = new System.Drawing.Size(94, 24);
            this.Option5Min.TabIndex = 3;
            this.Option5Min.Text = "5 minutes";
            this.Option5Min.UseVisualStyleBackColor = true;
            // 
            // Option2Min
            // 
            this.Option2Min.AutoSize = true;
            this.Option2Min.Location = new System.Drawing.Point(12, 42);
            this.Option2Min.Name = "Option2Min";
            this.Option2Min.Size = new System.Drawing.Size(94, 24);
            this.Option2Min.TabIndex = 2;
            this.Option2Min.Text = "2 minutes";
            this.Option2Min.UseVisualStyleBackColor = true;
            // 
            // Option30Sec
            // 
            this.Option30Sec.AutoSize = true;
            this.Option30Sec.Checked = true;
            this.Option30Sec.Location = new System.Drawing.Point(12, 12);
            this.Option30Sec.Name = "Option30Sec";
            this.Option30Sec.Size = new System.Drawing.Size(103, 24);
            this.Option30Sec.TabIndex = 1;
            this.Option30Sec.TabStop = true;
            this.Option30Sec.Text = "30 seconds";
            this.Option30Sec.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Image path";
            // 
            // ImagePath
            // 
            this.ImagePath.Location = new System.Drawing.Point(9, 154);
            this.ImagePath.Name = "ImagePath";
            this.ImagePath.Size = new System.Drawing.Size(245, 27);
            this.ImagePath.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Images found:";
            // 
            // ImageCountLabel
            // 
            this.ImageCountLabel.AutoSize = true;
            this.ImageCountLabel.Location = new System.Drawing.Point(114, 308);
            this.ImageCountLabel.Name = "ImageCountLabel";
            this.ImageCountLabel.Size = new System.Drawing.Size(17, 20);
            this.ImageCountLabel.TabIndex = 10;
            this.ImageCountLabel.Text = "0";
            // 
            // PathButton
            // 
            this.PathButton.Location = new System.Drawing.Point(9, 260);
            this.PathButton.Name = "PathButton";
            this.PathButton.Size = new System.Drawing.Size(119, 29);
            this.PathButton.TabIndex = 11;
            this.PathButton.Text = "Update Images";
            this.PathButton.UseVisualStyleBackColor = true;
            this.PathButton.Click += new System.EventHandler(this.PathButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 758);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PoseImage)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer drawTimer;
        private Button StartButton;
        private PictureBox PoseImage;
        private SplitContainer splitContainer1;
        private RadioButton Option5Min;
        private RadioButton Option2Min;
        private RadioButton Option30Sec;
        private Label TimeLabel;
        private Button StopButton;
        private Label label1;
        private TextBox PoseFilter;
        private Label label3;
        private TextBox ImagePath;
        private Label label2;
        private Button PathButton;
        private Label ImageCountLabel;
    }
}