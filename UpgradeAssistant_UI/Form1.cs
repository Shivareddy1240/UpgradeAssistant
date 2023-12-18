using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UpgradeAssistant_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ddlTargetFramework.SelectedIndex = 0;
        }

        private void btnUpgAssPath_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgUpgAsstPath.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtUpgradeAssistantPath.Text = dlgUpgAsstPath.FileName;
            }
        }

        private void btnSolutionPath_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgSoluPath.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtSolutionPath.Text = dlgSoluPath.FileName;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string upgradeassistantpath = txtUpgradeAssistantPath.Text;
            string script = "UpgradeAssitant.ps1";
            string scriptPath = Path.Combine(Directory.GetCurrentDirectory(), script);
            string projectpath = txtSolutionPath.Text;
            string logFilePath = @"C:\Users\shivareddy.mudireddy\Logs\logFile.txt";

            bool backupNotRequired = rbtnBackupNo.Checked;
            bool upgradeNonInteractive = rbtnNonInteractive.Checked;

            string targetFramework = ddlTargetFramework.Text;

            try
            {

                string skipBackup = backupNotRequired ? "Yes" : "";
                string nonInteractive = upgradeNonInteractive ? "Yes" : "";
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "powershell",
                    Arguments = $"-File \"{scriptPath}\" -upgradeAssistantPath \"{upgradeassistantpath}\" -solutionPath \"{projectpath}\" -skipBackup \"{skipBackup}\" -nonInteractive \"{nonInteractive}\" -targetFramework \"{targetFramework}\" -logFilePath \"{logFilePath}\"",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false
                };

                using (Process process = new Process())
                {
                    process.StartInfo = startInfo;
                    process.OutputDataReceived += (sender, e) => Console.WriteLine(e.Data);
                    process.ErrorDataReceived += (sender, e) => Console.WriteLine(e.Data);
                    process.Start();
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();
                    process.WaitForExit();
                    MessageBox.Show("Upgrade Completed");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurreed: {ex.Message}");
            }

        }
        private async void btnAnalyze_Click(object sender, EventArgs e)
        {
            string upgradeassistantpath = txtUpgradeAssistantPath.Text;
            string script = "UpgradeAnalysis.ps1";
            string scriptPath = Path.Combine(Directory.GetCurrentDirectory(), script);
            string projectpath = txtSolutionPath.Text;
            try
            {
                //Give your local paths
                string logFilePath = @"C:\Users\shivareddy.mudireddy\Logs\logFile.txt";
                string logAnalysisPath = txtAnalysisLog.Text;
                MessageBox.Show("Analysis Started");
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "powershell",
                    Arguments = $"-File \"{scriptPath}\" -upgradeAssistantPath \"{upgradeassistantpath}\" -solutionPath \"{projectpath}\" -logFilePath \"{logFilePath}\" -logAnalysis \"{logAnalysisPath}\" ",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = new Process())
                {
                    process.StartInfo = startInfo;
                    process.OutputDataReceived += (sender, e) => Console.WriteLine(e.Data);
                    process.ErrorDataReceived += (sender, e) => Console.WriteLine(e.Data);
                    Task processTask = Task.Run(() =>
                    {
                        process.Start();
                        process.BeginOutputReadLine();
                        process.BeginErrorReadLine();
                        process.WaitForExit();
                    });
                    await processTask;
                    MessageBox.Show("Analysis Completed");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurreed: {ex.Message}");
            }

        }

        private void btnAnalysisLog_Click(object sender, EventArgs e)
        {
                DialogResult result = fldrBrowseAnalysisLog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fldrBrowseAnalysisLog.SelectedPath))
                {
                string ErrorLogPath = Path.Combine(fldrBrowseAnalysisLog.SelectedPath, "logFile.txt");
                string logFilePath = Path.Combine(fldrBrowseAnalysisLog.SelectedPath, "logAnalysis.txt");
                    if (!File.Exists(logFilePath))
                    {
                        File.WriteAllText(logFilePath, string.Empty);
                    }
                    if (!File.Exists(ErrorLogPath))
                    {
                    File.WriteAllText(ErrorLogPath, string.Empty);
                    }
                txtAnalysisLog.Text = logFilePath;
                }
            }
    }
}
