namespace student
{
    partial class frmStuQuery
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
            this.laDept = new System.Windows.Forms.Label();
            this.laName = new System.Windows.Forms.Label();
            this.laSno = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSno = new System.Windows.Forms.TextBox();
            this.dataGView = new System.Windows.Forms.DataGridView();
            this.txtDeptNo = new System.Windows.Forms.TextBox();
            this.Gbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).BeginInit();
            this.SuspendLayout();
            // 
            // Gbox
            // 
            this.Gbox.Controls.Add(this.txtDeptNo);
            this.Gbox.Controls.Add(this.txtClass);
            this.Gbox.Controls.Add(this.laClass);
            this.Gbox.Controls.Add(this.txtSex);
            this.Gbox.Controls.Add(this.laSex);
            this.Gbox.Controls.Add(this.laDept);
            this.Gbox.Controls.Add(this.laName);
            this.Gbox.Controls.Add(this.laSno);
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
            this.txtClass.TextChanged += new System.EventHandler(this.txtClass_TextChanged);
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
            this.txtSex.TextChanged += new System.EventHandler(this.txtSex_TextChanged);
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
            // laDept
            // 
            this.laDept.AutoSize = true;
            this.laDept.Location = new System.Drawing.Point(9, 86);
            this.laDept.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laDept.Name = "laDept";
            this.laDept.Size = new System.Drawing.Size(62, 18);
            this.laDept.TabIndex = 5;
            this.laDept.Text = "学院：";
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
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(351, 36);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(162, 28);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtSno
            // 
            this.txtSno.Location = new System.Drawing.Point(79, 36);
            this.txtSno.Margin = new System.Windows.Forms.Padding(4);
            this.txtSno.Name = "txtSno";
            this.txtSno.Size = new System.Drawing.Size(158, 28);
            this.txtSno.TabIndex = 0;
            this.txtSno.TextChanged += new System.EventHandler(this.txtSno_TextChanged);
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
            // txtDeptNo
            // 
            this.txtDeptNo.Location = new System.Drawing.Point(79, 80);
            this.txtDeptNo.Name = "txtDeptNo";
            this.txtDeptNo.Size = new System.Drawing.Size(158, 28);
            this.txtDeptNo.TabIndex = 12;
            this.txtDeptNo.TextChanged += new System.EventHandler(this.txtDeptNo_TextChanged);
            // 
            // frmStuQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1017, 573);
            this.Controls.Add(this.dataGView);
            this.Controls.Add(this.Gbox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStuQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生信息输入窗口";
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
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSno;
        private System.Windows.Forms.DataGridView dataGView;
        private System.Windows.Forms.Label laSex;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.Label laClass;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtDeptNo;
    }
}