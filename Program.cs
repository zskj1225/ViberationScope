using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ViberationScope
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();//应用程序启用可视化应用程序
            Application.SetCompatibleTextRenderingDefault(false);//使用GDI方式显示文本
            Application.Run(new Form1());//运行窗口
        }
    }
}
