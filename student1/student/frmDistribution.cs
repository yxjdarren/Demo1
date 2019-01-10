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
    public partial class frmDistribution : Form
    {
        public frmDistribution()
        {
            InitializeComponent();
            calculate();
            get_db1("");
        }
        sqlConnect con = new sqlConnect();

        private void calculate()
        {
            string Cno = txtCno.Text.ToString();
            SqlConnection cnn = new SqlConnection("Data Source=(local);database=student_Mis;uid=sa;password=123456;");
            string sql1 = "delete from DisGPA80";
            con.OperateData(sql1);
            string sql2 = "delete from DisGPA60";
            con.OperateData(sql2);
            string sql3 = "delete from DisGPA00";
            con.OperateData(sql3);
            string sql4 = "delete from DisGPA";
            con.OperateData(sql4);
            string str = @"insert into DisGPA80(Cno,DisGPA) select Cno,count(*) from  Reports where Grade>=80 GROUP BY Cno";
            con.OperateData(str);
            string str1 = @"UPDATE DisGPA80 SET Grade = '80-100' ";
            con.OperateData(str1);
            string str2 = @"insert into DisGPA60(Cno,DisGPA) select Cno,count(*) from  Reports where Grade>=60 and Grade<80 GROUP BY Cno";
            con.OperateData(str2);
            string str3 = @"UPDATE DisGPA60 SET Grade = '60-80' ";
            con.OperateData(str3);
            string str4 = @"insert into DisGPA00(Cno,DisGPA) select Cno,count(*) from  Reports where Grade>0 and Grade<60 GROUP BY Cno";
            con.OperateData(str4);
            string str5 = @"UPDATE DisGPA00 SET Grade = '0-60' ";
            con.OperateData(str5);
            string str6 = @"insert into DisGPA(Cno,DisGPA,Grade) select * from  DisGPA80";
            con.OperateData(str6);
            string str7 = @"insert into DisGPA(Cno,DisGPA,Grade) select * from  DisGPA60";
            con.OperateData(str7);
            string str8 = @"insert into DisGPA(Cno,DisGPA,Grade) select * from  DisGPA00";
            con.OperateData(str8);
            //SqlCommand cmd1 = new SqlCommand(str1, cnn);
            //string str1 = @"insert into DisGPA(Cno,DisGPA) select count(*)  from  Reports where Grade>80";
            //SqlCommand cmd1 = new SqlCommand(str, cnn);
            cnn.Open();

            //将取到的值赋值给变量
            //double disGPA = Convert.ToDouble(cmd.ExecuteScalar());
            //float DisGPA = (float)disGPA;

            //int a = Convert.Toint32(cmd.ExecuteScalar());

        }
        private int get_db1(string as_where)
        {
            //string str = @"Select IsPost from Reports where Sno='" + dataGView.CurrentRow.Cells[3].Value.ToString() + "' and Cno ='" + dataGView.CurrentRow.Cells[4].Value.ToString() + "'";

            string ls_sql = "select distinct Cno as 课程号 ,DisGPA as 人数 ,Grade as 分数段 from DisGPA" + as_where;
            DataSet ds = new DataSet();
            try
            {
                ds = db.Execute(ls_sql);
            }
            catch
            {
                //数据库出错，相应的sql为getsql()
                MessageBox.Show("error of connect database");
            }
            dataGView.DataSource = ds.Tables[0].DefaultView;

            dataGView.Columns[0].HeaderText = "课程号";
            dataGView.Columns[1].HeaderText = "人数";
            dataGView.Columns[2].HeaderText = "分数段";

            dataGView.Columns[0].Width = 100;
            dataGView.Columns[1].Width = 100;
            dataGView.Columns[2].Width = 100;

            //dataGView.Columns[6].Visible = false;

            return ds.Tables[0].Rows.Count;

        }

        private void txtCno_TextChanged(object sender, EventArgs e)
        {
            string ls_where = "";
            if (this.Text.Equals(""))
            {
                ls_where = "";
            }
            else
            {
                // where Students.DeptNo = Depts.DeptNo"
                ls_where = " where (Cno like '%" + txtCno.Text.ToString() + "%')";
                //ls_where = " where (time like '%" + textBox1.Text.ToString() + "%') or (xm2 like '%" + textBox1.Text.ToString() + "%') or (xm3 like '%" + textBox1.Text.ToString() + "%')";
            }
            get_db1(ls_where);
        }

    }
}
