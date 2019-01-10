﻿using System;
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
    }
}
