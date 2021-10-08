using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hız_zaman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        float zaman, yol,hız;
        private void hesapla2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text=="saat")
            {
                hız = float.Parse(textBox2.Text);
                zaman = float.Parse(textBox1.Text);
                yol = zaman * hız;
                MessageBox.Show("Hesaplanan Yol: " + yol);
            }
            else if (comboBox1.Text == "dakika")
            {
                hız = float.Parse(textBox2.Text);
                zaman = float.Parse(textBox1.Text);
                hız = hız / 60;
                yol = zaman * hız;
                MessageBox.Show("Hesaplanan Yol: " + yol);
            }
            else if (comboBox1.Text == "saniye")
            {
                hız = float.Parse(textBox2.Text);
                zaman = float.Parse(textBox1.Text);
                hız = hız / 120;
                yol = zaman * hız;
                MessageBox.Show("Hesaplanan Yol: " + yol);
            }
            else
            {
                MessageBox.Show("Lütfen Geçerli bir Zaman birimi giriniz");
            }
        }
    }
}
