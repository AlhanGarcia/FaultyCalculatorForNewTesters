using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadCalculator
{
    public partial class Form1 : Form
    {
        public float num1, num2, ans;
        public int count;
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        public void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        public void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            count = 0;
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        public void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        public void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0+0;
        }

        public void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        public void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        public void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        public void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        public void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        public void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        public void button18_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 2;
        }

        public void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 1;
            }
        }

        public void button15_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 3;
        }

        public void button11_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 4;
        }

        public void button17_Click(object sender, EventArgs e)
        {
            compute(count);
        }

        public void button14_Click(object sender, EventArgs e)
        {
            int c = textBox1.TextLength;
            int flag = 0;
            string text = textBox1.Text;
            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ".")
                {
                    flag = 1; break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }

        public void setNumber1(float num)
        {
            num1 = num;
        }

        public void setNumber2(float num)
        {
            num2 = num;
        }

        public void compute(int count)
        {
            num2 = float.Parse(textBox1.Text);
            ans = Logic.compute(num1, num2, count);
            textBox1.Text = ans.ToString();
        }


    }
}
