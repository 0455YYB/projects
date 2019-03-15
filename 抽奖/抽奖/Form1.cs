using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 抽奖
{
    public partial class Form1 : Form
    {
        public int start = 1;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text==null)
            {
                MessageBox.Show("请输入最大人数");
            }
            else
            {
                if (start == 1)
                {
                    button1.Text = "停 止";
                    start = 0;
                    timer1.Start();
                }
                else
                {
                    button1.Text = "开 始";
                    start = 1;
                    timer1.Stop();

                }
            }
            

        

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int maxNumber = Convert.ToInt32(textBox2.Text);
            Random rd = new Random();
            int lukyNumber = rd.Next(1, maxNumber);
            textBox1.Text = lukyNumber.ToString();
          
        }
    }
}
