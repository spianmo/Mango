using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrayForm
{
    class MangoManger
    {
        public static void installMangoDriver(bool isAlert = false)
        {
            if (!File.Exists("driverlock"))
            {
                System.Security.Principal.WindowsIdentity identity = System.Security.Principal.WindowsIdentity.GetCurrent();
                //创建Windows用户主题 
                Application.EnableVisualStyles();

                System.Security.Principal.WindowsPrincipal principal = new System.Security.Principal.WindowsPrincipal(identity);
                //判断当前登录用户是否为管理员 
                if (principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator))
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = "MangoDriverInstall.exe";
                    startInfo.Arguments = "";
                    startInfo.Verb = "runas";
                    Process.Start(startInfo);
                    FileStream fs = File.Create("driverlock");
                    fs.Close();
                }
            }
            else
            {
                if (isAlert)
                {
                    MessageBox.Show("已安装过Mango网卡适配器，无需再次安装");
                }
            }
        }
    }
}
