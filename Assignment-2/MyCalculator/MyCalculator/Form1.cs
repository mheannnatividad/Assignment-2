using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class MyCalculator : Form
    {
        double result = 0;
        string op_perform = "";
        bool is_operation = false;

        public MyCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void number_period_click(object sender, EventArgs e)
        {
            if (output.Text == "0" || is_operation)
            {
                output.Text = "";
            }

            is_operation = false;
            Button numbers_period = (Button)sender;

            if (numbers_period.Text == ".")
            {
                if (!output.Text.Contains("."))
                {
                    output.Text = output.Text + numbers_period.Text;
                }
            }
            else
            {
                output.Text = output.Text + numbers_period.Text;
            }

            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Button operators = (Button)sender;

            if (result != 0)
            {
                button37.PerformClick();
                op_perform = operators.Text;
                is_operation = true;
            }
            else
            {
                op_perform = operators.Text;
                result = double.Parse(output.Text);
                is_operation = true;
            }

            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            output.Text = "0";
            result = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int index_last = output.Text.Length - 1;
            output.Text = output.Text.Remove(index_last);

            if (output.Text == "")
            {
                output.Text = "0";
            }
            
        }

        private void button37_Click(object sender, EventArgs e)
        {
            switch (op_perform)
            {
                case "+":
                    output.Text = (result + double.Parse(output.Text)).ToString();
                    break;
                case "-":
                    output.Text = (result - double.Parse(output.Text)).ToString();
                    break;
                case "*":
                    output.Text = (result * double.Parse(output.Text)).ToString();
                    break;
                case "/":
                    output.Text = (result / double.Parse(output.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = double.Parse(output.Text);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            result = double.Parse(output.Text);
            result = result * -1;
            output.Text = result.ToString();
            //plusMinus = double.Parse(result_textbox.Text);
            //plusMinus = plusMinus * -1;
            //result_textbox.Text = plusMinus.ToString();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            result = Math.Log(double.Parse(output.Text));
            output.Text = result.ToString();
            
        }

        private void button28_Click(object sender, EventArgs e)
        {
            result = Math.Log10(double.Parse(output.Text));
            output.Text = result.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            result = Math.Pow(10, double.Parse(output.Text));
            output.Text = result.ToString();
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            result = Math.Sqrt(double.Parse(output.Text));
            output.Text = result.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            result = Math.Pow(double.Parse(output.Text), 2);
            output.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            result = Math.PI;
            output.Text = result.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            result = Math.E;
            output.Text = result.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            result = 1 / double.Parse(output.Text);
            output.Text = result.ToString();
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            result = Math.Abs(double.Parse(output.Text));
            output.Text = result.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            result = Math.Exp(double.Parse(output.Text));
            output.Text = result.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            output.Text = (result % double.Parse(output.Text)).ToString();
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            result = int.Parse(output.Text);
            int factorial = 1;

            if (result < 0)
            {
                MessageBox.Show("negative value can't be factorial", "Information", MessageBoxButtons.OK);
                output.Text = "0";
            }
            else if (result <= 1)
            {
                output.Text = result.ToString();
            }
            else
            {
                for (int i = (int)result; i >=2; i--)
                {
                    factorial = factorial * i;
                }

                output.Text = factorial.ToString();
            }
            
        }
    }
}
