namespace UpgradeAssistant_UI
{
    partial class AzureAnalysis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new System.Windows.Forms.Label();
            lblappcatAssistantPath = new System.Windows.Forms.Label();
            btnAppCatPath = new System.Windows.Forms.Button();
            txtAppCatAssistantPath = new System.Windows.Forms.TextBox();
            lblSolutionPath = new System.Windows.Forms.Label();
            btnSolutionPath = new System.Windows.Forms.Button();
            txtSolutionPath = new System.Windows.Forms.TextBox();
            progressAnalysis = new System.Windows.Forms.ProgressBar();
            lblAnalysisProgress = new System.Windows.Forms.Label();
            btnClear = new System.Windows.Forms.Button();
            btnAnalyze = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            dlgAppCatAsstPath = new System.Windows.Forms.OpenFileDialog();
            dlgSoluPath = new System.Windows.Forms.OpenFileDialog();
            errProvider = new System.Windows.Forms.ErrorProvider(components);
            fldrBrowseAnalysisLog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)errProvider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(30, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(148, 26);
            label1.TabIndex = 0;
            label1.Text = "Azure Analysis";
            // 
            // lblappcatAssistantPath
            // 
            lblappcatAssistantPath.AutoSize = true;
            lblappcatAssistantPath.Location = new System.Drawing.Point(41, 75);
            lblappcatAssistantPath.Name = "lblappcatAssistantPath";
            lblappcatAssistantPath.Size = new System.Drawing.Size(158, 15);
            lblappcatAssistantPath.TabIndex = 1;
            lblappcatAssistantPath.Text = "AppCat Assistant Path(.exe)*";
            // 
            // btnAppCatPath
            // 
            btnAppCatPath.Location = new System.Drawing.Point(201, 71);
            btnAppCatPath.Name = "btnAppCatPath";
            btnAppCatPath.Size = new System.Drawing.Size(75, 23);
            btnAppCatPath.TabIndex = 3;
            btnAppCatPath.Text = "Browse";
            btnAppCatPath.UseVisualStyleBackColor = true;
            btnAppCatPath.Click += btnAppCatPath_Click;
            // 
            // txtAppCatAssistantPath
            // 
            txtAppCatAssistantPath.Location = new System.Drawing.Point(296, 71);
            txtAppCatAssistantPath.Name = "txtAppCatAssistantPath";
            txtAppCatAssistantPath.Size = new System.Drawing.Size(298, 23);
            txtAppCatAssistantPath.TabIndex = 6;
            // 
            // lblSolutionPath
            // 
            lblSolutionPath.AutoSize = true;
            lblSolutionPath.Location = new System.Drawing.Point(41, 115);
            lblSolutionPath.Name = "lblSolutionPath";
            lblSolutionPath.Size = new System.Drawing.Size(112, 15);
            lblSolutionPath.TabIndex = 7;
            lblSolutionPath.Text = "Solution Path (.sln)*";
            // 
            // btnSolutionPath
            // 
            btnSolutionPath.Location = new System.Drawing.Point(201, 111);
            btnSolutionPath.Name = "btnSolutionPath";
            btnSolutionPath.Size = new System.Drawing.Size(75, 23);
            btnSolutionPath.TabIndex = 8;
            btnSolutionPath.Text = "Browse";
            btnSolutionPath.UseVisualStyleBackColor = true;
            btnSolutionPath.Click += btnSolutionPath_Click;
            // 
            // txtSolutionPath
            // 
            txtSolutionPath.Location = new System.Drawing.Point(296, 111);
            txtSolutionPath.Name = "txtSolutionPath";
            txtSolutionPath.Size = new System.Drawing.Size(298, 23);
            txtSolutionPath.TabIndex = 9;
            // 
            // progressAnalysis
            // 
            progressAnalysis.Location = new System.Drawing.Point(41, 206);
            progressAnalysis.Name = "progressAnalysis";
            progressAnalysis.Size = new System.Drawing.Size(211, 23);
            progressAnalysis.TabIndex = 29;
            progressAnalysis.Visible = false;
            // 
            // lblAnalysisProgress
            // 
            lblAnalysisProgress.AutoSize = true;
            lblAnalysisProgress.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            lblAnalysisProgress.Location = new System.Drawing.Point(79, 232);
            lblAnalysisProgress.Name = "lblAnalysisProgress";
            lblAnalysisProgress.Size = new System.Drawing.Size(120, 15);
            lblAnalysisProgress.TabIndex = 30;
            lblAnalysisProgress.Text = "Analysis in progress...";
            lblAnalysisProgress.Visible = false;
            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(418, 224);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(75, 23);
            btnClear.TabIndex = 31;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnAnalyze
            // 
            btnAnalyze.Location = new System.Drawing.Point(519, 224);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new System.Drawing.Size(75, 23);
            btnAnalyze.TabIndex = 32;
            btnAnalyze.Text = "Analyze";
            btnAnalyze.UseVisualStyleBackColor = true;
            btnAnalyze.Click += btnAnalyze_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(41, 366);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(36, 15);
            label2.TabIndex = 33;
            label2.Text = "Note:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(83, 366);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(484, 15);
            label3.TabIndex = 34;
            label3.Text = "AppCat Assistant Path - Enter the Azure Migrate application and code assessment exe path";
            // 
            // dlgAppCatAsstPath
            // 
            dlgAppCatAsstPath.FileName = "dlgAppCatAssistantFile";
            // 
            // dlgSoluPath
            // 
            dlgSoluPath.FileName = "dlgSolutionPath";
            // 
            // errProvider
            // 
            errProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            errProvider.ContainerControl = this;
            // 
            // AzureAnalysis
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAnalyze);
            Controls.Add(btnClear);
            Controls.Add(lblAnalysisProgress);
            Controls.Add(progressAnalysis);
            Controls.Add(txtSolutionPath);
            Controls.Add(btnSolutionPath);
            Controls.Add(lblSolutionPath);
            Controls.Add(txtAppCatAssistantPath);
            Controls.Add(btnAppCatPath);
            Controls.Add(lblappcatAssistantPath);
            Controls.Add(label1);
            Name = "AzureAnalysis";
            Text = "AzureAnalysis";
            ((System.ComponentModel.ISupportInitialize)errProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblappcatAssistantPath;
        private System.Windows.Forms.Button btnAppCatPath;
        private System.Windows.Forms.TextBox txtAppCatAssistantPath;
        private System.Windows.Forms.Label lblSolutionPath;
        private System.Windows.Forms.Button btnSolutionPath;
        private System.Windows.Forms.TextBox txtSolutionPath;
        private System.Windows.Forms.ProgressBar progressAnalysis;
        private System.Windows.Forms.Label lblAnalysisProgress;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog dlgAppCatAsstPath;
        private System.Windows.Forms.OpenFileDialog dlgSoluPath;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.FolderBrowserDialog fldrBrowseAnalysisLog;
    }
}