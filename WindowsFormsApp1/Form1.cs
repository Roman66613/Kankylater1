using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string _sign;
        private double _firstNum;

        private void button13_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                _sign = btn.Text.ToString();
                _firstNum = Convert.ToDouble(textBox1.Text);
                textBox1.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка!\n" + ex);
                textBox1.Text = string.Empty;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            _firstNum = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double secondNum = Convert.ToDouble(textBox1.Text);
                textBox1.Text = string.Empty;
                switch (_sign)
                {
                    case "+":
                        textBox1.Text = (_firstNum + secondNum).ToString();
                        break;
                    case "-":
                        textBox1.Text = (_firstNum - secondNum).ToString();

                        break;
                    case "x":
                        textBox1.Text = (_firstNum * secondNum).ToString();

                        break;
                    case "/":
                        textBox1.Text = (_firstNum / secondNum).ToString();

                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка!" + ex);
                textBox1.Text = string.Empty;
            }
        }
    }
}