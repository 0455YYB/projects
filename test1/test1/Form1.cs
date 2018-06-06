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

<<<<<<< HEAD
        private void button1_Click(object sender, EventArgs e)
        {
            string appPath = System.Environment.CurrentDirectory;
            textBox4.Text = appPath;
=======
        public static Form1 CreateInstance()
        {
            if(form==null)
            {
                form = new Form1();
                return form;
            }
            return form;
>>>>>>> 5b509ca84de2a8a476c19db3e7eb2a96409875dd
        }
    }
}
