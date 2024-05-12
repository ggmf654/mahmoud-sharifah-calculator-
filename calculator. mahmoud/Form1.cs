using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;




namespace calculator.mahmoud
{
    public partial class Form1 : Form
    {
        calClass1 calculator = new calClass1();

        double num1;
        double num2;
        string opr;


        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(l1.Text);
            opr = "sub";
            l2.Text = l1.Text + "-";
            l1.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            l1.Text = "";
            l2.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            l1.Text = null;
            l2.Text = null; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(l1.Text);
            opr = "div";
            l2.Text = l1.Text + "/";
            l1.Text = "";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(l1.Text);
            opr = "multi";
            l2.Text = l1.Text + "X";
            l1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            num1 = Convert.ToDouble(l1.Text);
            opr = "sum";
            l2.Text = l1.Text + "+";
            l1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            l1.Text = l1.Text + ".";

        }

        private void button17_Click(object sender, EventArgs e)
        {
           
            l1.Text =l1.Text + "1";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(l1.Text);
            l2.Text = l2.Text + l1.Text;
            l1.Text = "";
            switch (opr)
            {
                case "sum":
                    {
                        l1.Text = Convert.ToString(calculator.sum(num1, num2));
                       
                    }
                    break;
                case "sub":
                    {
                    l1.Text = Convert.ToString(calculator.sub(num1, num2));
                   
                    }
                    break;

                case "multi":
                    {
                        l1.Text = Convert.ToString(calculator.multi(num1, num2));
                      
                    }
                    break;

                case "div":
                    {
                        l1.Text = Convert.ToString(calculator.div(num1, num2));
                       l2.Text = "";
                    }
                    break;

                case "perce":
                    {
                        l1.Text = Convert.ToString(calculator.Percentage (num1, num2));
                       
                    }
                    break;
            }









            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            l1.Text = l1.Text + "2";
      
        }

        private void button9_Click(object sender, EventArgs e)
        {
            l1.Text = l1.Text + "3";

        }

        private void button16_Click(object sender, EventArgs e)
        {
            l1.Text = l1.Text + "4";

        }

        private void button12_Click(object sender, EventArgs e)
        {


            l1.Text = l1.Text + "5";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            l1.Text = l1.Text + "6";
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            l1.Text = l1.Text + "7";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            l1.Text = l1.Text + "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            l1.Text = l1.Text + "9";
        }

        private void l2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(l1.Text);
            opr = "perce";
            l2.Text = l1.Text + "%";
            l1.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            l1.Text = l1.Text + "0";
        }
    }
}
