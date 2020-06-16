using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _088_PA9_JiaBao
{
    public partial class Form1 : Form
    {
        public double userInput;
        public double convertedAmount;

        double USDollar = 0.74;
        double YenDollar = 81.97;
        double MYDollar = 3.01;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            try
            {
                userInput = double.Parse(txt_Amount.Text);
                if (userInput < 0)
                {
                    txt_Amount.Text = "Please enter a valid amount";
                }
                else
                {
                    if (rb_US.Checked)
                    {
                        convertedAmount = userInput * USDollar;
                        txt_Converted.Text = convertedAmount.ToString();
                    }
                    else if (rb_Yen.Checked)
                    {
                        convertedAmount = (userInput * YenDollar);
                        txt_Converted.Text = convertedAmount.ToString();
                    }
                    else if (rb_MY.Checked)
                    {
                        convertedAmount = (userInput * MYDollar);
                        txt_Converted.Text = convertedAmount.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Please select a currency!");
                    }
                }
            }
            catch(Exception)
            {
                txt_Amount.Text = "Please enter a valid amount";
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Amount.Clear();
            txt_Converted.Clear();
            rb_US.Checked = false;
            rb_Yen.Checked = false;
        }
    }
}
