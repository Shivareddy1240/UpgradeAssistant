namespace UpgradeAssistant_UI
{
    partial class Analysis
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
            components = new System.ComponentModel.Container();
            lblUpgradeAssistantPath = new System.Windows.Forms.Label();
            lblSolutionPath = new System.Windows.Forms.Label();
            dlgUpgAsstPath = new System.Windows.Forms.OpenFileDialog();
            btnUpgAssPath = new System.Windows.Forms.Button();
            btnSolutionPath = new System.Windows.Forms.Button();
            txtUpgradeAssistantPath = new System.Windows.Forms.TextBox();
            txtSolutionPath = new System.Windows.Forms.TextBox();
            dlgSoluPath = new System.Windows.Forms.OpenFileDialog();
            mnustripModes = new System.Windows.Forms.MenuStrip();
            homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            upgradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            btnAnalyze = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            lblAnalysisLog = new System.Windows.Forms.Label();
            btnAnalysisLog = new System.Windows.Forms.Button();
            txtAnalysisLog = new System.Windows.Forms.TextBox();
            fldrBrowseAnalysisLog = new System.Windows.Forms.FolderBrowserDialog();
            errProvider = new System.Windows.Forms.ErrorProvider(components);
            lblAnalysisPath = new System.Windows.Forms.Label();
            lblErrorLogPath = new System.Windows.Forms.Label();
            lblheadingAnalysis = new System.Windows.Forms.Label();
            processAnalysis = new System.Diagnostics.Process();
            btnClear = new System.Windows.Forms.Button();
            btnProceedUpgrade = new System.Windows.Forms.Button();
            progressAnalysis = new System.Windows.Forms.ProgressBar();
            lblAnalysisProgress = new System.Windows.Forms.Label();
            mnustripModes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errProvider).BeginInit();
            SuspendLayout();
            // 
            // lblUpgradeAssistantPath
            // 
            lblUpgradeAssistantPath.AutoSize = true;
            lblUpgradeAssistantPath.Location = new System.Drawing.Point(36, 72);
            lblUpgradeAssistantPath.Name = "lblUpgradeAssistantPath";
            lblUpgradeAssistantPath.Size = new System.Drawing.Size(163, 15);
            lblUpgradeAssistantPath.TabIndex = 0;
            lblUpgradeAssistantPath.Text = "Upgrade Assistant Path(.exe)*";
            // 
            // lblSolutionPath
            // 
            lblSolutionPath.AutoSize = true;
            lblSolutionPath.Location = new System.Drawing.Point(36, 113);
            lblSolutionPath.Name = "lblSolutionPath";
            lblSolutionPath.Size = new System.Drawing.Size(112, 15);
            lblSolutionPath.TabIndex = 1;
            lblSolutionPath.Text = "Solution Path (.sln)*";
            // 
            // dlgUpgAsstPath
            // 
            dlgUpgAsstPath.FileName = "dlgUpgradeAssistantFile";
            // 
            // btnUpgAssPath
            // 
            btnUpgAssPath.Location = new System.Drawing.Point(232, 64);
            btnUpgAssPath.Name = "btnUpgAssPath";
            btnUpgAssPath.Size = new System.Drawing.Size(75, 23);
            btnUpgAssPath.TabIndex = 2;
            btnUpgAssPath.Text = "Browse";
            btnUpgAssPath.UseVisualStyleBackColor = true;
            btnUpgAssPath.Click += btnUpgAssPath_Click;
            // 
            // btnSolutionPath
            // 
            btnSolutionPath.Location = new System.Drawing.Point(232, 105);
            btnSolutionPath.Name = "btnSolutionPath";
            btnSolutionPath.Size = new System.Drawing.Size(75, 23);
            btnSolutionPath.TabIndex = 3;
            btnSolutionPath.Text = "Browse";
            btnSolutionPath.UseVisualStyleBackColor = true;
            btnSolutionPath.Click += btnSolutionPath_Click;
            // 
            // txtUpgradeAssistantPath
            // 
            txtUpgradeAssistantPath.Location = new System.Drawing.Point(347, 64);
            txtUpgradeAssistantPath.Name = "txtUpgradeAssistantPath";
            txtUpgradeAssistantPath.Size = new System.Drawing.Size(298, 23);
            txtUpgradeAssistantPath.TabIndex = 5;
            // 
            // txtSolutionPath
            // 
            txtSolutionPath.Location = new System.Drawing.Point(347, 105);
            txtSolutionPath.Name = "txtSolutionPath";
            txtSolutionPath.Size = new System.Drawing.Size(298, 23);
            txtSolutionPath.TabIndex = 6;
            // 
            // dlgSoluPath
            // 
            dlgSoluPath.FileName = "dlgSolutionPath";
            // 
            // mnustripModes
            // 
            mnustripModes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { homeToolStripMenuItem, helpToolStripMenuItem });
            mnustripModes.Location = new System.Drawing.Point(0, 0);
            mnustripModes.Name = "mnustripModes";
            mnustripModes.Size = new System.Drawing.Size(800, 24);
            mnustripModes.TabIndex = 7;
            mnustripModes.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { upgradeToolStripMenuItem });
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            homeToolStripMenuItem.Text = "Home";
            // 
            // upgradeToolStripMenuItem
            // 
            upgradeToolStripMenuItem.Name = "upgradeToolStripMenuItem";
            upgradeToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            upgradeToolStripMenuItem.Text = "Upgrade";
            upgradeToolStripMenuItem.Click += upgradeToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { aboutToolStripMenuItem, documentationToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // documentationToolStripMenuItem
            // 
            documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            documentationToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            documentationToolStripMenuItem.Text = "Documentation";
            // 
            // btnAnalyze
            // 
            btnAnalyze.Location = new System.Drawing.Point(428, 244);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new System.Drawing.Size(75, 23);
            btnAnalyze.TabIndex = 8;
            btnAnalyze.Text = "Analyze";
            btnAnalyze.UseVisualStyleBackColor = true;
            btnAnalyze.Click += btnAnalyze_ClickAsync;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(46, 395);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(36, 15);
            label1.TabIndex = 9;
            label1.Text = "Note:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(81, 395);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(330, 15);
            label2.TabIndex = 10;
            label2.Text = "Upgrade Assistant Path - Enter the upgrade assistant exe path";
            // 
            // lblAnalysisLog
            // 
            lblAnalysisLog.AutoSize = true;
            lblAnalysisLog.Location = new System.Drawing.Point(36, 153);
            lblAnalysisLog.Name = "lblAnalysisLog";
            lblAnalysisLog.Size = new System.Drawing.Size(78, 15);
            lblAnalysisLog.TabIndex = 20;
            lblAnalysisLog.Text = "Analysis Log*";
            // 
            // btnAnalysisLog
            // 
            btnAnalysisLog.Location = new System.Drawing.Point(232, 149);
            btnAnalysisLog.Name = "btnAnalysisLog";
            btnAnalysisLog.Size = new System.Drawing.Size(75, 23);
            btnAnalysisLog.TabIndex = 21;
            btnAnalysisLog.Text = "Browse";
            btnAnalysisLog.UseVisualStyleBackColor = true;
            btnAnalysisLog.Click += btnAnalysisLog_Click;
            // 
            // txtAnalysisLog
            // 
            txtAnalysisLog.Location = new System.Drawing.Point(347, 150);
            txtAnalysisLog.Name = "txtAnalysisLog";
            txtAnalysisLog.Size = new System.Drawing.Size(298, 23);
            txtAnalysisLog.TabIndex = 22;
            // 
            // errProvider
            // 
            errProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            errProvider.ContainerControl = this;
            // 
            // lblAnalysisPath
            // 
            lblAnalysisPath.AutoSize = true;
            lblAnalysisPath.Location = new System.Drawing.Point(347, 199);
            lblAnalysisPath.Name = "lblAnalysisPath";
            lblAnalysisPath.Size = new System.Drawing.Size(95, 15);
            lblAnalysisPath.TabIndex = 23;
            lblAnalysisPath.Text = "hdnAnalysisPath";
            lblAnalysisPath.Visible = false;
            // 
            // lblErrorLogPath
            // 
            lblErrorLogPath.AutoSize = true;
            lblErrorLogPath.Location = new System.Drawing.Point(519, 199);
            lblErrorLogPath.Name = "lblErrorLogPath";
            lblErrorLogPath.Size = new System.Drawing.Size(66, 15);
            lblErrorLogPath.TabIndex = 24;
            lblErrorLogPath.Text = "hdnErrPath";
            lblErrorLogPath.Visible = false;
            // 
            // lblheadingAnalysis
            // 
            lblheadingAnalysis.AutoSize = true;
            lblheadingAnalysis.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblheadingAnalysis.Location = new System.Drawing.Point(36, 34);
            lblheadingAnalysis.Name = "lblheadingAnalysis";
            lblheadingAnalysis.Size = new System.Drawing.Size(88, 26);
            lblheadingAnalysis.TabIndex = 25;
            lblheadingAnalysis.Text = "Analysis";
            // 
            // processAnalysis
            // 
            processAnalysis.StartInfo.Domain = "";
            processAnalysis.StartInfo.LoadUserProfile = false;
            processAnalysis.StartInfo.Password = null;
            processAnalysis.StartInfo.StandardErrorEncoding = null;
            processAnalysis.StartInfo.StandardInputEncoding = null;
            processAnalysis.StartInfo.StandardOutputEncoding = null;
            processAnalysis.StartInfo.UserName = "";
            processAnalysis.SynchronizingObject = this;
            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(347, 244);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(75, 23);
            btnClear.TabIndex = 26;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnProceedUpgrade
            // 
            btnProceedUpgrade.Location = new System.Drawing.Point(519, 244);
            btnProceedUpgrade.Name = "btnProceedUpgrade";
            btnProceedUpgrade.Size = new System.Drawing.Size(126, 23);
            btnProceedUpgrade.TabIndex = 27;
            btnProceedUpgrade.Text = "Proceed to Upgrade";
            btnProceedUpgrade.UseVisualStyleBackColor = true;
            btnProceedUpgrade.Click += btnProceedUpgrade_Click;
            // 
            // progressAnalysis
            // 
            progressAnalysis.Location = new System.Drawing.Point(36, 244);
            progressAnalysis.Name = "progressAnalysis";
            progressAnalysis.Size = new System.Drawing.Size(211, 23);
            progressAnalysis.TabIndex = 28;
            progressAnalysis.Visible = false;
            // 
            // lblAnalysisProgress
            // 
            lblAnalysisProgress.AutoSize = true;
            lblAnalysisProgress.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            lblAnalysisProgress.Location = new System.Drawing.Point(79, 270);
            lblAnalysisProgress.Name = "lblAnalysisProgress";
            lblAnalysisProgress.Size = new System.Drawing.Size(120, 15);
            lblAnalysisProgress.TabIndex = 29;
            lblAnalysisProgress.Text = "Analysis in progress...";
            lblAnalysisProgress.Visible = false;
            // 
            // Analysis
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(lblAnalysisProgress);
            Controls.Add(progressAnalysis);
            Controls.Add(btnProceedUpgrade);
            Controls.Add(btnClear);
            Controls.Add(lblheadingAnalysis);
            Controls.Add(lblErrorLogPath);
            Controls.Add(lblAnalysisPath);
            Controls.Add(txtAnalysisLog);
            Controls.Add(btnAnalysisLog);
            Controls.Add(lblAnalysisLog);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAnalyze);
            Controls.Add(txtSolutionPath);
            Controls.Add(txtUpgradeAssistantPath);
            Controls.Add(btnSolutionPath);
            Controls.Add(btnUpgAssPath);
            Controls.Add(lblSolutionPath);
            Controls.Add(lblUpgradeAssistantPath);
            Controls.Add(mnustripModes);
            Name = "Analysis";
            Text = ".Net Upgrade Tool";
            mnustripModes.ResumeLayout(false);
            mnustripModes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblUpgradeAssistantPath;
        private System.Windows.Forms.Label lblSolutionPath;
        private System.Windows.Forms.OpenFileDialog dlgUpgAsstPath;
        private System.Windows.Forms.Button btnUpgAssPath;
        private System.Windows.Forms.Button btnSolutionPath;
        private System.Windows.Forms.TextBox txtUpgradeAssistantPath;
        private System.Windows.Forms.TextBox txtSolutionPath;
        private System.Windows.Forms.OpenFileDialog dlgSoluPath;
        private System.Windows.Forms.MenuStrip mnustripModes;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAnalysisLog;
        private System.Windows.Forms.Button btnAnalysisLog;
        private System.Windows.Forms.TextBox txtAnalysisLog;
        private System.Windows.Forms.FolderBrowserDialog fldrBrowseAnalysisLog;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.Label lblAnalysisPath;
        private System.Windows.Forms.Label lblErrorLogPath;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upgradeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
        private System.Windows.Forms.Label lblheadingAnalysis;
        private System.Diagnostics.Process processAnalysis;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnProceedUpgrade;
        private System.Windows.Forms.ProgressBar progressAnalysis;
        private System.Windows.Forms.Label lblAnalysisProgress;
    }
}

