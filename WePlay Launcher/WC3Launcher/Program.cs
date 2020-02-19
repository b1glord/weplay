using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;

namespace WC3Launcher
{
    static class Program
    {

private const string AppMutexName = "SingleApp";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (Mutex mutex = new Mutex(false, AppMutexName))
            {
                bool Running = !mutex.WaitOne(0, false);
                if(!Running)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new frmMain());
                }
                else
                {
                    // App already launched.
                    MessageBox.Show("WePlay Launcher Açık!");
                }
            }
        }
    }
}
