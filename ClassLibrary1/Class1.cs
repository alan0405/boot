using boot;
using System.Diagnostics;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public class Class1:BaseModel
    {
        public void Create(string path)
        {
            var src = Application.StartupPath + "\\template";
            CopyFolder(src, path);
            Process.Start(path);
        }        
    }
}
