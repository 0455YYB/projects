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
using System.Data.SQLite;

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

        private void button2_Click(object sender, EventArgs e)
        {
            SQLiteConnection.CreateFile("MyDatabase.sqlite");
            SQLiteConnection sqlConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            sqlConnection.Open();
            string sql = "create table highscores (name varchar(20), score int)";
            SQLiteCommand command = new SQLiteCommand(sql, sqlConnection);
            command.ExecuteNonQuery();

            string sql1 = "insert into highscores (name, score) values ('Me', 3000)";
            SQLiteCommand command1 = new SQLiteCommand(sql1, sqlConnection);
            command1.ExecuteNonQuery();

            string sql2 = "insert into highscores (name, score) values ('Myself', 6000)";
            command1 = new SQLiteCommand(sql2, sqlConnection);
            command1.ExecuteNonQuery();

            string  sql3 = "insert into highscores (name, score) values ('And I', 9001)";
            command1 = new SQLiteCommand(sql3, sqlConnection);
            command1.ExecuteNonQuery();

            sqlConnection.Close();
            MessageBox.Show("SQLite测试成功");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            string sql = "select * from highscores";
            SQLiteCommand sqlCommand = new SQLiteCommand(sql,sqlConnection);
            SQLiteDataReader  dt;
            sqlConnection.Open();
            dt = sqlCommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add(dt.GetName(0));
            dataTable.Columns.Add(dt.GetName(1));
            int i = 0;
            
            while (dt.Read())
            {
                int j = 0;
                dataTable.Rows.Add();
                dataTable.Rows[i][j] = dt.GetValue(0);
                dataTable.Rows[i][j + 1] = dt.GetValue(1);                
            }
            dataGridView1.DataSource = dataTable;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            string xmlFileName = "\\config.xml";
            person= ReadXML.getPerson(person,xmlFileName);
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("person");
            dataTable.Columns.Add("age");
            dataTable.Columns.Add("email");
            dataTable.Rows.Add();
            dataTable.Rows[0][0] = person.name;
            dataTable.Rows[0][1] = person.age;
            dataTable.Rows[0][2] = person.email;
            dataGridView1.DataSource = dataTable;
        }
    }
}
