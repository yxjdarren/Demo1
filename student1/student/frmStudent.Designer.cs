﻿namespace student
{
    partial class frmStudent
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
            this.txtClass = new System.Windows.Forms.TextBox();
            this.laClass = new System.Windows.Forms.Label();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.laSex = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.laDept = new System.Windows.Forms.Label();
            this.laName = new System.Windows.Forms.Label();
            this.laSno = new System.Windows.Forms.Label();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSno = new System.Windows.Forms.TextBox();
            this.dataGView = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Gbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).BeginInit();
            this.SuspendLayout();
            // 
            // Gbox
            // 
            this.Gbox.Controls.Add(this.txtClass);
            this.Gbox.Controls.Add(this.laClass);
            this.Gbox.Controls.Add(this.txtSex);
            this.Gbox.Controls.Add(this.laSex);
            this.Gbox.Controls.Add(this.btnInsert);
            this.Gbox.Controls.Add(this.laDept);
            this.Gbox.Controls.Add(this.laName);
            this.Gbox.Controls.Add(this.laSno);
            this.Gbox.Controls.Add(this.cmbDept);
            this.Gbox.Controls.Add(this.txtName);
            this.Gbox.Controls.Add(this.txtSno);
            this.Gbox.Location = new System.Drawing.Point(6, 18);
            this.Gbox.Margin = new System.Windows.Forms.Padding(4);
            this.Gbox.Name = "Gbox";
            this.Gbox.Padding = new System.Windows.Forms.Padding(4);
            this.Gbox.Size = new System.Drawing.Size(998, 150);
            this.Gbox.TabIndex = 0;
            this.Gbox.TabStop = false;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(351, 81);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(163, 28);
            this.txtClass.TabIndex = 11;
            // 
            // laClass
            // 
            this.laClass.AutoSize = true;
            this.laClass.Location = new System.Drawing.Point(267, 86);
            this.laClass.Name = "laClass";
            this.laClass.Size = new System.Drawing.Size(62, 18);
            this.laClass.TabIndex = 10;
            this.laClass.Text = "班级：";
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(603, 36);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(100, 28);
            this.txtSex.TabIndex = 9;
            // 
            // laSex
            // 
            this.laSex.AutoSize = true;
            this.laSex.Location = new System.Drawing.Point(547, 40);
            this.laSex.Name = "laSex";
            this.laSex.Size = new System.Drawing.Size(62, 18);
            this.laSex.TabIndex = 8;
            this.laSex.Text = "性别：";
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnInsert.ForeColor = System.Drawing.Color.Black;
            this.btnInsert.Location = new System.Drawing.Point(603, 73);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(87, 34);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "插入";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // laDept
            // 
            this.laDept.AutoSize = true;
            this.laDept.Location = new System.Drawing.Point(9, 86);
            this.laDept.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laDept.Name = "laDept";
            this.laDept.Size = new System.Drawing.Size(62, 18);
            this.laDept.TabIndex = 5;
            this.laDept.Text = "学院：";
            this.laDept.Click += new System.EventHandler(this.label3_Click);
            // 
            // laName
            // 
            this.laName.AutoSize = true;
            this.laName.Location = new System.Drawing.Point(267, 40);
            this.laName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laName.Name = "laName";
            this.laName.Size = new System.Drawing.Size(62, 18);
            this.laName.TabIndex = 4;
            this.laName.Text = "姓名：";
            // 
            // laSno
            // 
            this.laSno.AutoSize = true;
            this.laSno.Location = new System.Drawing.Point(9, 32);
            this.laSno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laSno.Name = "laSno";
            this.laSno.Size = new System.Drawing.Size(62, 18);
            this.laSno.TabIndex = 3;
            this.laSno.Text = "学号：";
            // 
            // cmbDept
            // 
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Location = new System.Drawing.Point(79, 78);
            this.cmbDept.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(158, 26);
            this.cmbDept.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(351, 36);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(162, 28);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtSno
            // 
            this.txtSno.Location = new System.Drawing.Point(79, 36);
            this.txtSno.Margin = new System.Windows.Forms.Padding(4);
            this.txtSno.Name = "txtSno";
            this.txtSno.Size = new System.Drawing.Size(158, 28);
            this.txtSno.TabIndex = 0;
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
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(297, 495);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 34);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cancel.ForeColor = System.Drawing.Color.Black;
            this.Cancel.Location = new System.Drawing.Point(439, 494);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(80, 34);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "退出";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(161, 495);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1017, 573);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGView);
            this.Controls.Add(this.Gbox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生信息输入窗口";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            this.Gbox.ResumeLayout(false);
            this.Gbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gbox;
        private System.Windows.Forms.Label laDept;
        private System.Windows.Forms.Label laName;
        private System.Windows.Forms.Label laSno;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSno;
        private System.Windows.Forms.DataGridView dataGView;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label laSex;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.Label laClass;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Button button1;
    }
}