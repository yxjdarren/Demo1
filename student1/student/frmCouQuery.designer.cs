﻿namespace student
{
    partial class frmCouQuery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Gbox = new System.Windows.Forms.GroupBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtCreditHour = new System.Windows.Forms.TextBox();
            this.laCre = new System.Windows.Forms.Label();
            this.laTime = new System.Windows.Forms.Label();
            this.laName = new System.Windows.Forms.Label();
            this.laCno = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCno = new System.Windows.Forms.TextBox();
            this.dataGView = new System.Windows.Forms.DataGridView();
            this.Gbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).BeginInit();
            this.SuspendLayout();
            // 
            // Gbox
            // 
            this.Gbox.Controls.Add(this.txtTime);
            this.Gbox.Controls.Add(this.txtCreditHour);
            this.Gbox.Controls.Add(this.laCre);
            this.Gbox.Controls.Add(this.laTime);
            this.Gbox.Controls.Add(this.laName);
            this.Gbox.Controls.Add(this.laCno);
            this.Gbox.Controls.Add(this.txtName);
            this.Gbox.Controls.Add(this.txtCno);
            this.Gbox.Location = new System.Drawing.Point(6, 18);
            this.Gbox.Margin = new System.Windows.Forms.Padding(4);
            this.Gbox.Name = "Gbox";
            this.Gbox.Padding = new System.Windows.Forms.Padding(4);
            this.Gbox.Size = new System.Drawing.Size(998, 150);
            this.Gbox.TabIndex = 0;
            this.Gbox.TabStop = false;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(96, 81);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(158, 28);
            this.txtTime.TabIndex = 12;
            this.txtTime.TextChanged += new System.EventHandler(this.txtTime_TextChanged);
            // 
            // txtCreditHour
            // 
            this.txtCreditHour.Location = new System.Drawing.Point(603, 36);
            this.txtCreditHour.Name = "txtCreditHour";
            this.txtCreditHour.Size = new System.Drawing.Size(100, 28);
            this.txtCreditHour.TabIndex = 9;
            this.txtCreditHour.TextChanged += new System.EventHandler(this.txtCreditHour_TextChanged);
            // 
            // laCre
            // 
            this.laCre.AutoSize = true;
            this.laCre.Location = new System.Drawing.Point(547, 40);
            this.laCre.Name = "laCre";
            this.laCre.Size = new System.Drawing.Size(44, 18);
            this.laCre.TabIndex = 8;
            this.laCre.Text = "学分";
            // 
            // laTime
            // 
            this.laTime.AutoSize = true;
            this.laTime.Location = new System.Drawing.Point(9, 86);
            this.laTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laTime.Name = "laTime";
            this.laTime.Size = new System.Drawing.Size(80, 18);
            this.laTime.TabIndex = 5;
            this.laTime.Text = "开课时间";
            // 
            // laName
            // 
            this.laName.AutoSize = true;
            this.laName.Location = new System.Drawing.Point(267, 40);
            this.laName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laName.Name = "laName";
            this.laName.Size = new System.Drawing.Size(80, 18);
            this.laName.TabIndex = 4;
            this.laName.Text = "课程名称";
            // 
            // laCno
            // 
            this.laCno.AutoSize = true;
            this.laCno.Location = new System.Drawing.Point(9, 36);
            this.laCno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laCno.Name = "laCno";
            this.laCno.Size = new System.Drawing.Size(62, 18);
            this.laCno.TabIndex = 3;
            this.laCno.Text = "课程号";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(351, 36);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(162, 28);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtCno
            // 
            this.txtCno.Location = new System.Drawing.Point(96, 32);
            this.txtCno.Margin = new System.Windows.Forms.Padding(4);
            this.txtCno.Name = "txtCno";
            this.txtCno.Size = new System.Drawing.Size(158, 28);
            this.txtCno.TabIndex = 0;
            this.txtCno.TextChanged += new System.EventHandler(this.txtCno_TextChanged);
            // 
            // dataGView
            // 
            this.dataGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGView.Location = new System.Drawing.Point(6, 177);
            this.dataGView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGView.Name = "dataGView";
            this.dataGView.RowTemplate.Height = 23;
            this.dataGView.Size = new System.Drawing.Size(998, 309);
            this.dataGView.TabIndex = 1;
            // 
            // frmCouQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1017, 573);
            this.Controls.Add(this.dataGView);
            this.Controls.Add(this.Gbox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCouQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生信息输入窗口";
            this.Gbox.ResumeLayout(false);
            this.Gbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gbox;
        private System.Windows.Forms.Label laTime;
        private System.Windows.Forms.Label laName;
        private System.Windows.Forms.Label laCno;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCno;
        private System.Windows.Forms.DataGridView dataGView;
        private System.Windows.Forms.Label laCre;
        private System.Windows.Forms.TextBox txtCreditHour;
        private System.Windows.Forms.TextBox txtTime;
    }
}