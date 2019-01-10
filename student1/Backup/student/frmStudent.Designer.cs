namespace student
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.laTime = new System.Windows.Forms.Label();
            this.laDept = new System.Windows.Forms.Label();
            this.laName = new System.Windows.Forms.Label();
            this.laSno = new System.Windows.Forms.Label();
            this.dtTime = new System.Windows.Forms.DateTimePicker();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSno = new System.Windows.Forms.TextBox();
            this.dataGView = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Gbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).BeginInit();
            this.SuspendLayout();
            // 
            // Gbox
            // 
            this.Gbox.Controls.Add(this.btnInsert);
            this.Gbox.Controls.Add(this.laTime);
            this.Gbox.Controls.Add(this.laDept);
            this.Gbox.Controls.Add(this.laName);
            this.Gbox.Controls.Add(this.laSno);
            this.Gbox.Controls.Add(this.dtTime);
            this.Gbox.Controls.Add(this.cmbDept);
            this.Gbox.Controls.Add(this.txtName);
            this.Gbox.Controls.Add(this.txtSno);
            this.Gbox.Location = new System.Drawing.Point(4, 12);
            this.Gbox.Name = "Gbox";
            this.Gbox.Size = new System.Drawing.Size(468, 100);
            this.Gbox.TabIndex = 0;
            this.Gbox.TabStop = false;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnInsert.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnInsert.Location = new System.Drawing.Point(367, 53);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(58, 23);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "插入";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // laTime
            // 
            this.laTime.AutoSize = true;
            this.laTime.Location = new System.Drawing.Point(166, 52);
            this.laTime.Name = "laTime";
            this.laTime.Size = new System.Drawing.Size(53, 12);
            this.laTime.TabIndex = 6;
            this.laTime.Text = "入学时间";
            // 
            // laDept
            // 
            this.laDept.AutoSize = true;
            this.laDept.Location = new System.Drawing.Point(6, 57);
            this.laDept.Name = "laDept";
            this.laDept.Size = new System.Drawing.Size(29, 12);
            this.laDept.TabIndex = 5;
            this.laDept.Text = "系别";
            this.laDept.Click += new System.EventHandler(this.label3_Click);
            // 
            // laName
            // 
            this.laName.AutoSize = true;
            this.laName.Location = new System.Drawing.Point(166, 27);
            this.laName.Name = "laName";
            this.laName.Size = new System.Drawing.Size(53, 12);
            this.laName.TabIndex = 4;
            this.laName.Text = "姓    名";
            // 
            // laSno
            // 
            this.laSno.AutoSize = true;
            this.laSno.Location = new System.Drawing.Point(6, 21);
            this.laSno.Name = "laSno";
            this.laSno.Size = new System.Drawing.Size(29, 12);
            this.laSno.TabIndex = 3;
            this.laSno.Text = "学号";
            // 
            // dtTime
            // 
            this.dtTime.Location = new System.Drawing.Point(234, 52);
            this.dtTime.Name = "dtTime";
            this.dtTime.Size = new System.Drawing.Size(109, 21);
            this.dtTime.TabIndex = 2;
            // 
            // cmbDept
            // 
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Location = new System.Drawing.Point(41, 49);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(107, 20);
            this.cmbDept.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(234, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(109, 21);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtSno
            // 
            this.txtSno.Location = new System.Drawing.Point(41, 24);
            this.txtSno.Name = "txtSno";
            this.txtSno.Size = new System.Drawing.Size(107, 21);
            this.txtSno.TabIndex = 0;
            // 
            // dataGView
            // 
            this.dataGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGView.Location = new System.Drawing.Point(4, 118);
            this.dataGView.Name = "dataGView";
            this.dataGView.RowTemplate.Height = 23;
            this.dataGView.Size = new System.Drawing.Size(468, 206);
            this.dataGView.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnDelete.Location = new System.Drawing.Point(198, 330);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(61, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChange.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnChange.Location = new System.Drawing.Point(287, 330);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(60, 23);
            this.btnChange.TabIndex = 3;
            this.btnChange.Text = "保存";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cancel.ForeColor = System.Drawing.Color.OrangeRed;
            this.Cancel.Location = new System.Drawing.Point(382, 330);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(53, 23);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "退出";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(484, 382);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGView);
            this.Controls.Add(this.Gbox);
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
        private System.Windows.Forms.Label laTime;
        private System.Windows.Forms.Label laDept;
        private System.Windows.Forms.Label laName;
        private System.Windows.Forms.Label laSno;
        private System.Windows.Forms.DateTimePicker dtTime;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSno;
        private System.Windows.Forms.DataGridView dataGView;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button Cancel;
    }
}