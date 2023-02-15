using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            double x = double.Parse(textBox1.Text);
            textBox2.Text += "X= " + x.ToString();
            double y = double.Parse(textBox4.Text);
            textBox2.Text += Environment.NewLine + "Y= " + y.ToString();
            double z = double.Parse(textBox3.Text);
            textBox2.Text += Environment.NewLine + "Z= " + z.ToString();

            double a = Math.Round(((Math.Pow(Math.Sin(z), 2) / Math.Sqrt(x + y)) + 1) * Math.Abs(x - y),4);
            double u = Math.Round(Math.Pow(Math.E, Math.Abs(x - y)) + (x / 2), 4);
            double c = Math.Round(Math.Pow(y, Math.Pow((Math.Abs(x)), 0.334)) + Math.Pow(Math.Cos(y), 3),4);
            double b = Math.Round(c * (a / u), 4);
            textBox2.Text += Environment.NewLine + "b = " + b.ToString();
            textBox2.Text += Environment.NewLine + "a = " + a.ToString();
            textBox2.Text += Environment.NewLine + "u = " + u.ToString();
            textBox2.Text += Environment.NewLine + "c = " + c.ToString();
        }
    }
}
