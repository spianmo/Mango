using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;

namespace TrayForm
{
    public partial class MainForm : Form
    {
        public bool isLink;
        public bool isShowLog;
        public MainForm()
        {
            InitializeComponent();
            startMangoService();
            isLink = true;
            isShowLog = false;
        }

        public void startMangoService()
        {
            System.Security.Principal.WindowsIdentity identity = System.Security.Principal.WindowsIdentity.GetCurrent();
            //创建Windows用户主题 
            Application.EnableVisualStyles();

            System.Security.Principal.WindowsPrincipal principal = new System.Security.Principal.WindowsPrincipal(identity);
            //判断当前登录用户是否为管理员 
            if (principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "MangoService.exe";
                startInfo.Arguments = "";
                startInfo.Verb = "runas";
                Process.Start(startInfo);
            }
        }



        /// <summary>
        /// 启动时隐藏窗口
        /// </summary>
        public void delay()
        {
            this.Hide();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BeginInvoke(new ThreadStart(delay));
        }
        /// <summary>
        /// 托盘图标【显示】菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            if (isLink)
            {
                KillProcess("MangoService");
                KillProcess("FreyaLinkerR");
                this.exitMenuItem.Text = "启动Mango连接";
                this.showWindowMenuItem.Text = "显示Mango日志";
                isShowLog = false;
                isLink = false;
            }
            else
            {
                startMangoService();
                this.exitMenuItem.Text = "断开Mango连接";
                isLink = true;
            }
        }
        [DllImport("user32.dll", EntryPoint = "ShowWindow", SetLastError = true)]
        static extern bool ShowWindow(IntPtr hWnd, uint nCmdShow);

        private void showWindowMenuItem_Click(object sender, EventArgs e)
        {
            if (isLink)
            {
                if (!isShowLog)
                {
                    ConsoleHelper.showConsole("[FreyaLinker.ovpn] OpenVPN 2.5.1 F4:EXIT F1:USR1 F2:USR2 F3:HUP");
                    this.showWindowMenuItem.Text = "隐藏Mango日志";
                    isShowLog = true;
                }
                else
                {
                    ConsoleHelper.hideConsole("[FreyaLinker.ovpn] OpenVPN 2.5.1 F4:EXIT F1:USR1 F2:USR2 F3:HUP");
                    this.showWindowMenuItem.Text = "显示Mango日志";
                    isShowLog = false;
                }
            }
            else
            {
                MessageBox.Show("当前尚未开启Mango连接，无日志窗口。");
            }
        }

        public static void KillProcess(string strProcessesByName)
        {
            foreach (Process p in Process.GetProcesses())
            {
                if (p.ProcessName.Contains(strProcessesByName))
                {
                    try
                    {
                        p.Kill();
                        p.WaitForExit();
                    }
                    catch (Win32Exception e)
                    {
                        MessageBox.Show(e.Message.ToString());
                    }
                    catch (InvalidOperationException e)
                    {
                        MessageBox.Show(e.Message.ToString());
                    }
                }
            }
        }

        private void 退出FreyaLinkerRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            KillProcess("MangoService");
            KillProcess("FreyaLinkerR");
        }

        private void 安装Mango驱动ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MangoManger.installMangoDriver(true);
        }
    }
}
