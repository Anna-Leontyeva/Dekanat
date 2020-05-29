using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace isdekanat
{

    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form6 fr = new Form6();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\user\source\repos\Dekanat\isdekanat\bin\Debug");
            FileInfo[] files = dir.GetFiles("*.txt");
            foreach (FileInfo fi in files)
            {
                string a = System.IO.Path.GetFileNameWithoutExtension(fi.Name);
                listBox1.Items.Add(a);
            }
        }
    }
}
