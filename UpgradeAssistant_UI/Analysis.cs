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
    public partial class Analysis : Form
    {
        private Label errorSummaryLabel;
        public Analysis()
        {
            InitializeComponent();
            InitializeErrorSummaryLabel();
            btnProceedUpgrade.Visible = false;
        }
        private void InitializeErrorSummaryLabel()
        {
            errorSummaryLabel = new Label
            {
                ForeColor = Color.Red,
                AutoSize = true,
                Visible = false,
                Location = new Point(10, 10)
            };
            this.Controls.Add(errorSummaryLabel);
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

        private List<string> ValidateRequiredFields()
        {
            List<string> errorMessages = new List<string>();

            if (IsTextBoxEmpty(txtUpgradeAssistantPath))
            {
                errorMessages.Add("Upgrade assistant path is required!");
            }
            if (IsTextBoxEmpty(txtSolutionPath))
            {
                errorMessages.Add("Solution path is required!");
            }
            if (IsTextBoxEmpty(txtAnalysisLog))
            {
                errorMessages.Add("Please select a folder to save the Logs");
            }

            return errorMessages;
        }

        private bool IsTextBoxEmpty(TextBox textBox)
        {
            bool isEmpty = string.IsNullOrWhiteSpace(textBox.Text);
            if (isEmpty)
            {
                errProvider.SetError(textBox, "This field is required!");
            }
            return isEmpty;
        }

        private void ShowErrorSummary(List<string> errorMessages)
        {
            errorSummaryLabel.Visible = true;
            string summaryMessage = string.Join(Environment.NewLine, errorMessages);
            MessageBox.Show(summaryMessage, "Error Summary", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ClearFields()
        {
            txtSolutionPath.Clear();
            txtAnalysisLog.Clear();
        }

        private async void btnAnalyze_ClickAsync(object sender, EventArgs e)
        {
            errProvider.Clear();
            List<string> errorMessages = ValidateRequiredFields();
            if (errorMessages.Count > 0)
            {
                ShowErrorSummary(errorMessages);
            }
            else
            {
                string upgradeassistantpath = txtUpgradeAssistantPath.Text;
                string script = "UpgradeAnalysis.ps1";
                string scriptPath = Path.Combine(Directory.GetCurrentDirectory(), script);
                string projectpath = txtSolutionPath.Text;
                try
                {
                    string logFilePath = lblErrorLogPath.Text;
                    string logAnalysisPath = lblAnalysisPath.Text;
                    MessageBox.Show("Analysis Started");
                    progressAnalysis.Visible = true;
                    lblAnalysisProgress.Visible = true;
                    progressAnalysis.Style = ProgressBarStyle.Marquee;
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
                        progressAnalysis.Visible = false;
                        lblAnalysisProgress.Visible = false;
                        MessageBox.Show("Analysis Completed");
                        btnProceedUpgrade.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception occurreed: {ex.Message}");
                }
            }
        }
        private void btnAnalysisLog_Click(object sender, EventArgs e)
        {
            DialogResult result = fldrBrowseAnalysisLog.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fldrBrowseAnalysisLog.SelectedPath))
            {
                string ErrorLogPath = Path.Combine(fldrBrowseAnalysisLog.SelectedPath, "logFile.txt");
                string logAnalysisFilePath = Path.Combine(fldrBrowseAnalysisLog.SelectedPath, "logAnalysis.txt");
                if (!File.Exists(logAnalysisFilePath))
                {
                    File.WriteAllText(logAnalysisFilePath, string.Empty);
                }
                if (!File.Exists(ErrorLogPath))
                {
                    File.WriteAllText(ErrorLogPath, string.Empty);
                }
                lblAnalysisPath.Text = logAnalysisFilePath;
                lblErrorLogPath.Text = ErrorLogPath;
                txtAnalysisLog.Text = fldrBrowseAnalysisLog.SelectedPath;
            }
        }

        private void upgradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Upgrade upgrade = new Upgrade();
            upgrade.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new();
            about.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUpgradeAssistantPath.Clear();
            txtSolutionPath.Clear();
            txtAnalysisLog.Clear();
        }

        private void btnProceedUpgrade_Click(object sender, EventArgs e)
        {
            Upgrade upgrade = new();
            upgrade.SetAnalysisValue(txtUpgradeAssistantPath.Text, txtSolutionPath.Text, txtAnalysisLog.Text);
            upgrade.ShowDialog();
        }

        private void azureAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AzureAnalysis azureAnalysis = new();
            azureAnalysis.ShowDialog();
        }
    }
}
