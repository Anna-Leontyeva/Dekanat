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

namespace isdekanat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 fr = new Form3();
            fr.Show();
            
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 fr = new Form4();
            fr.Show();
        }

        private void добавитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 fr = new Form5();
            fr.Show();
        }

        private void удалитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
