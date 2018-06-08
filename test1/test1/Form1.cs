using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test1
{
    public partial class Form1 : Form
    {
        private static Form1 form=null;
        private Form1()
        {
            InitializeComponent();
        }

        public static Form1 CreateInstance()
        {
            if(form==null)
            {
                form = new Form1();
                return form;
            }
            return form;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
