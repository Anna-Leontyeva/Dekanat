﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename = textBox0.Text + ".txt";
            StreamWriter file = new StreamWriter(filename);
            file.Close();
            this.Visible = false;
            Form3 fr = new Form3();
        }

        private void textBox0_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
