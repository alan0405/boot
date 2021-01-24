using boot.Tools;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace boot
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            GlobalBus.MainWindow = this;
        }
        private void Main_Load(object sender, EventArgs e)
        {
            LoadText();
            LoadIcon();
            StartServer();
            Base.SetCore();
            LoadModel();
            browser.Navigate("http://localhost:" + GlobalBus.WebServer.Port);
            fileSystemWatcher1.Path = Application.StartupPath;
        }
        public void LoadText()
        {
            string name = GlobalBus.Options.Name;
            if (name == null)
            {
                name = new DirectoryInfo(Application.StartupPath).Name;
            }

            label1.Text = name;
            Text = name;
        }
        private void LoadIcon()
        {
            string path = GlobalBus.Options.Icon;
            if (path == null)
            {
                path = Application.StartupPath + "/fav.ico";
            }
            if (File.Exists(path))
            {
                this.Icon = new Icon(path);
            }
        }
        private void StartServer()
        {
            GlobalBus.WebServer = new WebServer.Server();
            GlobalBus.WebServer.Start();
        }
        private void LoadModel()
        {
            string path = GlobalBus.Options.CustomModel;
            if (path == null)
            {
                path = Application.StartupPath + "\\bin";
                DirectoryInfo di = new DirectoryInfo(path);

                if (di.Exists == false)
                {
                    browser.ObjectForScripting = new BaseModel();
                    return;
                }
                FileInfo[] fis = di.GetFiles("*.dll");
                if (fis.Length == 0)
                {
                    browser.ObjectForScripting = new BaseModel();
                    return;
                }
                else if(fis.Length >1)
                {
                    MessageBox.Show("BIN目录下有多个DLL,请使用配置文件标记入口DLL!");
                    return;
                }
                path = fis[0].FullName;
            }

            try
            {
                Assembly ass = Assembly.LoadFrom(path);
                foreach (var t in ass.ExportedTypes)
                {
                    browser.ObjectForScripting = Activator.CreateInstance(ass.GetType(t.FullName));
                    return;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("客户模型加载时出现错误!");
                return;
            }

            return;
        }
        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            browser.Refresh(WebBrowserRefreshOption.Completely);
        }
        private void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            label1.Hide();
        }
    }
}
