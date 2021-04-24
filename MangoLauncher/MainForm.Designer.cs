namespace TrayForm
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.选项 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showWindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.退出FreyaLinkerRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.安装Mango驱动ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选项.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.选项;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "FreyaLinkerR选项";
            this.notifyIcon.Visible = true;
            // 
            // 选项
            // 
            this.选项.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.选项.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.安装Mango驱动ToolStripMenuItem,
            this.showWindowMenuItem,
            this.exitMenuItem,
            this.toolStripSeparator1,
            this.退出FreyaLinkerRToolStripMenuItem});
            this.选项.Name = "contextMenuStrip1";
            this.选项.Size = new System.Drawing.Size(211, 134);
            // 
            // showWindowMenuItem
            // 
            this.showWindowMenuItem.Name = "showWindowMenuItem";
            this.showWindowMenuItem.Size = new System.Drawing.Size(210, 24);
            this.showWindowMenuItem.Text = "显示Mango日志";
            this.showWindowMenuItem.Click += new System.EventHandler(this.showWindowMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(210, 24);
            this.exitMenuItem.Text = "断开Mango连接";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // 退出FreyaLinkerRToolStripMenuItem
            // 
            this.退出FreyaLinkerRToolStripMenuItem.Name = "退出FreyaLinkerRToolStripMenuItem";
            this.退出FreyaLinkerRToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.退出FreyaLinkerRToolStripMenuItem.Text = "退出程序";
            this.退出FreyaLinkerRToolStripMenuItem.Click += new System.EventHandler(this.退出FreyaLinkerRToolStripMenuItem_Click);
            // 
            // 安装Mango驱动ToolStripMenuItem
            // 
            this.安装Mango驱动ToolStripMenuItem.Name = "安装Mango驱动ToolStripMenuItem";
            this.安装Mango驱动ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.安装Mango驱动ToolStripMenuItem.Text = "安装Mango驱动";
            this.安装Mango驱动ToolStripMenuItem.Click += new System.EventHandler(this.安装Mango驱动ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 305);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.选项.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip 选项;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出FreyaLinkerRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showWindowMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 安装Mango驱动ToolStripMenuItem;
    }
}

