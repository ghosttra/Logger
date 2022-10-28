using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logger {
    public partial class OptionsMenu : Form {
        Options opt;
        public OptionsMenu(ref Options options) {
            InitializeComponent();
            appsLb.DisplayMember = "Name";
            opt = options;
        }

        private void folderBtn_Click(object sender, EventArgs e) {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.ShowDialog();
            pathTb.Text = dlg.SelectedPath + "\\";
        }

        private void addAppBtn_Click(object sender, EventArgs e) {
            OpenFileDialog app = new OpenFileDialog();
            app.Filter = "Applications(*.exe)|*.exe";
            app.ShowDialog();


            appsLb.Items.Add(new App() { Name = app.FileName.Split('\\').Last(), Path = app.FileName });
        }

        private void OptionsMenu_FormClosing(object sender, FormClosingEventArgs e) {
            opt.BlockedApplications = appsLb.Items.Cast<App>().ToList();
            opt.SavePath = pathTb.Text;
            opt.FlagWord = flagwordTb.Text;
            opt.isKeyLogger = cbKeylogger.Checked;
        }

        private void deleteAppBtn_Click(object sender, EventArgs e) {
            if (appsLb.Items.Count == 0) return;
            appsLb.Items.Remove(appsLb.SelectedItem);
        }

        private void cbFlagWord_CheckedChanged(object sender, EventArgs e) {
            flagwordTb.Enabled = cbFlagWord.Checked;
            if (!cbFlagWord.Checked)
                flagwordTb.Text = String.Empty;
        }

        private void cbKeylogger_CheckedChanged(object sender, EventArgs e) {
            cbFlagWord.Enabled = cbKeylogger.Checked;
            cbFlagWord.Checked = false;
        }
    }

}
