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
    public partial class frmProcdure : Form
    {

        sqlConnect con = new sqlConnect();
        public frmProcdure()
        {
            string sql = "delete from execStu";
            con.OperateData(sql);
            InitializeComponent();
            get_db1("");
        }
        private int get_db1(string as_where)
        {
            //string str = @"Select IsPost from Reports where Sno='" + dataGView.CurrentRow.Cells[3].Value.ToString() + "' and Cno ='" + dataGView.CurrentRow.Cells[4].Value.ToString() + "'";

            string ls_sql = "select Cno as 课程号 ,Cname as 课程名 ,Grade as 成绩 from execStu";
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
            dataGView.Columns[1].HeaderText = "课程名";
            dataGView.Columns[2].HeaderText = "成绩";


            dataGView.Columns[0].Width = 100;
            dataGView.Columns[1].Width = 100;
            dataGView.Columns[1].Width = 100;


            //dataGView.Columns[6].Visible = false;

            return ds.Tables[0].Rows.Count;

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "insert into execStu(Cno,Cname,Grade) exec StuQuery'" + txtSno.Text.ToString() + "'";
                con.OperateData(sql);
                get_db1("");
                //sqlConnect conn = new sqlConnect();
                //int i=conn.OperateData(sql);
                //if (i>0)
                //    MessageBox.Show("已删除相关记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //else
                //    MessageBox.Show("没有可删除相关记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   }
}
