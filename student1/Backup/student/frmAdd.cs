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
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
                MessageBox.Show("编号不可为空");
            else if (textBox2.Text.Length == 0)
                MessageBox.Show("账号不可为空");
            else if (textBox3.Text.Length == 0)
                MessageBox.Show("密码不可为空");
            else
            {
                string xie = "server='(local)';database='student_Mis';uid='sa';pwd='123'";
                SqlConnection an = new SqlConnection(xie); //创建连接对象
                an.Open(); //打开连接
                SqlCommand MyCommand = new SqlCommand("select count(*) from user_T where id='" + textBox1.Text + "';", an);
                if ((int)MyCommand.ExecuteScalar() > 0)
                {
                    MessageBox.Show("此管理员已存在！");
                    an.Close();


                }
                else
                {
                    SqlCommand cmd = new SqlCommand("insert into user_T(id,name,password) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')", an);

                    if (cmd.ExecuteNonQuery() > 0)
                    {

                        MessageBox.Show("数据已添加！");
                        an.Close();
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
