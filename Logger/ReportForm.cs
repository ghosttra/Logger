using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logger {
    public partial class ReportForm : Form {
        public ReportForm(Options opt) {
            InitializeComponent();
            Thread thr = new Thread(updDGV);
            thr.IsBackground = true;
            thr.Start();
            try {
                StreamReader sr = new StreamReader(opt.SavePath + "keylogger.log");
                tbKeylogger.Text = sr.ReadToEnd();
                sr.Close();
            }
            catch (Exception) {
                //ignoring
            }
        }
        private void updDGV() {
            Action a = () => {
                dgvProcesses.DataSource = Process.GetProcesses().Select(p => new { p.Id, p.MainWindowTitle,p.ProcessName }).ToList();
            };
            while (true) {
                Thread.Sleep(1000);
                if (InvokeRequired)
                    Invoke(a);
                else
                    a();
               
            }
        }
    }
}
