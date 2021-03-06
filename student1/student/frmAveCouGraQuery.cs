﻿using System;
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
    public partial class frmAveCouGraQuery : Form
    {
        sqlConnect con = new sqlConnect();
        public frmAveCouGraQuery()
        {
            InitializeComponent();
            calculate();
            get_db1("");
        }
        private void calculate()
        {
            SqlConnection cnn = new SqlConnection("Data Source=(local);database=student_Mis;uid=sa;password=123456;");
            string sql1 = "delete from aveGPA";
            con.OperateData(sql1);
            string str = "insert into aveGPA(Cno,aveGPA) Select Cno,avg(GPA) from GPA group by Cno";
            con.OperateData(str);
            cnn.Open();


            //int a = Convert.Toint32(cmd.ExecuteScalar());

        }
        private int get_db1(string as_where)
        {
            //string str = @"Select IsPost from Reports where Sno='" + dataGView.CurrentRow.Cells[3].Value.ToString() + "' and Cno ='" + dataGView.CurrentRow.Cells[4].Value.ToString() + "'";

            string ls_sql = "select distinct Cno as 课程号 ,aveGPA as 平均绩点 from aveGPA" + as_where;
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
            dataGView.Columns[1].HeaderText = "平均绩点";

            dataGView.Columns[0].Width = 100;
            dataGView.Columns[1].Width = 100;

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

        private void txtCreditHour_TextChanged(object sender, EventArgs e)
        {
            string ls_where = "";
            if (this.Text.Equals(""))
            {
                ls_where = "";
            }
            else
            {
                // where Students.DeptNo = Depts.DeptNo"
                ls_where = " where (aveGPA like '%" + txtCreditHour.Text.ToString() + "%')";
                //ls_where = " where (time like '%" + textBox1.Text.ToString() + "%') or (xm2 like '%" + textBox1.Text.ToString() + "%') or (xm3 like '%" + textBox1.Text.ToString() + "%')";
            }
            get_db1(ls_where);

        }

    }
}
