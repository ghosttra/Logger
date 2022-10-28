namespace Logger {
    partial class LoggerMainMenu {
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
            this.optionsBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.recorndBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // optionsBtn
            // 
            this.optionsBtn.Location = new System.Drawing.Point(12, 12);
            this.optionsBtn.Name = "optionsBtn";
            this.optionsBtn.Size = new System.Drawing.Size(163, 23);
            this.optionsBtn.TabIndex = 0;
            this.optionsBtn.TabStop = false;
            this.optionsBtn.Text = "Options";
            this.optionsBtn.UseVisualStyleBackColor = true;
            this.optionsBtn.Click += new System.EventHandler(this.optionsBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(12, 41);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(163, 23);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Start tracking";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // recorndBtn
            // 
            this.recorndBtn.Location = new System.Drawing.Point(12, 70);
            this.recorndBtn.Name = "recorndBtn";
            this.recorndBtn.Size = new System.Drawing.Size(163, 23);
            this.recorndBtn.TabIndex = 2;
            this.recorndBtn.TabStop = false;
            this.recorndBtn.Text = "Get records";
            this.recorndBtn.UseVisualStyleBackColor = true;
            this.recorndBtn.Click += new System.EventHandler(this.recorndBtn_Click);
            // 
            // LoggerMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 101);
            this.Controls.Add(this.recorndBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.optionsBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoggerMainMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logger";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button optionsBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button recorndBtn;
    }
}

