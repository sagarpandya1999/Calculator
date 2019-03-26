using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_update
{
    public partial class Form1 : Form
    {
        
        decimal endResult = 0;
        decimal memoryStore = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)//code of button SQUARE ROOT
        {
            //int i = textBox1.Text.Length - 1;
            //if (i < 0) { }
            //else
            //{
            //    int number = 0;
            //    while (textBox1.Text[i] != '+' && textBox1.Text[i] != '-' && textBox1.Text[i] != '*' && textBox1.Text[i] != '/' && textBox1.Text[i] != '%' && i > 0)
            //    {
            //        number *= 10;
            //        number += Convert.ToInt16(textBox1.Text[i]);
            //        StringBuilder sb = new StringBuilder(textBox1.Text);
            //        sb.Remove(i, 1);
            //        textBox1.Text = sb.ToString();
            //        i--;
            //    }
            //    double rev = 0;
            //    while (number > 0)
            //    {
            //        int r = number % 10;
            //        rev = rev * 10 + r;
            //        number = number / 10;   
            //    }
            //    rev = Math.Sqrt(rev);
            //    textBox1.Text += Convert.ToString(rev);
            //}
            double temp = Convert.ToDouble(textBox1.Text);
            temp = Math.Sqrt(temp);
            textBox1.Text = Convert.ToString(temp);
        }

        private void button13_Click(object sender, EventArgs e)//code of button /
        {
            textBox1.Text += "/";
        }

        private void button18_Click(object sender, EventArgs e)//code of button 5
        {
            textBox1.Text += "5";
        }

        private void button17_Click(object sender, EventArgs e)//code of button 6
        {
            textBox1.Text += "6";
        }

        private void button23_Click(object sender, EventArgs e)//code of button 2
        {
            textBox1.Text += "2";
        }

        private void button21_Click(object sender, EventArgs e)//code of button -
        {
            textBox1.Text += "-";
        }

        private void button25_Click(object sender, EventArgs e)//code of button .
        {
            textBox1.Text += ".";
        }

        private void button27_Click(object sender, EventArgs e)//code of button 0
        {
            textBox1.Text += "0";
        }

        private void button9_Click(object sender, EventArgs e)//code of button 7
        {
            textBox1.Text += "7";
        }

        private void button1_Click(object sender, EventArgs e)//code of button MC
        {
            memoryStore = 0;
        }

        private void button7_Click(object sender, EventArgs e)//code of button CE
        {
            int i = textBox1.Text.Length - 1;
            if (i < 0) { }
            else
            {
                while (textBox1.Text[i] != '+' && textBox1.Text[i] != '-' && textBox1.Text[i] != '*' && textBox1.Text[i] != '/' && textBox1.Text[i] != '%' && i > 0)
                {
                    StringBuilder sb = new StringBuilder(textBox1.Text);
                    sb.Remove(i, 1);
                    textBox1.Text = sb.ToString();
                    i--;
                }
                //StringBuilder sb1 = new StringBuilder(textBox1.Text);
                //sb1.Remove(i, 1);
                //textBox1.Text = sb1.ToString();
            }
        }

        private void button11_Click(object sender, EventArgs e)//code of button (
        {
            textBox1.Text += "(";
            //int i = textBox1.Text.Length - 1;
            //if (i < 0) { }
            //else
            //{
            //    while (textBox1.Text[i] != '+' && textBox1.Text[i] != '-' && textBox1.Text[i] != '*' && textBox1.Text[i] != '/' && textBox1.Text[i] != '%' && i > 0)
            //    {
            //        StringBuilder sb = new StringBuilder(textBox1.Text);
            //        sb.Remove(i, 1);
            //        textBox1.Text = sb.ToString();
            //        i--;
            //    }
                
            //}
        }

        private void button8_Click(object sender, EventArgs e)//code of button C
        {
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)//code of button C
        {
            textBox1.Text += "1";
        }

        private void button22_Click(object sender, EventArgs e)//code of button C
        {
            textBox1.Text += "3";
        }

        private void button16_Click(object sender, EventArgs e)//code of button C
        {
            textBox1.Text += "4";
        }

        private void button15_Click(object sender, EventArgs e)//code of button C
        {
            textBox1.Text += "8";
        }

        private void button12_Click(object sender, EventArgs e)//code of button C
        {
            textBox1.Text += "9";
        }

        private void button26_Click(object sender, EventArgs e)//code of button C
        {
            textBox1.Text += "+";
        }

        private void button19_Click(object sender, EventArgs e)//code of button C
        {
            textBox1.Text += "*";
        }

        private void button14_Click(object sender, EventArgs e)//code of button )
        {
            textBox1.Text += ")";
        }

        private void button6_Click(object sender, EventArgs e)//code of button BACKSPACE
        {
            StringBuilder sb = new StringBuilder(textBox1.Text);
            sb.Remove(textBox1.Text.Length - 1 , 1);
            textBox1.Text = sb.ToString();
        }

        private void button28_Click(object sender, EventArgs e)//code of button C
        {
            DataTable dt = new DataTable();
            var ans = dt.Compute(textBox1.Text , "");
            textBox1.Text = Convert.ToString(ans);
        }

        private void button2_Click(object sender, EventArgs e)//code of button MR
        {
            textBox1.Text += memoryStore.ToString();
        }

        private void button3_Click(object sender, EventArgs e)//code of button MS
        {
            memoryStore = Decimal.Parse(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)//code of button M+
        {
            memoryStore += endResult;
        }

        private void button5_Click(object sender, EventArgs e)//code of button M-
        {
            memoryStore -= endResult;
        }

        private void button20_Click(object sender, EventArgs e)//code of button C
        {
            //int i = textBox1.Text.Length - 1;
            //if (i < 0) { }
            //else
            //{
            //    string temp = "";
            //    while (textBox1.Text[i] != '+' && textBox1.Text[i] != '-' && textBox1.Text[i] != '*' && textBox1.Text[i] != '/' && textBox1.Text[i] != '%' && i > 0)
            //    {
            //        temp += textBox1.Text[i];
            //        StringBuilder sb = new StringBuilder(textBox1.Text);
            //        sb.Remove(i, 1);
            //        textBox1.Text = sb.ToString();
            //        i--;
            //    }
            //    char[] charArray = temp.ToCharArray();
            //    Array.Reverse(charArray);
            //    temp = Convert.ToString(charArray);

                double ans = Convert.ToDouble(textBox1.Text);
                ans = 1 / ans;
                textBox1.Text = Convert.ToString(ans);
            //}
        }
}
}
