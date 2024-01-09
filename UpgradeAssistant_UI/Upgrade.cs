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
    public partial class Upgrade : Form
    {
        private Label errorSummaryLabel;
        public Upgrade()
        {
            InitializeComponent();
            InitializeErrorSummaryLabel();
            ddlTargetFramework.SelectedIndex = 0;
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

        private void btnSubmit_Click(object sender, EventArgs e)
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
                string script = "UpgradeAssitant.ps1";
                string scriptPath = Path.Combine(Directory.GetCurrentDirectory(), script);
                string projectpath = txtSolutionPath.Text;
                string logFilePath = lblErrorLogPath.Text;

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
                        ClearFields();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception occurreed: {ex.Message}");
                }
            }
        }

        private void ClearFields()
        {
            txtSolutionPath.Clear();
            txtAnalysisLog.Clear();
            rbtnInteractive.Select();
            rbtnBackupYes.Select();
            Analysis analysis = new Analysis();
            analysis.txtSolutionPath.Clear();
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
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUpgradeAssistantPath.Clear();
            txtSolutionPath.Clear();
            txtAnalysisLog.Clear();
            ddlTargetFramework.SelectedIndex = 0;
            rbtnBackupYes.Select();
            rbtnInteractive.Select();
        }
        public void SetAnalysisValue(string upgradeAssistant, string solution, string logFile)
        {
            txtUpgradeAssistantPath.Text = upgradeAssistant;
            txtSolutionPath.Text = solution;
            txtAnalysisLog.Text = logFile;
        }
    }
}
