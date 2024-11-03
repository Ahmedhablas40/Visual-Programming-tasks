using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_1
{
    public partial class Form1 : Form
    {
        string operation = "";
        double result = 0;
        bool isoperation = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button10_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            operation = but.Text;
            result = double.Parse(textBox1.Text);
            isoperation = true;
        }



        private void button16_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            if (textBox1.Text == "0" || isoperation == true ) { textBox1.Clear(); }
            if (textBox1.Text == ".")
            {
                if (!textBox1.Text.Contains(".")) { textBox1.Text = textBox1.Text + but.Text; }
            }
            else
            {
                textBox1.Text = textBox1.Text + but.Text;
            }
            isoperation = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":

                    textBox1.Text = (result + double.Parse(textBox1.Text)).ToString();
                    break;

                case "-":

                    textBox1.Text = (result - double.Parse(textBox1.Text)).ToString();
                    break;

                case "*":

                    textBox1.Text = (result * double.Parse(textBox1.Text)).ToString();
                    break;

                case "/":

                    textBox1.Text = (result / double.Parse(textBox1.Text)).ToString();
                    break;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            double result = 0;

        }
    }
}
