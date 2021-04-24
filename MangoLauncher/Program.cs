using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TrayForm
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!File.Exists("driverlock"))
            {
                MangoManger.installMangoDriver();
                Process process = Process.GetCurrentProcess();
                process.Close();
                Application.Restart();
            }
            else
            {
                Application.Run(new MainForm());
            }
        }
    }
}
