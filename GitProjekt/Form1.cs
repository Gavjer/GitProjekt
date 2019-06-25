using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitProjekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double a, b;
        int count;

        private void action()
        {
            switch (count)
            {
                case 1:
                    b = a + Convert.ToDouble(textBox1.Text);
                    listBox1.Items.Add($"{a} + {b} = {a + b}");
                    textBox1.Text = b.ToString();
                    
                    break;
                case 2:
                    b = a - Convert.ToDouble(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * Convert.ToDouble(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / Convert.ToDouble(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;

                default:
                    break;
            }
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            count = 1;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            count = 2;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            count = 3;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            count = 4;
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            action();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }
    }
}
