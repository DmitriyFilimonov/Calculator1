using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double _number;

        private string _action;

        public void NumberButton_Click(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }

        public void PlusButton_Click(object sender, EventArgs e)
        {
            _number = Convert.ToDouble(textBox1.Text);

            _action = "plus";

            textBox1.Text = "";
        }

        public void MinusButton_Click(object sender, EventArgs e)
        {
            _number = Convert.ToDouble(textBox1.Text);

            _action = "minus";

            textBox1.Text = "";
        }

        public void MultiplyButton_Click(object sender, EventArgs e)
        {
            _number = Convert.ToDouble(textBox1.Text);

            _action = "multiply";

            textBox1.Text = "";
        }
        public void DivideButton_Click(object sender, EventArgs e)
        {
            _number = Convert.ToDouble(textBox1.Text);

            _action = "divide";

            textBox1.Text = "";
        }

        public void ResultButton_Click(object sender, EventArgs e)
        {
            switch (_action)
            {
                case "plus":
                    textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) + _number) + "";
                    break;

                case "minus":
                    textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) - _number) + "";
                    break;

                case "multiply":
                    textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * _number) + "";
                    break;

                case "divide":
                    textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) / _number) + "";
                    break;
            }
        }

    }
    }
