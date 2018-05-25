using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;

namespace RadioPlay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int winStatus = 1;
            timer1.Enabled = true;
            timer1.Interval = 100;
            this.MoveLable();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void MoveLable()
        {
            if (label1.Left<=this.Width)
            {
                label1.Left -= 1;
                if(label1.Right==Width)
                {
                    label1.Left = this.Width;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChidForm chidForm = new ChidForm();
            chidForm.Owner = this;
            chidForm.Show();
            this.Hide();
        }
    }
}
