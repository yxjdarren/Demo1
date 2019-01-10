using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace student
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public void NewMessageLook()
        {
            Form a = new frmMain();
            Application.Run(a);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string xie = "server='(local)';database='student_Mis';uid='sa';pwd='123456'";
            SqlConnection an = new SqlConnection(xie); //创建连接对象
            an.Open(); //打开连接
            SqlCommand MyCommand = new SqlCommand("select count(*) from user_T where name='" + textBox1_1.Text + "'" + "and password= '" + textBox1_2.Text + "'", an);
            if ((int)MyCommand.ExecuteScalar() == 1)
            {
                System.Threading.Thread t = new
                System.Threading.Thread(new System.Threading.ThreadStart(NewMessageLook));
                t.Start();
                this.Close();
            }
            else
            {
                MessageBox.Show(" 用户名或密码错误！");
                textBox1_2.Text = "";
                textBox1_1.Text = "";
            }
            an.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         Close();
        }
    }
}
