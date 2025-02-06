using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_new
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        string operationPerformed = "";
        bool isOpenoperationPerformed= false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || isOpenoperationPerformed)
                textBox1.Clear();
            Button button = (Button)sender;
            if (button.Text==".") {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text += button.Text;
            }
            else
                textBox1.Text += button.Text;
            isOpenoperationPerformed = false;
        }

        private void operate_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultValue != 0)
            {
                button16.PerformClick();
                operationPerformed = button.Text;
                resultValue = Double.Parse(textBox1.Text);
                label1.Text = resultValue + " " + operationPerformed;
                isOpenoperationPerformed = true;

            }
            else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(textBox1.Text);
                label1.Text = resultValue + " " + operationPerformed;
                isOpenoperationPerformed = true;
            }
        }
        

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text="0";
            resultValue = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            switch (operationPerformed) {
                case "+":
                    textBox1.Text = (resultValue + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (resultValue - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (resultValue * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (resultValue / Double.Parse(textBox1.Text)).ToString();
                    break;
            }
            resultValue=Double.Parse(textBox1.Text);
            label1.Text = " ";
        }
    }
}
