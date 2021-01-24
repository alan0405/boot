using boot.Service;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Runtime.Remoting;
using System.Web.UI.WebControls.Expressions;
using System.Windows.Forms;

namespace boot
{
    public class BaseModel
    {
        /// <summary>
        /// 弹出简易log窗口显示信息
        /// </summary>
        /// <param name="msg"></param>
        public void log(string msg)
        {
            if (GlobalBus.ConsoleWindow == null)
            {
                GlobalBus.ConsoleWindow = new Console();
            }
            GlobalBus.ConsoleWindow.insert(msg);
            GlobalBus.ConsoleWindow.Show();
        }

        #region 窗口设置
                
        public void SetWindowPos(int x, int y, int width, int height)
        {
            if (GlobalBus.MainWindow == null)
            {
                return;
            }

            if (x > -1)
            {
                GlobalBus.MainWindow.Left = x;
            }
            if (y > -1)
            {
                GlobalBus.MainWindow.Top = y;
            }
            if (width > -1)
            {
                GlobalBus.MainWindow.Width = width;
            }
            if (height > -1)
            {
                GlobalBus.MainWindow.Height = height;
            }
        }
        public void SetText(string text)
        {
            GlobalBus.MainWindow.Text = text;
        }
        public void SetIcon(string path)
        {
            GlobalBus.MainWindow.Icon = new Icon(path);
        }
        public string OpenFolder()
        {
            string result = "";
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                result = fbd.SelectedPath;
            }
            return result;
        }
        public void Msg(string content)
        {
            MessageBox.Show(content);
        }
        public void Start(string command)
        {
            Process.Start(command);
        }
        #endregion

        #region 文件操作
        public string ReadFile(string path)
        {
            return FileService.Read(path);
        }
        public void WriteFile(string path ,string content)
        {
            FileService.Write(path, content);
        }
        public void AppendFile(string path,string content)
        {
            FileService.Append(path, content);
        }
        public void RemoveFile(string path)
        {
            FileService.Remove(path);
        }
        public void RemoveFolder(string path)
        {
            FileService.RemoveFolder(path);
        }
        public void CopyFile(string src,string des)
        {
            File.Copy(src, des);
        }
        public void CopyFolder(string src,string des)
        {
            DirectoryInfo srcDi = new DirectoryInfo(src);
            DirectoryInfo desDi = new DirectoryInfo(des);
            if (srcDi.Exists == false) return;
            if (desDi.Exists == false) desDi.Create();
            foreach (FileInfo item in srcDi.GetFiles())
            {
                item.CopyTo(des + "\\" + item.Name,true);
            }
            foreach (DirectoryInfo item in srcDi.GetDirectories())
            {
                CopyFolder(item.FullName, des + "\\" + item.Name);
            }
        }
        #endregion
    }
}
