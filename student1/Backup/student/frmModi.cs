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
    public partial class frmModi : Form
    {
        public frmModi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length == 0)
                MessageBox.Show("账号不可为空");
            else if (textBox2.Text.Length == 0)
                MessageBox.Show("新密码不可为空");
            else
            {
                string xie = "server='(local)';database='student_Mis';uid='sa';pwd='123'";
                SqlConnection an = new SqlConnection(xie); //创建连接对象
                an.Open(); //打开连接
                SqlCommand MyCommand = new SqlCommand("update user_T set password='" + textBox2.Text + "'where name='" + textBox1.Text + "'", an);
                if (MyCommand.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("已修改！");
                    an.Close();
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
