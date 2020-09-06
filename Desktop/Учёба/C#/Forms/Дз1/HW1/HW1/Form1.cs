using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }

 
        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
                textBox1.Text += (sender as Button).Text;
        }

        private bool isDot = false;
        private void comma_Click(object sender, EventArgs e)
        {
            int n = textBox1.TextLength;
            char[] str = textBox1.Text.ToCharArray();
            if (textBox1.Text != "")
            {

                for (int i = 0; i < n; i++)
                {
                    if (str[i] == ',')
                    {
                        isDot = true;
                        break;
                    }
                    else
                    {
                        isDot = false;
                    }
                }

                if (!isDot)
                    {
                        this.textBox1.Text += ",";
                    }
                
            }
           

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += (sender as Button).Text;
        }

        private decimal a = 0, b = 0, c = 0;
        private int test;
        private void equally_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "-" && textBox1.Text != "")
            {
                if(test==0)
                    b = Convert.ToDecimal(textBox1.Text);
                else
                {
                    a= Convert.ToDecimal(textBox1.Text);
                }
                switch (znak)
                {
                    case '+':
                        c = a + b;
                        break;
                    case '-':
                        c = a - b;
                        break;
                    case 'x':
                        c = a * b;
                        break;
                    case '/':
                        if (b == 0)
                            c = 0;
                        else
                            c = a / b;
                        break;
                }
                textBox1.Text = c.ToString();
                test = 1;
            }
        }

        private void ac_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "0";
        }

        private void plusminus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "-")
            {
                textBox1.Clear();
            }
            else if (textBox1.Text != "")
            {
                a = Convert.ToDecimal(textBox1.Text);
                a = a * (-1);
                textBox1.Text = a.ToString();
            }
            else
            {
                textBox1.Text = "-";
            }
        }

        private void clean_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            if (textBox1.Text == "")
                textBox1.Text = "0";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.ForeColor = Color.Red;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.ForeColor = Color.Black;
        }

        private char znak = '+';
        private void plus_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
                {
                    a = Convert.ToDecimal(textBox1.Text);
                    test = 0;
                }
            znak = (sender as Button).Text[0];
            textBox1.Clear();
        }

        private Point lastPoint;

        private void Calculater_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Calculater_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
