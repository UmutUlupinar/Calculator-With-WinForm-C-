using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesiPro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double x, y;
        string işlem = "";

    


        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void labelText_Click(object sender, EventArgs e)
        {

        }

        private void toplama_Click(object sender, EventArgs e)
        {
            işlem = "+";
            x = Convert.ToDouble(textBox1.Text);
            textBox1.Text += "+";
            labelText.Text += textBox1.Text;
            textBox1.Text = "";
        }

        private void çıkarma_Click(object sender, EventArgs e)
        {
            işlem = "-";
            x = Convert.ToDouble(textBox1.Text);
            textBox1.Text += "-";
            labelText.Text += textBox1.Text;
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            işlem = "*";
            x = Convert.ToDouble(textBox1.Text);
            textBox1.Text += "*";
            labelText.Text += textBox1.Text;
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            işlem = "/";
            x = Convert.ToDouble(textBox1.Text);
            textBox1.Text += "/";
            labelText.Text += textBox1.Text;
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            labelText.Text = "";
            x = 0;
            y = 0;
            işlem = "";
        }

        private void fibonacci_Click(object sender, EventArgs e)
        {

            metodlarım.fibonacciMethod(Convert.ToInt32(textBox1.Text));

        }

        private void button11_Click(object sender, EventArgs e)//eşittir , equal
        {
            double s = x;
            y = Convert.ToDouble(textBox1.Text);
            labelText.Text += textBox1.Text;
            if ( işlem== "+")
            {
                s += y;
                textBox1.Text=Convert.ToString(s);
            }

            else if (işlem == "-")
            {
                textBox1.Text = Convert.ToString(x - y);
            }

            else if (işlem == "*")
            {
                textBox1.Text = Convert.ToString(x * y);
            }

            else if (işlem == "/")
            {
                textBox1.Text = Convert.ToString(x / y);
            }



           
        }


        
    }
}
