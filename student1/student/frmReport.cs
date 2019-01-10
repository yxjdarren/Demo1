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
                ds = con.Getds("select distinct Sno,Sname from Manage");
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
                ds = con.Getds("select distinct Cno,Cname from Manage");
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
                sql = "insert into Reports values( '" + cmbS.SelectedValue.ToString() + "','" + cmbC.SelectedValue.ToString() + "','" + txtgrad.Text + "','" + "0" + "')";
                con.OperateData(sql);
                string GPA = "0";
                if (float.Parse(txtgrad.Text) >= 90)
                {
                    GPA = "4.0";
                }
                if (float.Parse(txtgrad.Text) >= 85 && float.Parse(txtgrad.Text) < 90)
                {
                    GPA = "3.5";
                }
                if (float.Parse(txtgrad.Text) >= 80 && float.Parse(txtgrad.Text) < 85)
                {
                    GPA = "3.0";
                }
                if (float.Parse(txtgrad.Text) >= 75 && float.Parse(txtgrad.Text) < 80)
                {
                    GPA = "2.5";
                }
                if (float.Parse(txtgrad.Text) >= 70 && float.Parse(txtgrad.Text) < 75)
                {
                    GPA = "2.0";
                }
                if (float.Parse(txtgrad.Text) >= 65 && float.Parse(txtgrad.Text) < 70)
                {
                    GPA = "1.5";
                }
                if (float.Parse(txtgrad.Text) >= 60 && float.Parse(txtgrad.Text) < 65)
                {
                    GPA = "1.5";
                }
                if (float.Parse(txtgrad.Text) >= 0 && float.Parse(txtgrad.Text) < 60)
                {
                    GPA = "1.0";
                }
                sql = "insert into GPA values( '" + cmbS.SelectedValue.ToString() + "','" + cmbC.SelectedValue.ToString() + "'," + float.Parse(GPA) + ",'" + "0" + "')";
                con.OperateData(sql);
                SetBind();
              }
            catch
              {
                  MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
            
        }
        private void calculate()
        {
            SqlConnection cnn = new SqlConnection("Data Source=(local);database=student_Mis;uid=sa;password=123456;");
            string str = @"Select avg(GPA) from GPA group by Cno";
            //string avgGPA = "0";
            SqlCommand cmd = new SqlCommand(str, cnn);
            cnn.Open();

            //将取到的值赋值给变量
            double avgGPA = Convert.ToDouble(cmd.ExecuteScalar());
            float AvgGPA = (float)avgGPA;

            //int a = Convert.Toint32(cmd.ExecuteScalar());

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
                    string sql1 = "delete from GPA where Sno='" + dataGView.CurrentRow.Cells[3].Value.ToString() + "'and Cno ='" + dataGView.CurrentRow.Cells[4].Value.ToString() + "'";
                    con.OperateData(sql1);
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
                    SqlConnection cnn = new SqlConnection("Data Source=(local);database=student_Mis;uid=sa;password=123456;");
                    string str = @"Select IsPost from Reports where Sno='" + dataGView.CurrentRow.Cells[3].Value.ToString() + "' and Cno ='" + dataGView.CurrentRow.Cells[4].Value.ToString() + "'";
                    string Istrue = "1";
                    SqlCommand cmd = new SqlCommand(str, cnn);
                    //con.OperateData("Select Sname from Students");
                    cnn.Open();
                    //SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    //string Sname = dr["Sname"].ToString();
                    string IsPost = "2";
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        IsPost = dr["IsPost"].ToString();
                    }
                    if (IsPost == "0")
                    {
                        sql = "update Reports set Grade =" + float.Parse(txtgrad.Text) + " where Sno = '" + dataGView.CurrentRow.Cells[3].Value.ToString() + "' and Cno = '" + dataGView.CurrentRow.Cells[4].Value.ToString() + "'";
                        con.OperateData(sql);
                        string GPA = "0";
                        if (float.Parse(txtgrad.Text) >= 90)
                        {
                            GPA = "4.0";
                        }
                        if (float.Parse(txtgrad.Text) >= 85 && float.Parse(txtgrad.Text) < 90)
                        {
                            GPA = "3.5";
                        }
                        if (float.Parse(txtgrad.Text) >= 80 && float.Parse(txtgrad.Text) < 85)
                        {
                            GPA = "3.0";
                        }
                        if (float.Parse(txtgrad.Text) >= 75 && float.Parse(txtgrad.Text) < 80)
                        {
                            GPA = "2.5";
                        }
                        if (float.Parse(txtgrad.Text) >= 70 && float.Parse(txtgrad.Text) < 75)
                        {
                            GPA = "2.0";
                        }
                        if (float.Parse(txtgrad.Text) >= 65 && float.Parse(txtgrad.Text) < 70)
                        {
                            GPA = "1.5";
                        }
                        if (float.Parse(txtgrad.Text) >= 60 && float.Parse(txtgrad.Text) < 65)
                        {
                            GPA = "1.5";
                        }
                        if (float.Parse(txtgrad.Text) >= 0 && float.Parse(txtgrad.Text) < 60)
                        {
                            GPA = "1.0";
                        }
                        string sql1 = "update GPA set GPA =" + float.Parse(GPA) + " where Sno = '" + dataGView.CurrentRow.Cells[3].Value.ToString() + "' and Cno = '" + dataGView.CurrentRow.Cells[4].Value.ToString() + "'";
                        con.OperateData(sql1);
                        SetBind();
                    }
                    if (IsPost == "1")
                    {
                        MessageBox.Show("已发布，不可修改！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

        }

        private void Gbox_Enter(object sender, EventArgs e)
        {

        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Data Source=(local);database=student_Mis;uid=sa;password=123456;");
            string str = @"Select IsPost from Reports where Sno='" + dataGView.CurrentRow.Cells[3].Value.ToString() + "' and Cno ='" + dataGView.CurrentRow.Cells[4].Value.ToString() + "'";
            string Istrue = "1";
            SqlCommand cmd = new SqlCommand(str, cnn);
            //con.OperateData("Select Sname from Students");
            cnn.Open();
            //SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            //string Sname = dr["Sname"].ToString();
            string IsPost = "2";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                IsPost = dr["IsPost"].ToString();
            }
            if (IsPost == "0")
            {
                sql = "update Reports set IsPost ='" + Istrue + "' where Sno = '" + dataGView.CurrentRow.Cells[3].Value.ToString() + "' and Cno = '" + dataGView.CurrentRow.Cells[4].Value.ToString() + "'";
                con.OperateData(sql);
                sql = "update GPA set IsPost ='" + Istrue + "' where Sno = '" + dataGView.CurrentRow.Cells[3].Value.ToString() + "' and Cno = '" + dataGView.CurrentRow.Cells[4].Value.ToString() + "'";
                con.OperateData(sql);
                MessageBox.Show("成功发布！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (IsPost == "1")
            {
                MessageBox.Show("已发布！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
