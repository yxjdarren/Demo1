using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace student
{
    public partial class frmCouQuery : Form
    {
        public frmCouQuery()
        {
            InitializeComponent();
            get_db1("");
        }
        private int get_db1(string as_where)
        {
            //string str = @"Select IsPost from Reports where Sno='" + dataGView.CurrentRow.Cells[3].Value.ToString() + "' and Cno ='" + dataGView.CurrentRow.Cells[4].Value.ToString() + "'";

            string ls_sql = "select Cno as 课程号 ,Cname as 课程名称 ,CreditHour as 学分 ,Ctime as 开课时间 from Courses" + as_where;
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
            dataGView.Columns[1].HeaderText = "课程名称";
            dataGView.Columns[2].HeaderText = "学分";
            dataGView.Columns[3].HeaderText = "开课时间";

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

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            string ls_where = "";
            if (this.Text.Equals(""))
            {
                ls_where = "";
            }
            else
            {
                // where Students.DeptNo = Depts.DeptNo"
                ls_where = " where (Cname like '%" + txtName.Text.ToString() + "%')";
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
                ls_where = " where (CreditHour like '%" + txtCreditHour.Text.ToString() + "%')";
                //ls_where = " where (time like '%" + textBox1.Text.ToString() + "%') or (xm2 like '%" + textBox1.Text.ToString() + "%') or (xm3 like '%" + textBox1.Text.ToString() + "%')";
            }
            get_db1(ls_where);

        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {
            string ls_where = "";
            if (this.Text.Equals(""))
            {
                ls_where = "";
            }
            else
            {
                // where Students.DeptNo = Depts.DeptNo"
                ls_where = " where (Ctime like '%" + txtTime.Text.ToString() + "%')";
                //ls_where = " where (time like '%" + textBox1.Text.ToString() + "%') or (xm2 like '%" + textBox1.Text.ToString() + "%') or (xm3 like '%" + textBox1.Text.ToString() + "%')";
            }
            get_db1(ls_where);

        }

    }
}
