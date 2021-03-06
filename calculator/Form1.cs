﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;

      

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1_result.Text=="0") || (isOperationPerformed))
            {
                textBox1_result.Clear();
            }

            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text==".")
            {
                if (!textBox1_result.Text.Contains(".") )
                {
                    textBox1_result.Text = textBox1_result.Text + button.Text;
                    
                }
            }else
            {
                textBox1_result.Text = textBox1_result.Text + button.Text;

            }

        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

           
            operationPerformed = button.Text;

            resultValue = Double.Parse(textBox1_result.Text);
            isOperationPerformed = true;
           
                labelOperation.Text = resultValue + " " + operationPerformed;
          
            

        }

        private void clear(object sender, EventArgs e)
        {
            textBox1_result.Text = "0";
            labelOperation.Text = "0";
        }

        private void onlyClear(object sender, EventArgs e)
        {
            textBox1_result.Text = "0";
            resultValue = 0;
            labelOperation.Text = "0";  
        }

        private void equal_button(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBox1_result.Text = (resultValue + Double.Parse(textBox1_result.Text)).ToString();
                    break;
                case "-":
                    textBox1_result.Text = (resultValue - Double.Parse(textBox1_result.Text)).ToString();
                    break;
                case "*":
                    textBox1_result.Text = (resultValue * Double.Parse(textBox1_result.Text)).ToString();
                    break;
                case "/":
                    textBox1_result.Text = (resultValue / Double.Parse(textBox1_result.Text)).ToString();
                    break;

                case "sin":

                    textBox1_result.Text = (Math.Sin((Convert.ToDouble(Math.PI) / 180) * (Convert.ToDouble(textBox1_result.Text)))).ToString();
                    break;
                case "cos":
                    textBox1_result.Text = (Math.Cos((Convert.ToDouble(Math.PI) / 180) * (Convert.ToDouble(textBox1_result.Text)))).ToString();
                    break;
                case "tan":
                    textBox1_result.Text = (Math.Tan((Convert.ToDouble(Math.PI) / 180) * (Convert.ToDouble(textBox1_result.Text)))).ToString();
                    break;

                case "sin-1":
                    textBox1_result.Text = (Math.Asin((Convert.ToDouble(Math.PI) / 180) * (Convert.ToDouble(textBox1_result.Text)))).ToString();
                    break;
                case "cos-1":

                    textBox1_result.Text = (Math.Acos((Convert.ToDouble(Math.PI) / 180) * (Convert.ToDouble(textBox1_result.Text)))).ToString();
                    break;
                case "tan-1":

                    textBox1_result.Text = (Math.Atan((Convert.ToDouble(Math.PI) / 180) * (Convert.ToDouble(textBox1_result.Text)))).ToString();
                    break;
                case "^":

                    textBox1_result.Text = Convert.ToString(System.Math.Pow(Convert.ToDouble(resultValue), Convert.ToDouble(textBox1_result.Text)));
                    break;
                case "%":
                    textBox1_result.Text = Convert.ToString(Convert.ToDouble(resultValue) % Convert.ToDouble(textBox1_result.Text));
                    break;
                case "x!":

                    textBox1_result.Text = Convert.ToString(1/ Convert.ToDouble(resultValue));
                    break;
                case "log10":

                    textBox1_result.Text = Convert.ToString(System.Math.Log10(Convert.ToDouble(textBox1_result.Text)));
                    break;
                case "log":

                    textBox1_result.Text = Convert.ToString(System.Math.Log(Convert.ToDouble(textBox1_result.Text)));
                    break;



                default:
                    break;

            }
        }

        private void back(object sender, EventArgs e)
        {
           string no1 = textBox1_result.Text;
            int n = no1.Length;
            if (n!=0)
            {
                textBox1_result.Text = (no1.Substring(0, n - 1));
            }
           
        }
    }
}
