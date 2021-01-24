using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boot.Tools
{
    public static class Log
    {
        /// <summary>
        /// 弹出简易log窗口显示信息
        /// </summary>
        /// <param name="msg"></param>
        public static void Console(string msg)
        {
            if (GlobalBus.ConsoleWindow == null)
            {
                GlobalBus.ConsoleWindow = new Console();
            }
            GlobalBus.ConsoleWindow.insert(msg);
            GlobalBus.ConsoleWindow.Show();
        }

        public static void Error(string msg)
        {
            Service.FileService.Append(Application.StartupPath + "\\ErrorLog.txt", msg);
        }
        
        public static void Info(string msg)
        {
            Service.FileService.Append(Application.StartupPath + "\\InfoLog.txt", msg);
        }
    }
}
