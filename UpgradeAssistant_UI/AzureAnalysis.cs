using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpgradeAssistant_UI
{
    public partial class AzureAnalysis : Form
    {
        private Label errorSummaryLabel;
        public AzureAnalysis()
        {
            InitializeComponent();
            InitializeErrorSummaryLabel();
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

        private List<string> ValidateRequiredFields()
        {
            List<string> errorMessages = new List<string>();

            if (IsTextBoxEmpty(txtAppCatAssistantPath))
            {
                errorMessages.Add("Upgrade assistant path is required!");
            }
            if (IsTextBoxEmpty(txtSolutionPath))
            {
                errorMessages.Add("Solution path is required!");
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

        private void btnAppCatPath_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgAppCatAsstPath.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtAppCatAssistantPath.Text = dlgAppCatAsstPath.FileName;
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

        private async void btnAnalyze_Click(object sender, EventArgs e)
        {
            errProvider.Clear();
            List<string> errorMessages = ValidateRequiredFields();
            if (errorMessages.Count > 0)
            {
                ShowErrorSummary(errorMessages);
            }
            else
            {
                string executablePath = txtAppCatAssistantPath.Text;
                string solutionPath = txtSolutionPath.Text;
                string reportName = "Azure_Analysis_Report";
                string arguments = $"analyze \"{solutionPath}\" --noninteractive --code --binaries -r \"{reportName}\"  -s HTML";
                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    FileName = executablePath,
                    Arguments = arguments,
                    UseShellExecute = false,
                    RedirectStandardOutput = false,
                    CreateNoWindow = false
                };
                try
                {
                    MessageBox.Show("Analysis Started");
                    progressAnalysis.Visible = true;
                    lblAnalysisProgress.Visible = true;
                    progressAnalysis.Style = ProgressBarStyle.Marquee;
                    using (Process process = new Process())
                    {
                        process.StartInfo = processStartInfo;
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
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
           
        }
    }
}
