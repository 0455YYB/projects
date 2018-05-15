using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace accessConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string accessdir = System.Environment.CurrentDirectory;
        string contring =  "HRP.accdb";
        string strConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=accessdir\\CSE_DEPT.accdb;Persist Security Info=False;";
        
        private void button1_Click(object sender, EventArgs e)
        {
            chidren1 cd1 = new chidren1();
            cd1.MdiParent = this;
            
            cd1.Show();
            try
            {
                OleDbConnection accconnection = new OleDbConnection(strConnectionString);
                accconnection.Open();
                MessageBox.Show("连接成功");
            }
            catch(Exception cone)
            {
                MessageBox.Show(cone.Message);
            }
            
            

        }

        private void cd1_Load(object sender, EventArgs e)
        {
            
        }

        private void 第一个ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assembly objasm = Assembly.LoadFrom(accessdir+"\\test1.dll");
            try
            {
                if (objasm is null)
                {
                    MessageBox.Show("创建窗口失败,无法加载dll");
                    return;
                }
                else
                {
                    Form obj = objasm.CreateInstance("test1.Form1") as Form;
                    if (obj is null)
                    {
                        MessageBox.Show("创建窗口失败，无法初始化类");
                    }
                    obj.Show();
                }
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message);
            }
        }
    }
}
