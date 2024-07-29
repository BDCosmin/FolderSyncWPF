using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Timers;

namespace App
{
    public partial class MainScreen : Form
    {
        int changeSyncStatus = 0;

        private System.Timers.Timer timer;

        public MainScreen()
        {
            InitializeComponent();

        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void IntroText_Click(object sender, EventArgs e)
        {

        }

        private void SyncButton_Click(object sender, EventArgs e)
        {
            // Retrieve the selected interval from numInterval
            int interval = (int)numInterval.Value;

            if ((txtSourceFolder.Text != "" && (txtReplicaFolder.Text != "")) && (txtSourceFolder.Text != txtReplicaFolder.Text))
            {

                if (changeSyncStatus == 0)
                {
                    SyncButton.Text = "STOP SYNC";
                    changeSyncStatus = 1;

                    if (interval <= 0)
                    {
                        LogText.AppendText("Error: Invalid interval.\r\n");
                        return;
                    }

                    timer = new System.Timers.Timer(interval * 1000);
                    timer.Elapsed += OnTimedEvent;
                    timer.AutoReset = true;
                    timer.Enabled = true;

                    ChooseSourceFolder.Enabled = false;
                    ChooseReplicaLocation.Enabled = false;

                    LogText.AppendText("Synchronization started. The updates will be displayed here every 5 seconds.\r\n");
                }
                else
                {
                    SyncButton.Text = "SYNC NOW";
                    changeSyncStatus = 0;
                    timer.Enabled = false;
                    LogText.AppendText("Synchronization stopped.\r\n");

                    ChooseSourceFolder.Enabled = true;
                    ChooseReplicaLocation.Enabled = true;
                }

            }
            else
            {
                if((txtSourceFolder.Text != "" && (txtReplicaFolder.Text != "")) && txtSourceFolder.Text == txtReplicaFolder.Text)
                    LogText.AppendText("Error: Invalid locations! Source and replica cannot be the same directory. \r\n");
                
                else
                    LogText.AppendText("Error: Invalid location(s)! Choose the locations for source and replica, and try again.\r\n");
                
            }
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {

            Invoke((MethodInvoker)delegate
            {
                LogText.AppendText($"Synchronization is up to date at {DateTime.Now}\r\n");
                SynchronizeFolders(txtSourceFolder.Text, txtReplicaFolder.Text);
            });
        }

        private string GetRelativePath(string fromPath, string toPath)
        {
            var fromUri = new Uri(fromPath.EndsWith(Path.DirectorySeparatorChar.ToString())
                ? fromPath
                : fromPath + Path.DirectorySeparatorChar);
            var toUri = new Uri(toPath);
            var relativeUri = fromUri.MakeRelativeUri(toUri);
            var relativePath = Uri.UnescapeDataString(relativeUri.ToString());
            return relativePath.Replace('/', Path.DirectorySeparatorChar);
        }

        private void SynchronizeFolders(string sourceDir, string targetDir)
        {
            if (!Directory.Exists(targetDir))
            {
                Directory.CreateDirectory(targetDir);
            }

            var sourceDirectories = Directory.GetDirectories(sourceDir, "*", SearchOption.AllDirectories);
            var sourceFiles = Directory.GetFiles(sourceDir, "*", SearchOption.AllDirectories);

            var targetDirectories = Directory.GetDirectories(targetDir, "*", SearchOption.AllDirectories);
            var targetFiles = Directory.GetFiles(targetDir, "*", SearchOption.AllDirectories);

            var sourceFilePaths = sourceFiles.Select(f => GetRelativePath(sourceDir, f)).ToHashSet();
            var targetFilePaths = targetFiles.Select(f => GetRelativePath(targetDir, f)).ToHashSet();

            foreach (var sourceDirectory in sourceDirectories)
            {
                var relativePath = GetRelativePath(sourceDir, sourceDirectory);
                var targetDirectory = Path.Combine(targetDir, relativePath);
                if (!Directory.Exists(targetDirectory))
                {
                    Directory.CreateDirectory(targetDirectory);
                    LogText.AppendText($"Created directory: {targetDirectory}");
                }
            }

            foreach (var sourceFilePath in sourceFilePaths)
            {
                var sourceFile = Path.Combine(sourceDir, sourceFilePath);
                var targetFile = Path.Combine(targetDir, sourceFilePath);

                if (!File.Exists(targetFile) || ComputeSHA256(sourceFile) != ComputeSHA256(targetFile))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(targetFile));
                    File.Copy(sourceFile, targetFile, true);
                    LogText.AppendText($"Copied: {sourceFile} -> {targetFile}");
                }
            }

            foreach (var targetFilePath in targetFilePaths)
            {
                var targetFile = Path.Combine(targetDir, targetFilePath);
                var sourceFile = Path.Combine(sourceDir, targetFilePath);

                if (!File.Exists(sourceFile))
                {
                    File.Delete(targetFile);
                    LogText.AppendText($"Deleted: {targetFile}");
                }
            }

            foreach (var targetDirectory in targetDirectories)
            {
                var relativePath = GetRelativePath(targetDir, targetDirectory);
                var sourceDirectory = Path.Combine(sourceDir, relativePath);
                if (!Directory.Exists(sourceDirectory))
                {
                    Directory.Delete(targetDirectory, true);
                    LogText.AppendText($"Deleted directory: {targetDirectory}");
                }
            }
        }


        private string ComputeSHA256(string filePath)
        {
            try
            {
                using (var sha256 = SHA256.Create())
                using (var stream = File.OpenRead(filePath))
                {
                    var hash = sha256.ComputeHash(stream);
                    var sb = new StringBuilder();
                    foreach (var b in hash)
                        sb.Append(b.ToString("X2"));
                    return sb.ToString();
                }
            }
            catch (Exception ex)
            {
                LogText.AppendText($"Error computing SHA256 for {filePath}: {ex.Message}");
                return string.Empty;
            }
        }

        private void Log(string message)
        {
            string userName = Environment.UserName;
            try
            {
                // Append the log message to the TextBox
                LogText.AppendText($"[{DateTime.Now}] [to {userName}]: {message}\r\n");
            }
            catch (Exception ex)
            {
                LogText.AppendText($"Error logging message: {ex.Message}\r\n");
            }
        }

        private void LogWindowText_Click(object sender, EventArgs e)
        {

        }

        private void ChooseSourceFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txtSourceFolder.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void ChooseReplicaLocation_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txtReplicaFolder.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtReplicaFolder_Click(object sender, EventArgs e)
        {

        }

        private void MinimizeToBar_Click(object sender, EventArgs e)
        {
            // Hide the form and show the NotifyIcon
            this.Hide();
            MinimizeIcon.Visible = true;
        }

        private void MinimizeIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Restore the form and hide the NotifyIcon
            this.Show();
            MinimizeIcon.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TitleText_Click(object sender, EventArgs e)
        {

        }
    }
}
