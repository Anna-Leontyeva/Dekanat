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
using System.Security.Cryptography.X509Certificates;

namespace isdekanat
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename = textBox6.Text + ".txt";

            //записать в него
            File.AppendAllText(filename, textBox1.Text + "  " + textBox2.Text + "  " + textBox3.Text + "  " + textBox4.Text + "  " + textBox5.Text + "\n");
            label7.Text = "Студент " + textBox2.Text + " добавлен";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form5 fr = new Form5();
        }
       
        public  void textBox1_TextChanged(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int value = rnd.Next(100000, 999999);

            string myString = value.ToString();
            this.textBox1.Text = myString;

        }

    }

}
