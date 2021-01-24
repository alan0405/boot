using boot.Service;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boot.Tools
{
    public class Options
    {        
        public string Name { get; set; }
        public string Icon { get; set; }
        public string CustomModel { get; set;}
        public Rectangle WindowPos { get; set; }    
    }
}
