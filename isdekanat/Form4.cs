using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace isdekanat
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename = textBox0.Text + ".txt";
            Process.Start(@filename);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 fr = new Form4();
        }
    }
}
