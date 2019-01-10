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
    public partial class frmdel : Form
    {
        public frmdel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
                MessageBox.Show("编号不可为空");

            else
            {
                string xie = "server='(local)';database='student_Mis';uid='sa';pwd='123'";
                SqlConnection an = new SqlConnection(xie); //创建连接对象
                an.Open(); //打开连接
                SqlCommand Command = new SqlCommand("select count(*) from user_T where id='" + textBox1.Text + "';", an);
                if ((int)Command.ExecuteScalar() == 0)
                {
                    MessageBox.Show("此管理员不存在！");
                    an.Close();


                }
                else
                {
                    SqlCommand MyCommand = new SqlCommand("delete  from user_T where id='" + textBox1.Text + "';", an);

                    if ((int)MyCommand.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("此管理员已删除！");
                        textBox1.Text = "";
                        an.Close();


                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
