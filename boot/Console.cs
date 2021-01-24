using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boot
{
    public partial class Console : Form
    {
        public Console()
        {
            InitializeComponent();
        }

        public void insert(string content)
        {
            textBox1.Text += content + " \r\n";
        }

        private void Console_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalBus.ConsoleWindow = null;
        }
    }
}
