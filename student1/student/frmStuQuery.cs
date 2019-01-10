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
    public partial class frmStuQuery : Form
    {
        public frmStuQuery()
        {
            InitializeComponent();
            get_db1("");
        }
        private int get_db1(string as_where)
        {
            //string str = @"Select IsPost from Reports where Sno='" + dataGView.CurrentRow.Cells[3].Value.ToString() + "' and Cno ='" + dataGView.CurrentRow.Cells[4].Value.ToString() + "'";

            string ls_sql = "select Sno as 学号,Sname as 姓名,deptName as 系名, Sex as 性别, Class as 班级, CreditHours as 学分 from Students,Depts where Students.DeptNo = Depts.DeptNo" + as_where;
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

            dataGView.Columns[0].HeaderText = "学号";
            dataGView.Columns[1].HeaderText = "姓名";
            dataGView.Columns[2].HeaderText = "系名";
            dataGView.Columns[3].HeaderText = "性别";
            dataGView.Columns[4].HeaderText = "班级";
            dataGView.Columns[5].HeaderText = "学分";

            dataGView.Columns[0].Width = 100;
            dataGView.Columns[1].Width = 100;
            dataGView.Columns[2].Width = 100;
            dataGView.Columns[3].Width = 100;
            dataGView.Columns[4].Width = 100;
            dataGView.Columns[4].Width = 100;

            //dataGView.Columns[6].Visible = false;

            return ds.Tables[0].Rows.Count;

        }

        private void txtSno_TextChanged(object sender, EventArgs e)
        {
            string ls_where = "";
            if (this.Text.Equals(""))
            {
                ls_where = "";
            }
            else
            {
                // where Students.DeptNo = Depts.DeptNo"
                ls_where = " and (Sno like '%" + txtSno.Text.ToString() + "%')";
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
                ls_where = " and (Sname like '%" + txtName.Text.ToString() + "%')";
                //ls_where = " where (time like '%" + textBox1.Text.ToString() + "%') or (xm2 like '%" + textBox1.Text.ToString() + "%') or (xm3 like '%" + textBox1.Text.ToString() + "%')";
            }
            get_db1(ls_where);

        }

        private void txtSex_TextChanged(object sender, EventArgs e)
        {
            string ls_where = "";
            if (this.Text.Equals(""))
            {
                ls_where = "";
            }
            else
            {
                // where Students.DeptNo = Depts.DeptNo"
                ls_where = " and (Sex like '%" + txtSex.Text.ToString() + "%')";
                //ls_where = " where (time like '%" + textBox1.Text.ToString() + "%') or (xm2 like '%" + textBox1.Text.ToString() + "%') or (xm3 like '%" + textBox1.Text.ToString() + "%')";
            }
            get_db1(ls_where);
        }

        private void txtDeptNo_TextChanged(object sender, EventArgs e)
        {
            string ls_where = "";
            if (this.Text.Equals(""))
            {
                ls_where = "";
            }
            else
            {
                // where Students.DeptNo = Depts.DeptNo"
                ls_where = " and (DeptName like '%" + txtDeptNo.Text.ToString() + "%')";
                //ls_where = " where (time like '%" + textBox1.Text.ToString() + "%') or (xm2 like '%" + textBox1.Text.ToString() + "%') or (xm3 like '%" + textBox1.Text.ToString() + "%')";
            }
            get_db1(ls_where);
        }

        private void txtClass_TextChanged(object sender, EventArgs e)
        {
            string ls_where = "";
            if (this.Text.Equals(""))
            {
                ls_where = "";
            }
            else
            {
                // where Students.DeptNo = Depts.DeptNo"
                ls_where = " and (Class like '%" + txtClass.Text.ToString() + "%')";
                //ls_where = " where (time like '%" + textBox1.Text.ToString() + "%') or (xm2 like '%" + textBox1.Text.ToString() + "%') or (xm3 like '%" + textBox1.Text.ToString() + "%')";
            }
            get_db1(ls_where);

        }

    }
}
