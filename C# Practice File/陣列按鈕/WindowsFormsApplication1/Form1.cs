using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        
        int [] rand = new int[16];
        Random r = new Random();
        int time = 0;
        int ex = 1;
        public Form1()
        {
            InitializeComponent();
        }



        private void button17_Click(object sender, EventArgs e)
        {
            Button[] btn = new Button[] { btn0,btn1,btn2,btn3,btn4,btn5,btn6,btn7,btn8,btn9,btn10,btn11,btn12,btn13,btn14,btn15};
            for (int i = 0; i < 16; i++)
            {
                rand[i] = r.Next(16)+1;
                for(int j = 0; j < i; j++)
                {
                    while(rand[j] == rand[i])
                    {
                        j = 0;
                        rand[i] = r.Next(1,16)+1;
                    }
                }
            }
            for (int i = 0; i < 16; i++)
            {
                btn[i].Text = rand[i].ToString();
            }

            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            label1.Text = time.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (btn0.Text == ex.ToString())
            {
                btn0.Enabled = false;
                ex++;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (btn1.Text == ex.ToString())
            {
                btn1.Enabled = false;
                ex++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (btn2.Text == ex.ToString())
            {
                btn2.Enabled = false;
                ex++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (btn3.Text == ex.ToString())
            {
                btn3.Enabled = false;
                ex++;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (btn7.Text == ex.ToString())
            {
                btn7.Enabled = false;
                ex++;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (btn6.Text == ex.ToString())
            {
                btn6.Enabled = false;
                ex++;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (btn5.Text == ex.ToString())
            {
                btn5.Enabled = false;
                ex++;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (btn4.Text == ex.ToString())
            {
                btn4.Enabled = false;
                ex++;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (btn8.Text == ex.ToString())
            {
                btn8.Enabled = false;
                ex++;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (btn9.Text == ex.ToString())
            {
                btn9.Enabled = false;
                ex++;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (btn10.Text == ex.ToString())
            {
                btn10.Enabled = false;
                ex++;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (btn11.Text == ex.ToString())
            {
                btn11.Enabled = false;
                ex++;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (btn15.Text == ex.ToString())
            {
                btn15.Enabled = false;
                ex++;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (btn14.Text == ex.ToString())
            {
                btn14.Enabled = false;
                ex++;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (btn13.Text == ex.ToString())
            {
                btn13.Enabled = false;
                ex++;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (btn12.Text == ex.ToString())
            {
                btn12.Enabled = false;
                ex++;
            }
        }
    }
}
