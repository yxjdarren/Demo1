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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 学生表输入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudent fStudent = new frmStudent();
            fStudent.Show();

        }

        private void 课程表输入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCourse fCourse = new frmCourse();
            fCourse.Show();
        }

        private void 系别表输入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDept fDept = new frmDept();
            fDept.Show();
        }

        private void 成绩表输入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport fReport = new frmReport();
            fReport.Show();
        }

        private void 主细表演示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetail fDetail = new frmDetail();
            fDetail.Show();
        }

        private void 调用存储过程演示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProcdure fProcdure = new frmProcdure();
            fProcdure.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form o = new frmAdd();

            o.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

            Form p = new frmModi();

            p.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Form q = new frmdel();

            q.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void 每学期开设课程及学生选课管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManage fManage = new frmManage();
            fManage.Show();
        }

        private void 学生基本信息的查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStuQuery fStuQuery = new frmStuQuery();
            fStuQuery.Show();
        }

        private void 课程基本信息的查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCouQuery fCouQuery = new frmCouQuery();
            fCouQuery.Show();
        }

        private void 查询学生的选课情况成绩绩点平均绩点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCouGraQuery fCouGraQuery = new frmCouGraQuery();
            fCouGraQuery.Show();
        }

        private void 查询平均绩点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAveCouGraQuery fAveCouGraQuery = new frmAveCouGraQuery();
            fAveCouGraQuery.Show();
        }

        private void 成绩单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmList fList = new frmList();
            fList.Show();
        }

        private void 成绩分布情况ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDistribution fDistribution = new frmDistribution();
            fDistribution.Show();
        }

        private void 班级统计学生成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCDistribution fCDistribution = new frmCDistribution();
            fCDistribution.Show();
        }
    }
}
