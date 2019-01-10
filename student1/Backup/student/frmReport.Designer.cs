namespace student
{
    partial class frmReport
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
            this.laR = new System.Windows.Forms.Label();
            this.laC = new System.Windows.Forms.Label();
            this.laS = new System.Windows.Forms.Label();
            this.txtgrad = new System.Windows.Forms.TextBox();
            this.cmbC = new System.Windows.Forms.ComboBox();
            this.cmbS = new System.Windows.Forms.ComboBox();
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
            this.Gbox.Controls.Add(this.laR);
            this.Gbox.Controls.Add(this.laC);
            this.Gbox.Controls.Add(this.laS);
            this.Gbox.Controls.Add(this.txtgrad);
            this.Gbox.Controls.Add(this.cmbC);
            this.Gbox.Controls.Add(this.cmbS);
            this.Gbox.Location = new System.Drawing.Point(2, 1);
            this.Gbox.Name = "Gbox";
            this.Gbox.Size = new System.Drawing.Size(470, 100);
            this.Gbox.TabIndex = 0;
            this.Gbox.TabStop = false;
            this.Gbox.Enter += new System.EventHandler(this.Gbox_Enter);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnInsert.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnInsert.Location = new System.Drawing.Point(381, 60);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "插入";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // laR
            // 
            this.laR.AutoSize = true;
            this.laR.Location = new System.Drawing.Point(271, 20);
            this.laR.Name = "laR";
            this.laR.Size = new System.Drawing.Size(41, 12);
            this.laR.TabIndex = 6;
            this.laR.Text = "成绩：";
            // 
            // laC
            // 
            this.laC.AutoSize = true;
            this.laC.Location = new System.Drawing.Point(30, 57);
            this.laC.Name = "laC";
            this.laC.Size = new System.Drawing.Size(41, 12);
            this.laC.TabIndex = 5;
            this.laC.Text = "课程：";
            // 
            // laS
            // 
            this.laS.AutoSize = true;
            this.laS.Location = new System.Drawing.Point(30, 20);
            this.laS.Name = "laS";
            this.laS.Size = new System.Drawing.Size(41, 12);
            this.laS.TabIndex = 4;
            this.laS.Text = "姓名：";
            // 
            // txtgrad
            // 
            this.txtgrad.Location = new System.Drawing.Point(337, 18);
            this.txtgrad.Name = "txtgrad";
            this.txtgrad.Size = new System.Drawing.Size(119, 21);
            this.txtgrad.TabIndex = 3;
            // 
            // cmbC
            // 
            this.cmbC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbC.FormattingEnabled = true;
            this.cmbC.Location = new System.Drawing.Point(106, 57);
            this.cmbC.Name = "cmbC";
            this.cmbC.Size = new System.Drawing.Size(116, 20);
            this.cmbC.TabIndex = 2;
            // 
            // cmbS
            // 
            this.cmbS.FormattingEnabled = true;
            this.cmbS.Location = new System.Drawing.Point(106, 17);
            this.cmbS.Name = "cmbS";
            this.cmbS.Size = new System.Drawing.Size(116, 20);
            this.cmbS.TabIndex = 1;
            // 
            // dataGView
            // 
            this.dataGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGView.Location = new System.Drawing.Point(2, 130);
            this.dataGView.Name = "dataGView";
            this.dataGView.RowTemplate.Height = 23;
            this.dataGView.Size = new System.Drawing.Size(470, 176);
            this.dataGView.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnDelete.Location = new System.Drawing.Point(173, 343);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChange.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnChange.Location = new System.Drawing.Point(275, 343);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 3;
            this.btnChange.Text = "保存";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click_1);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cancel.ForeColor = System.Drawing.Color.OrangeRed;
            this.Cancel.Location = new System.Drawing.Point(383, 343);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "退出";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // frmReport
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
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "成绩信息输入窗口";
            this.Gbox.ResumeLayout(false);
            this.Gbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gbox;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label laR;
        private System.Windows.Forms.Label laC;
        private System.Windows.Forms.Label laS;
        private System.Windows.Forms.TextBox txtgrad;
        private System.Windows.Forms.ComboBox cmbC;
        private System.Windows.Forms.ComboBox cmbS;
        private System.Windows.Forms.DataGridView dataGView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button Cancel;
    }
}