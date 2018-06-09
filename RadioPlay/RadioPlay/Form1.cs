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
            this.IsMdiContainer = true;
            
        }


      

        private void Show_but_Click(object sender, EventArgs e)
        {
            ChidForm chidForm = new ChidForm();
            chidForm.Owner = this;
            chidForm.MdiParent = this;
            chidForm.Parent = groupBox2;
            chidForm.Show();
            //this.Hide();
        }
    }
}
