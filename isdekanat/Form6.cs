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
        // @"C:\Users\user\source\repos\Dekanat\isdekanat\bin\Debug"
        private void button2_Click(object sender, EventArgs e)
        {
            string pathToFile = @"C: \Users\user\source\repos\Dekanat\isdekanat\bin\Debug\Фмиит.txt";
            
            string[] allLines = File.ReadAllLines(pathToFile, Encoding.UTF8);
           
            foreach (string line in allLines)
                listBox1.Items.Add(line);
        }
    }
}
