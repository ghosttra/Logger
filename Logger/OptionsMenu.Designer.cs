namespace Logger {
    partial class OptionsMenu {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pathTb = new System.Windows.Forms.TextBox();
            this.folderBtn = new System.Windows.Forms.Button();
            this.addAppBtn = new System.Windows.Forms.Button();
            this.appsLb = new System.Windows.Forms.ListBox();
            this.flagwordTb = new System.Windows.Forms.TextBox();
            this.gbBlockApp = new System.Windows.Forms.GroupBox();
            this.RecordsGb = new System.Windows.Forms.GroupBox();
            this.flagWordGb = new System.Windows.Forms.GroupBox();
            this.lbSaveText = new System.Windows.Forms.Label();
            this.deleteAppBtn = new System.Windows.Forms.Button();
            this.cbKeylogger = new System.Windows.Forms.CheckBox();
            this.cbFlagWord = new System.Windows.Forms.CheckBox();
            this.gbBlockApp.SuspendLayout();
            this.RecordsGb.SuspendLayout();
            this.flagWordGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // pathTb
            // 
            this.pathTb.Location = new System.Drawing.Point(6, 21);
            this.pathTb.Name = "pathTb";
            this.pathTb.ReadOnly = true;
            this.pathTb.Size = new System.Drawing.Size(371, 20);
            this.pathTb.TabIndex = 0;
            // 
            // folderBtn
            // 
            this.folderBtn.Location = new System.Drawing.Point(383, 19);
            this.folderBtn.Name = "folderBtn";
            this.folderBtn.Size = new System.Drawing.Size(75, 23);
            this.folderBtn.TabIndex = 1;
            this.folderBtn.Text = "Set folder";
            this.folderBtn.UseVisualStyleBackColor = true;
            this.folderBtn.Click += new System.EventHandler(this.folderBtn_Click);
            // 
            // addAppBtn
            // 
            this.addAppBtn.Location = new System.Drawing.Point(383, 19);
            this.addAppBtn.Name = "addAppBtn";
            this.addAppBtn.Size = new System.Drawing.Size(75, 51);
            this.addAppBtn.TabIndex = 2;
            this.addAppBtn.Text = "Block Application";
            this.addAppBtn.UseVisualStyleBackColor = true;
            this.addAppBtn.Click += new System.EventHandler(this.addAppBtn_Click);
            // 
            // appsLb
            // 
            this.appsLb.FormattingEnabled = true;
            this.appsLb.Location = new System.Drawing.Point(6, 19);
            this.appsLb.Name = "appsLb";
            this.appsLb.Size = new System.Drawing.Size(371, 108);
            this.appsLb.TabIndex = 3;
            // 
            // flagwordTb
            // 
            this.flagwordTb.Enabled = false;
            this.flagwordTb.Location = new System.Drawing.Point(6, 19);
            this.flagwordTb.Name = "flagwordTb";
            this.flagwordTb.Size = new System.Drawing.Size(452, 20);
            this.flagwordTb.TabIndex = 4;
            // 
            // gbBlockApp
            // 
            this.gbBlockApp.Controls.Add(this.deleteAppBtn);
            this.gbBlockApp.Controls.Add(this.addAppBtn);
            this.gbBlockApp.Controls.Add(this.appsLb);
            this.gbBlockApp.Location = new System.Drawing.Point(12, 96);
            this.gbBlockApp.Name = "gbBlockApp";
            this.gbBlockApp.Size = new System.Drawing.Size(464, 137);
            this.gbBlockApp.TabIndex = 5;
            this.gbBlockApp.TabStop = false;
            this.gbBlockApp.Text = "Block Application (Closing applications from the list)";
            // 
            // RecordsGb
            // 
            this.RecordsGb.Controls.Add(this.folderBtn);
            this.RecordsGb.Controls.Add(this.pathTb);
            this.RecordsGb.Location = new System.Drawing.Point(12, 41);
            this.RecordsGb.Name = "RecordsGb";
            this.RecordsGb.Size = new System.Drawing.Size(464, 49);
            this.RecordsGb.TabIndex = 6;
            this.RecordsGb.TabStop = false;
            this.RecordsGb.Text = "Records folder (saves record to selected directory)";
            // 
            // flagWordGb
            // 
            this.flagWordGb.Controls.Add(this.flagwordTb);
            this.flagWordGb.Location = new System.Drawing.Point(12, 239);
            this.flagWordGb.Name = "flagWordGb";
            this.flagWordGb.Size = new System.Drawing.Size(464, 49);
            this.flagWordGb.TabIndex = 7;
            this.flagWordGb.TabStop = false;
            this.flagWordGb.Text = "Flag word (if a word was selected from a predefined list, a separate report file " +
    "is created)";
            // 
            // lbSaveText
            // 
            this.lbSaveText.AutoSize = true;
            this.lbSaveText.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbSaveText.Location = new System.Drawing.Point(291, 16);
            this.lbSaveText.Name = "lbSaveText";
            this.lbSaveText.Size = new System.Drawing.Size(179, 13);
            this.lbSaveText.TabIndex = 8;
            this.lbSaveText.Text = "To save changes, close this window";
            // 
            // deleteAppBtn
            // 
            this.deleteAppBtn.Location = new System.Drawing.Point(383, 76);
            this.deleteAppBtn.Name = "deleteAppBtn";
            this.deleteAppBtn.Size = new System.Drawing.Size(75, 51);
            this.deleteAppBtn.TabIndex = 4;
            this.deleteAppBtn.Text = "Delete selected from list";
            this.deleteAppBtn.UseVisualStyleBackColor = true;
            this.deleteAppBtn.Click += new System.EventHandler(this.deleteAppBtn_Click);
            // 
            // cbKeylogger
            // 
            this.cbKeylogger.AutoSize = true;
            this.cbKeylogger.Checked = true;
            this.cbKeylogger.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbKeylogger.Location = new System.Drawing.Point(18, 12);
            this.cbKeylogger.Name = "cbKeylogger";
            this.cbKeylogger.Size = new System.Drawing.Size(76, 17);
            this.cbKeylogger.TabIndex = 9;
            this.cbKeylogger.Text = "Key logger";
            this.cbKeylogger.UseVisualStyleBackColor = true;
            this.cbKeylogger.CheckedChanged += new System.EventHandler(this.cbKeylogger_CheckedChanged);
            // 
            // cbFlagWord
            // 
            this.cbFlagWord.AutoSize = true;
            this.cbFlagWord.Location = new System.Drawing.Point(104, 12);
            this.cbFlagWord.Name = "cbFlagWord";
            this.cbFlagWord.Size = new System.Drawing.Size(72, 17);
            this.cbFlagWord.TabIndex = 9;
            this.cbFlagWord.Text = "Flag word";
            this.cbFlagWord.UseVisualStyleBackColor = true;
            this.cbFlagWord.CheckedChanged += new System.EventHandler(this.cbFlagWord_CheckedChanged);
            // 
            // OptionsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 292);
            this.Controls.Add(this.cbFlagWord);
            this.Controls.Add(this.cbKeylogger);
            this.Controls.Add(this.lbSaveText);
            this.Controls.Add(this.flagWordGb);
            this.Controls.Add(this.RecordsGb);
            this.Controls.Add(this.gbBlockApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsMenu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OptionsMenu_FormClosing);
            this.gbBlockApp.ResumeLayout(false);
            this.RecordsGb.ResumeLayout(false);
            this.RecordsGb.PerformLayout();
            this.flagWordGb.ResumeLayout(false);
            this.flagWordGb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pathTb;
        private System.Windows.Forms.Button folderBtn;
        private System.Windows.Forms.Button addAppBtn;
        private System.Windows.Forms.ListBox appsLb;
        private System.Windows.Forms.TextBox flagwordTb;
        private System.Windows.Forms.GroupBox gbBlockApp;
        private System.Windows.Forms.GroupBox RecordsGb;
        private System.Windows.Forms.GroupBox flagWordGb;
        private System.Windows.Forms.Label lbSaveText;
        private System.Windows.Forms.Button deleteAppBtn;
        private System.Windows.Forms.CheckBox cbKeylogger;
        private System.Windows.Forms.CheckBox cbFlagWord;
    }
}