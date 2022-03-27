using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
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

        public static double MakeAmount = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (dollarTextBox.Text == "0" && dollarTextBox.Text != null)
            {
                dollarTextBox.Text = "1";
            }
            else
            {
                dollarTextBox.Text = dollarTextBox.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dollarTextBox.Text == "0" && dollarTextBox.Text != null)
            {
                dollarTextBox.Text = "2";
            }
            else
            {
                dollarTextBox.Text = dollarTextBox.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dollarTextBox.Text == "0" && dollarTextBox.Text != null)
            {
                dollarTextBox.Text = "3";
            }
            else
            {
                dollarTextBox.Text = dollarTextBox.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dollarTextBox.Text == "0" && dollarTextBox.Text != null)
            {
                dollarTextBox.Text = "4";
            }
            else
            {
                dollarTextBox.Text = dollarTextBox.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dollarTextBox.Text == "0" && dollarTextBox.Text != null)
            {
                dollarTextBox.Text = "5";
            }
            else
            {
                dollarTextBox.Text = dollarTextBox.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dollarTextBox.Text == "0" && dollarTextBox.Text != null)
            {
                dollarTextBox.Text = "6";
            }
            else
            {
                dollarTextBox.Text = dollarTextBox.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dollarTextBox.Text == "0" && dollarTextBox.Text != null)
            {
                dollarTextBox.Text = "7";
            }
            else
            {
                dollarTextBox.Text = dollarTextBox.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (dollarTextBox.Text == "0" && dollarTextBox.Text != null)
            {
                dollarTextBox.Text = "8";
            }
            else
            {
                dollarTextBox.Text = dollarTextBox.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (dollarTextBox.Text == "0" && dollarTextBox.Text != null)
            {
                dollarTextBox.Text = "9";
            }
            else
            {
                dollarTextBox.Text = dollarTextBox.Text + "9";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (dollarTextBox.Text == "0" && dollarTextBox.Text != null)
            {
                dollarTextBox.Text = "0";
            }
            else
            {
                dollarTextBox.Text = dollarTextBox.Text + "0";
            }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            subTextBox.Text = dollarTextBox.Text;
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            if (dollarTextBox.Text == "0" && dollarTextBox.Text != null)
            {
                dollarTextBox.Text = ".";
            }
            else
            {
                dollarTextBox.Text = dollarTextBox.Text + ".";
            }
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            double subtotal;
            double result;
            subtotal = Convert.ToDouble(subTextBox.Text);

            if (subtotal <= 100)
            {
                result = (subtotal * 0.05) + subtotal;
                totalTextBox.Text = result.ToString();
                taxTextBox.Text = ("" + subtotal * 0.05);
            }
            else if (subtotal >= 100 && subtotal < 499)
            {
                result = (subtotal * 0.075) + subtotal;
                totalTextBox.Text = result.ToString();
                taxTextBox.Text = ("" + subtotal * 0.075);
            }
            else if (subtotal > 499)
            {
                result = (subtotal * 0.10) + subtotal;
                totalTextBox.Text = result.ToString();
                taxTextBox.Text = ("" + subtotal * 0.10);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dollarTextBox.Text != string.Empty)
            {
                int length = dollarTextBox.Text.Length;
                if (length != 1)
                {
                    dollarTextBox.Text = dollarTextBox.Text.Remove(length - 1);
                }
                else
                {
                    dollarTextBox.Text = 0.ToString();
                }
                subTextBox.Text = "";
                taxTextBox.Text = "";
                totalTextBox.Text = "";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            dollarTextBox.Text = "";
            subTextBox.Text = "";
            taxTextBox.Text = "";
            totalTextBox.Text = "";
        }
    }
}
