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
    public partial class frmReport : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind()
        {
            try
            {
                sql = "select Sname as 姓名 ,Cname as 课程名称名 ,Grade as 成绩 ,Students.Sno,Courses.Cno from Students,Courses,Reports where Students.Sno = Reports.Sno and Reports.Cno = Courses.Cno";
                con.BindDataGridView(dataGView,sql);
                dataGView.Columns[0].ReadOnly = true;
                dataGView.Columns[1].ReadOnly = true;
                dataGView.Columns[3].Visible = false;
                dataGView.Columns[4].Visible = false;
                dataGView.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        protected void CmbSBind()
        {
            try
            {
                cmbS.DropDownStyle = ComboBoxStyle.DropDownList;
                ds = con.Getds("select Sno,Sname from Students");
                cmbS.DisplayMember = "Sname";
                cmbS.ValueMember = "Sno";
                cmbS.DataSource = ds.Tables[0];
            }
            catch (Exception)
            {

                MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        protected void CmbCBind()
        {
            try
            {
                cmbC.DropDownStyle = ComboBoxStyle.DropDownList;
                ds = con.Getds("select Cno,Cname from Courses");
                cmbC.DisplayMember = "Cname";
                cmbC.ValueMember = "Cno";
                cmbC.DataSource = ds.Tables[0];
            }
            catch
            {

                MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }



        public frmReport()
        {
            InitializeComponent();
            SetBind();
            CmbSBind();
            CmbCBind();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
             {
                sql = "insert into Reports values( '" + cmbS.SelectedValue.ToString() + "','" + cmbC.SelectedValue.ToString() + "','" + txtgrad.Text + "')";
                con.OperateData(sql);
                SetBind();
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

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除该条信息吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    sql = "delete from Reports where Sno='" + dataGView.CurrentRow.Cells[3].Value.ToString() + "'and Cno ='" + dataGView.CurrentRow.Cells[4].Value.ToString() + "'";
                    con.OperateData(sql);
                    SetBind();
                    MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btnChange_Click_1(object sender, EventArgs e)
        {
            try
            {
                sql = "update Reports set Grade ='" + dataGView.CurrentRow.Cells[2].Value.ToString() + "' where Sno = '" + dataGView.CurrentRow.Cells[3].Value.ToString() + "' and Cno = '" + dataGView.CurrentRow.Cells[4].Value.ToString() + "'";
                con.OperateData(sql);
                SetBind();
            }
            catch
            {
                MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Gbox_Enter(object sender, EventArgs e)
        {

        }
    }
}
