using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace App
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.NumericUpDown numInterval;


        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 
        private bool isDragging = false;
        private Point lastCursor;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            this.TopLayout = new System.Windows.Forms.Panel();
            this.TitleText = new System.Windows.Forms.Label();
            this.LogPanel = new System.Windows.Forms.Panel();
            this.LogText = new System.Windows.Forms.RichTextBox();
            this.IntroText = new System.Windows.Forms.Label();
            this.WelcomeText = new System.Windows.Forms.Label();
            this.LogWindowText = new System.Windows.Forms.Label();
            this.SourceDirLabel = new System.Windows.Forms.Label();
            this.ReplicaDirLabel = new System.Windows.Forms.Label();
            this.txtSourceFolder = new System.Windows.Forms.Label();
            this.txtReplicaFolder = new System.Windows.Forms.Label();
            this.SyncButton = new System.Windows.Forms.Button();
            this.ChooseSourceFolder = new System.Windows.Forms.Button();
            this.ChooseReplicaLocation = new System.Windows.Forms.Button();
            this.MinimizeIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MinimizeButton = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.PictureBox();
            this.MinimizeToBar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            this.TopLayout.SuspendLayout();
            this.LogPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeToBar)).BeginInit();
            this.SuspendLayout();
            // 
            // numInterval
            // 
            this.numInterval.Location = new System.Drawing.Point(567, 144);
            this.numInterval.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.numInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numInterval.Name = "numInterval";
            this.numInterval.Size = new System.Drawing.Size(120, 20);
            this.numInterval.TabIndex = 3;
            this.numInterval.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numInterval.Visible = false;
            // 
            // TopLayout
            // 
            this.TopLayout.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.TopLayout.Controls.Add(this.pictureBox1);
            this.TopLayout.Controls.Add(this.TitleText);
            this.TopLayout.Location = new System.Drawing.Point(1, 1);
            this.TopLayout.Name = "TopLayout";
            this.TopLayout.Size = new System.Drawing.Size(816, 44);
            this.TopLayout.TabIndex = 0;
            this.TopLayout.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopLayout_MouseDown);
            this.TopLayout.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopLayout_MouseMove);
            this.TopLayout.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopLayout_MouseUp);
            // 
            // TitleText
            // 
            this.TitleText.AutoSize = true;
            this.TitleText.Font = new System.Drawing.Font("Russo One", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TitleText.Location = new System.Drawing.Point(114, 8);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(170, 29);
            this.TitleText.TabIndex = 0;
            this.TitleText.Text = "Sync_Folder";
            this.TitleText.Click += new System.EventHandler(this.TitleText_Click);
            // 
            // LogPanel
            // 
            this.LogPanel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.LogPanel.Controls.Add(this.LogText);
            this.LogPanel.ForeColor = System.Drawing.Color.LightGray;
            this.LogPanel.Location = new System.Drawing.Point(65, 247);
            this.LogPanel.Name = "LogPanel";
            this.LogPanel.Size = new System.Drawing.Size(685, 173);
            this.LogPanel.TabIndex = 4;
            // 
            // LogText
            // 
            this.LogText.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.LogText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogText.ForeColor = System.Drawing.Color.Silver;
            this.LogText.Location = new System.Drawing.Point(13, 12);
            this.LogText.Name = "LogText";
            this.LogText.ReadOnly = true;
            this.LogText.Size = new System.Drawing.Size(657, 148);
            this.LogText.TabIndex = 1;
            this.LogText.Text = "";
            // 
            // IntroText
            // 
            this.IntroText.AutoSize = true;
            this.IntroText.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntroText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.IntroText.Location = new System.Drawing.Point(62, 106);
            this.IntroText.Name = "IntroText";
            this.IntroText.Size = new System.Drawing.Size(379, 18);
            this.IntroText.TabIndex = 1;
            this.IntroText.Text = "If you want to synchronize your directories, let\'s get it started.";
            this.IntroText.Click += new System.EventHandler(this.IntroText_Click);
            // 
            // WelcomeText
            // 
            this.WelcomeText.AutoSize = true;
            this.WelcomeText.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.WelcomeText.Location = new System.Drawing.Point(58, 69);
            this.WelcomeText.Name = "WelcomeText";
            this.WelcomeText.Size = new System.Drawing.Size(214, 37);
            this.WelcomeText.TabIndex = 2;
            this.WelcomeText.Text = "Welcome back! ";
            // 
            // LogWindowText
            // 
            this.LogWindowText.AutoSize = true;
            this.LogWindowText.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogWindowText.ForeColor = System.Drawing.Color.Silver;
            this.LogWindowText.Location = new System.Drawing.Point(662, 423);
            this.LogWindowText.Name = "LogWindowText";
            this.LogWindowText.Size = new System.Drawing.Size(88, 18);
            this.LogWindowText.TabIndex = 5;
            this.LogWindowText.Text = "- log window";
            this.LogWindowText.Click += new System.EventHandler(this.LogWindowText_Click);
            // 
            // SourceDirLabel
            // 
            this.SourceDirLabel.AutoSize = true;
            this.SourceDirLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourceDirLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SourceDirLabel.Location = new System.Drawing.Point(61, 140);
            this.SourceDirLabel.Name = "SourceDirLabel";
            this.SourceDirLabel.Size = new System.Drawing.Size(137, 22);
            this.SourceDirLabel.TabIndex = 6;
            this.SourceDirLabel.Text = "Source directory:";
            // 
            // ReplicaDirLabel
            // 
            this.ReplicaDirLabel.AutoSize = true;
            this.ReplicaDirLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReplicaDirLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ReplicaDirLabel.Location = new System.Drawing.Point(61, 195);
            this.ReplicaDirLabel.Name = "ReplicaDirLabel";
            this.ReplicaDirLabel.Size = new System.Drawing.Size(140, 22);
            this.ReplicaDirLabel.TabIndex = 7;
            this.ReplicaDirLabel.Text = "Replica directory:";
            // 
            // txtSourceFolder
            // 
            this.txtSourceFolder.AutoSize = true;
            this.txtSourceFolder.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSourceFolder.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtSourceFolder.Location = new System.Drawing.Point(62, 170);
            this.txtSourceFolder.Name = "txtSourceFolder";
            this.txtSourceFolder.Size = new System.Drawing.Size(0, 17);
            this.txtSourceFolder.TabIndex = 10;
            this.txtSourceFolder.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtReplicaFolder
            // 
            this.txtReplicaFolder.AutoSize = true;
            this.txtReplicaFolder.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReplicaFolder.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtReplicaFolder.Location = new System.Drawing.Point(62, 224);
            this.txtReplicaFolder.Name = "txtReplicaFolder";
            this.txtReplicaFolder.Size = new System.Drawing.Size(0, 17);
            this.txtReplicaFolder.TabIndex = 11;
            this.txtReplicaFolder.Click += new System.EventHandler(this.txtReplicaFolder_Click);
            // 
            // SyncButton
            // 
            this.SyncButton.BackColor = System.Drawing.Color.Gainsboro;
            this.SyncButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SyncButton.Location = new System.Drawing.Point(567, 170);
            this.SyncButton.Name = "SyncButton";
            this.SyncButton.Size = new System.Drawing.Size(168, 37);
            this.SyncButton.TabIndex = 3;
            this.SyncButton.Text = "SYNC NOW";
            this.SyncButton.UseVisualStyleBackColor = false;
            this.SyncButton.Click += new System.EventHandler(this.SyncButton_Click);
            // 
            // ChooseSourceFolder
            // 
            this.ChooseSourceFolder.BackColor = System.Drawing.Color.LightGray;
            this.ChooseSourceFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseSourceFolder.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ChooseSourceFolder.Location = new System.Drawing.Point(204, 138);
            this.ChooseSourceFolder.Name = "ChooseSourceFolder";
            this.ChooseSourceFolder.Size = new System.Drawing.Size(130, 28);
            this.ChooseSourceFolder.TabIndex = 8;
            this.ChooseSourceFolder.Text = "Choose folder...";
            this.ChooseSourceFolder.UseVisualStyleBackColor = false;
            this.ChooseSourceFolder.Click += new System.EventHandler(this.ChooseSourceFolder_Click);
            // 
            // ChooseReplicaLocation
            // 
            this.ChooseReplicaLocation.BackColor = System.Drawing.Color.LightGray;
            this.ChooseReplicaLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseReplicaLocation.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ChooseReplicaLocation.Location = new System.Drawing.Point(204, 193);
            this.ChooseReplicaLocation.Name = "ChooseReplicaLocation";
            this.ChooseReplicaLocation.Size = new System.Drawing.Size(130, 28);
            this.ChooseReplicaLocation.TabIndex = 9;
            this.ChooseReplicaLocation.Text = "Choose where...";
            this.ChooseReplicaLocation.UseVisualStyleBackColor = false;
            this.ChooseReplicaLocation.Click += new System.EventHandler(this.ChooseReplicaLocation_Click);
            // 
            // MinimizeIcon
            // 
            this.MinimizeIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.MinimizeIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("MinimizeIcon.Icon")));
            this.MinimizeIcon.Text = "Sync_Folder: Running...";
            this.MinimizeIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MinimizeIcon_MouseDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App.Properties.Resources.syncfolderimg_png;
            this.pictureBox1.Location = new System.Drawing.Point(11, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.MinimizeButton.Image = global::App.Properties.Resources.minimize;
            this.MinimizeButton.Location = new System.Drawing.Point(657, 1);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(46, 44);
            this.MinimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MinimizeButton.TabIndex = 2;
            this.MinimizeButton.TabStop = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ExitButton.Image = global::App.Properties.Resources.exitbutton;
            this.ExitButton.Location = new System.Drawing.Point(756, 1);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(46, 44);
            this.ExitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitButton.TabIndex = 1;
            this.ExitButton.TabStop = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MinimizeToBar
            // 
            this.MinimizeToBar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.MinimizeToBar.Image = global::App.Properties.Resources.mmtbar;
            this.MinimizeToBar.Location = new System.Drawing.Point(704, 1);
            this.MinimizeToBar.Name = "MinimizeToBar";
            this.MinimizeToBar.Size = new System.Drawing.Size(55, 44);
            this.MinimizeToBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MinimizeToBar.TabIndex = 12;
            this.MinimizeToBar.TabStop = false;
            this.MinimizeToBar.Click += new System.EventHandler(this.MinimizeToBar_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtReplicaFolder);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.txtSourceFolder);
            this.Controls.Add(this.ChooseReplicaLocation);
            this.Controls.Add(this.ChooseSourceFolder);
            this.Controls.Add(this.MinimizeToBar);
            this.Controls.Add(this.ReplicaDirLabel);
            this.Controls.Add(this.SourceDirLabel);
            this.Controls.Add(this.LogWindowText);
            this.Controls.Add(this.LogPanel);
            this.Controls.Add(this.SyncButton);
            this.Controls.Add(this.WelcomeText);
            this.Controls.Add(this.IntroText);
            this.Controls.Add(this.TopLayout);
            this.Controls.Add(this.numInterval);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
            this.TopLayout.ResumeLayout(false);
            this.TopLayout.PerformLayout();
            this.LogPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeToBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TopLayout_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = e.Location;
            }
        }

        private void TopLayout_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                // Calculate the new position of the form
                Point newLocation = new Point(this.Left + e.X - lastCursor.X, this.Top + e.Y - lastCursor.Y);
                this.Location = newLocation;
            }
        }

        private void TopLayout_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        #endregion

        private System.Windows.Forms.Panel TopLayout;
        private System.Windows.Forms.Label TitleText;
        private System.Windows.Forms.PictureBox ExitButton;
        private PictureBox MinimizeButton;
        private System.Windows.Forms.Label IntroText;
        private System.Windows.Forms.Label WelcomeText;
        private Button SyncButton;
        private Panel LogPanel;
        private System.Windows.Forms.Label LogWindowText;
        private System.Windows.Forms.Label SourceDirLabel;
        private System.Windows.Forms.Label ReplicaDirLabel;
        private Button ChooseSourceFolder;
        private Button ChooseReplicaLocation;
        private System.Windows.Forms.Label txtSourceFolder;
        private System.Windows.Forms.Label txtReplicaFolder;
        private RichTextBox LogText;
        private PictureBox MinimizeToBar;
        private NotifyIcon MinimizeIcon;
        private PictureBox pictureBox1;
    }
}

