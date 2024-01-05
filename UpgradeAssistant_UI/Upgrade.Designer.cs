namespace UpgradeAssistant_UI
{
    partial class Upgrade
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
            btnSubmit = new System.Windows.Forms.Button();
            txtUpgradeAssistantPath = new System.Windows.Forms.TextBox();
            txtSolutionPath = new System.Windows.Forms.TextBox();
            dlgSoluPath = new System.Windows.Forms.OpenFileDialog();
            mnustripModes = new System.Windows.Forms.MenuStrip();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            lblUpgradeMode = new System.Windows.Forms.Label();
            rbtnInteractive = new System.Windows.Forms.RadioButton();
            rbtnNonInteractive = new System.Windows.Forms.RadioButton();
            lblBackup = new System.Windows.Forms.Label();
            rbtnBackupYes = new System.Windows.Forms.RadioButton();
            rbtnBackupNo = new System.Windows.Forms.RadioButton();
            grpboxModes = new System.Windows.Forms.GroupBox();
            lblTrgetFrmWrk = new System.Windows.Forms.Label();
            ddlTargetFramework = new System.Windows.Forms.ComboBox();
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
            grpboxModes.SuspendLayout();
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
            // btnSubmit
            // 
            btnSubmit.Location = new System.Drawing.Point(529, 355);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new System.Drawing.Size(75, 23);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Upgrade";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtUpgradeAssistantPath
            // 
            txtUpgradeAssistantPath.Location = new System.Drawing.Point(347, 64);
            txtUpgradeAssistantPath.Name = "txtUpgradeAssistantPath";
            txtUpgradeAssistantPath.Size = new System.Drawing.Size(257, 23);
            txtUpgradeAssistantPath.TabIndex = 5;
            // 
            // txtSolutionPath
            // 
            txtSolutionPath.Location = new System.Drawing.Point(347, 105);
            txtSolutionPath.Name = "txtSolutionPath";
            txtSolutionPath.Size = new System.Drawing.Size(257, 23);
            txtSolutionPath.TabIndex = 6;
            // 
            // dlgSoluPath
            // 
            dlgSoluPath.FileName = "dlgSolutionPath";
            // 
            // mnustripModes
            // 
            mnustripModes.Location = new System.Drawing.Point(0, 0);
            mnustripModes.Name = "mnustripModes";
            mnustripModes.Size = new System.Drawing.Size(800, 24);
            mnustripModes.TabIndex = 7;
            mnustripModes.Text = "menuStrip1";
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
            // lblUpgradeMode
            // 
            lblUpgradeMode.AutoSize = true;
            lblUpgradeMode.Location = new System.Drawing.Point(36, 167);
            lblUpgradeMode.Name = "lblUpgradeMode";
            lblUpgradeMode.Size = new System.Drawing.Size(86, 15);
            lblUpgradeMode.TabIndex = 11;
            lblUpgradeMode.Text = "Upgrade Mode";
            // 
            // rbtnInteractive
            // 
            rbtnInteractive.AutoSize = true;
            rbtnInteractive.Checked = true;
            rbtnInteractive.Location = new System.Drawing.Point(6, 20);
            rbtnInteractive.Name = "rbtnInteractive";
            rbtnInteractive.Size = new System.Drawing.Size(172, 19);
            rbtnInteractive.TabIndex = 12;
            rbtnInteractive.TabStop = true;
            rbtnInteractive.Text = "Interactive (Recommended)";
            rbtnInteractive.UseVisualStyleBackColor = true;
            // 
            // rbtnNonInteractive
            // 
            rbtnNonInteractive.AutoSize = true;
            rbtnNonInteractive.Location = new System.Drawing.Point(205, 22);
            rbtnNonInteractive.Name = "rbtnNonInteractive";
            rbtnNonInteractive.Size = new System.Drawing.Size(108, 19);
            rbtnNonInteractive.TabIndex = 13;
            rbtnNonInteractive.TabStop = true;
            rbtnNonInteractive.Text = "Non-Interactive";
            rbtnNonInteractive.UseVisualStyleBackColor = true;
            // 
            // lblBackup
            // 
            lblBackup.AutoSize = true;
            lblBackup.Location = new System.Drawing.Point(36, 214);
            lblBackup.Name = "lblBackup";
            lblBackup.Size = new System.Drawing.Size(46, 15);
            lblBackup.TabIndex = 14;
            lblBackup.Text = "Backup";
            // 
            // rbtnBackupYes
            // 
            rbtnBackupYes.AutoSize = true;
            rbtnBackupYes.Checked = true;
            rbtnBackupYes.Location = new System.Drawing.Point(238, 212);
            rbtnBackupYes.Name = "rbtnBackupYes";
            rbtnBackupYes.Size = new System.Drawing.Size(134, 19);
            rbtnBackupYes.TabIndex = 15;
            rbtnBackupYes.TabStop = true;
            rbtnBackupYes.Text = "Yes (Recommended)";
            rbtnBackupYes.UseVisualStyleBackColor = true;
            // 
            // rbtnBackupNo
            // 
            rbtnBackupNo.AutoSize = true;
            rbtnBackupNo.Location = new System.Drawing.Point(437, 210);
            rbtnBackupNo.Name = "rbtnBackupNo";
            rbtnBackupNo.Size = new System.Drawing.Size(41, 19);
            rbtnBackupNo.TabIndex = 16;
            rbtnBackupNo.TabStop = true;
            rbtnBackupNo.Text = "No";
            rbtnBackupNo.UseVisualStyleBackColor = true;
            // 
            // grpboxModes
            // 
            grpboxModes.Controls.Add(rbtnInteractive);
            grpboxModes.Controls.Add(rbtnNonInteractive);
            grpboxModes.Location = new System.Drawing.Point(232, 137);
            grpboxModes.Name = "grpboxModes";
            grpboxModes.Size = new System.Drawing.Size(372, 45);
            grpboxModes.TabIndex = 17;
            grpboxModes.TabStop = false;
            grpboxModes.Text = "Modes";
            // 
            // lblTrgetFrmWrk
            // 
            lblTrgetFrmWrk.AutoSize = true;
            lblTrgetFrmWrk.Location = new System.Drawing.Point(36, 263);
            lblTrgetFrmWrk.Name = "lblTrgetFrmWrk";
            lblTrgetFrmWrk.Size = new System.Drawing.Size(101, 15);
            lblTrgetFrmWrk.TabIndex = 18;
            lblTrgetFrmWrk.Text = "Target Framework";
            // 
            // ddlTargetFramework
            // 
            ddlTargetFramework.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ddlTargetFramework.FormattingEnabled = true;
            ddlTargetFramework.Items.AddRange(new object[] { "Long Term Support", "Standard Term Support", "Preview" });
            ddlTargetFramework.Location = new System.Drawing.Point(232, 251);
            ddlTargetFramework.Name = "ddlTargetFramework";
            ddlTargetFramework.Size = new System.Drawing.Size(224, 23);
            ddlTargetFramework.TabIndex = 19;
            // 
            // lblAnalysisLog
            // 
            lblAnalysisLog.AutoSize = true;
            lblAnalysisLog.Location = new System.Drawing.Point(36, 302);
            lblAnalysisLog.Name = "lblAnalysisLog";
            lblAnalysisLog.Size = new System.Drawing.Size(78, 15);
            lblAnalysisLog.TabIndex = 20;
            lblAnalysisLog.Text = "Analysis Log*";
            // 
            // btnAnalysisLog
            // 
            btnAnalysisLog.Location = new System.Drawing.Point(232, 294);
            btnAnalysisLog.Name = "btnAnalysisLog";
            btnAnalysisLog.Size = new System.Drawing.Size(75, 23);
            btnAnalysisLog.TabIndex = 21;
            btnAnalysisLog.Text = "Browse";
            btnAnalysisLog.UseVisualStyleBackColor = true;
            btnAnalysisLog.Click += btnAnalysisLog_Click;
            // 
            // txtAnalysisLog
            // 
            txtAnalysisLog.Location = new System.Drawing.Point(357, 294);
            txtAnalysisLog.Name = "txtAnalysisLog";
            txtAnalysisLog.Size = new System.Drawing.Size(247, 23);
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
            lblAnalysisPath.Location = new System.Drawing.Point(623, 297);
            lblAnalysisPath.Name = "lblAnalysisPath";
            lblAnalysisPath.Size = new System.Drawing.Size(95, 15);
            lblAnalysisPath.TabIndex = 23;
            lblAnalysisPath.Text = "hdnAnalysisPath";
            lblAnalysisPath.Visible = false;
            // 
            // lblErrorLogPath
            // 
            lblErrorLogPath.AutoSize = true;
            lblErrorLogPath.Location = new System.Drawing.Point(724, 298);
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
            lblheadingAnalysis.Location = new System.Drawing.Point(36, 33);
            lblheadingAnalysis.Name = "lblheadingAnalysis";
            lblheadingAnalysis.Size = new System.Drawing.Size(92, 26);
            lblheadingAnalysis.TabIndex = 25;
            lblheadingAnalysis.Text = "Upgrade";
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
            btnClear.Location = new System.Drawing.Point(437, 355);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(75, 23);
            btnClear.TabIndex = 26;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Upgrade
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(lblheadingAnalysis);
            Controls.Add(lblErrorLogPath);
            Controls.Add(lblAnalysisPath);
            Controls.Add(txtAnalysisLog);
            Controls.Add(btnAnalysisLog);
            Controls.Add(lblAnalysisLog);
            Controls.Add(ddlTargetFramework);
            Controls.Add(lblTrgetFrmWrk);
            Controls.Add(grpboxModes);
            Controls.Add(rbtnBackupNo);
            Controls.Add(rbtnBackupYes);
            Controls.Add(lblBackup);
            Controls.Add(lblUpgradeMode);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSolutionPath);
            Controls.Add(txtUpgradeAssistantPath);
            Controls.Add(btnSubmit);
            Controls.Add(btnSolutionPath);
            Controls.Add(btnUpgAssPath);
            Controls.Add(lblSolutionPath);
            Controls.Add(lblUpgradeAssistantPath);
            Controls.Add(mnustripModes);
            Name = "Upgrade";
            Text = ".Net Upgrade Tool - Upgrade";
            grpboxModes.ResumeLayout(false);
            grpboxModes.PerformLayout();
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
        private System.Windows.Forms.Button btnSubmit;
        public System.Windows.Forms.TextBox txtUpgradeAssistantPath;
        public System.Windows.Forms.TextBox txtSolutionPath;
        private System.Windows.Forms.OpenFileDialog dlgSoluPath;
        private System.Windows.Forms.MenuStrip mnustripModes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUpgradeMode;
        private System.Windows.Forms.RadioButton rbtnInteractive;
        private System.Windows.Forms.RadioButton rbtnNonInteractive;
        private System.Windows.Forms.Label lblBackup;
        private System.Windows.Forms.RadioButton rbtnBackupYes;
        private System.Windows.Forms.RadioButton rbtnBackupNo;
        private System.Windows.Forms.GroupBox grpboxModes;
        private System.Windows.Forms.Label lblTrgetFrmWrk;
        private System.Windows.Forms.ComboBox ddlTargetFramework;
        private System.Windows.Forms.Label lblAnalysisLog;
        private System.Windows.Forms.Button btnAnalysisLog;
        public System.Windows.Forms.TextBox txtAnalysisLog;
        private System.Windows.Forms.FolderBrowserDialog fldrBrowseAnalysisLog;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.Label lblAnalysisPath;
        private System.Windows.Forms.Label lblErrorLogPath;
        private System.Windows.Forms.Label lblheadingAnalysis;
        private System.Diagnostics.Process processAnalysis;
        private System.Windows.Forms.Button btnClear;
    }
}

