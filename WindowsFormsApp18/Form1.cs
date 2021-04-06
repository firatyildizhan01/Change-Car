using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void adlandır()
        {
            textBox1.Text = "FIRAT";
            textBox2.Text = "SOYAD";
            textBox3.Text = "ÖĞRENCİ";
            textBox4.Text = "25";
            textBox1.Focus();

        }
        private void temizle()
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox1.Focus();
        }
        void renklendir()
        {
            textBox1.BackColor = Color.Green;
            textBox2.BackColor = Color.Blue;
            textBox3.BackColor = Color.Yellow;
            textBox4.BackColor = Color.DarkBlue;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            renklendir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adlandır();
        }
    }
}
