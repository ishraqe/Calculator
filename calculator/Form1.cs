using System;
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
              


                default:
                    break;

            }
        }

       
    }
}
