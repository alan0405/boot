using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boot.Service
{
    public static class FileService
    {
        public static string Read(string path)
        {
            if (File.Exists(path))
            {
                return File.ReadAllText(path);
            }
            return "";
        }
        static void CheckPath(DirectoryInfo di)
        {
            if (di.Parent.Exists == false)
            {
                CheckPath(di.Parent);
            }
            di.Create();
        }
        public static void Write(string path, string content)
        {
            FileInfo fi = new FileInfo(path);
            if (fi.Exists == false)
            {
                if (fi.Directory.Exists == false) fi.Directory.Create();
            }
            File.WriteAllText(fi.FullName, content);
        }

        public static void Append(string path,string content)
        {
            FileInfo fi = new FileInfo(path);
            if (fi.Exists == false)
            {
                if (fi.Directory.Exists == false) fi.Directory.Create();                
            }           
            File.AppendAllText(fi.FullName, content);
        }

        public static void Remove(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }        
        public static void RemoveFolder(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            di.Delete(true);
        }
    }
}
