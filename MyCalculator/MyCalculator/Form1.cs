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
        private object txtboxDisplay;

        public MyCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (output.Text == "0")
            {
                output.Clear();
            }

            Button button = (Button)sender;
            output.Text = output.Text + button.Text; 

        }

        private void button6_Click(object sender, EventArgs e)
        {
            output.Text = "0";
        }
    }
}
