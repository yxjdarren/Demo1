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
            this.btnPost = new System.Windows.Forms.Button();
            this.Gbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).BeginInit();
            this.SuspendLayout();
            // 
            // Gbox
            // 
            this.Gbox.Controls.Add(this.laR);
            this.Gbox.Controls.Add(this.laC);
            this.Gbox.Controls.Add(this.laS);
            this.Gbox.Controls.Add(this.txtgrad);
            this.Gbox.Controls.Add(this.cmbC);
            this.Gbox.Controls.Add(this.cmbS);
            this.Gbox.Location = new System.Drawing.Point(3, 2);
            this.Gbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Gbox.Name = "Gbox";
            this.Gbox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Gbox.Size = new System.Drawing.Size(705, 150);
            this.Gbox.TabIndex = 0;
            this.Gbox.TabStop = false;
            this.Gbox.Enter += new System.EventHandler(this.Gbox_Enter);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnInsert.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnInsert.Location = new System.Drawing.Point(51, 514);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(112, 34);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "插入";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // laR
            // 
            this.laR.AutoSize = true;
            this.laR.Location = new System.Drawing.Point(406, 30);
            this.laR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laR.Name = "laR";
            this.laR.Size = new System.Drawing.Size(62, 18);
            this.laR.TabIndex = 6;
            this.laR.Text = "成绩：";
            // 
            // laC
            // 
            this.laC.AutoSize = true;
            this.laC.Location = new System.Drawing.Point(45, 86);
            this.laC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laC.Name = "laC";
            this.laC.Size = new System.Drawing.Size(62, 18);
            this.laC.TabIndex = 5;
            this.laC.Text = "课程：";
            // 
            // laS
            // 
            this.laS.AutoSize = true;
            this.laS.Location = new System.Drawing.Point(45, 30);
            this.laS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laS.Name = "laS";
            this.laS.Size = new System.Drawing.Size(62, 18);
            this.laS.TabIndex = 4;
            this.laS.Text = "姓名：";
            // 
            // txtgrad
            // 
            this.txtgrad.Location = new System.Drawing.Point(506, 27);
            this.txtgrad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtgrad.Name = "txtgrad";
            this.txtgrad.Size = new System.Drawing.Size(176, 28);
            this.txtgrad.TabIndex = 3;
            // 
            // cmbC
            // 
            this.cmbC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbC.FormattingEnabled = true;
            this.cmbC.Location = new System.Drawing.Point(159, 86);
            this.cmbC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbC.Name = "cmbC";
            this.cmbC.Size = new System.Drawing.Size(172, 26);
            this.cmbC.TabIndex = 2;
            // 
            // cmbS
            // 
            this.cmbS.FormattingEnabled = true;
            this.cmbS.Location = new System.Drawing.Point(159, 26);
            this.cmbS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbS.Name = "cmbS";
            this.cmbS.Size = new System.Drawing.Size(172, 26);
            this.cmbS.TabIndex = 1;
            // 
            // dataGView
            // 
            this.dataGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGView.Location = new System.Drawing.Point(3, 195);
            this.dataGView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGView.Name = "dataGView";
            this.dataGView.RowTemplate.Height = 23;
            this.dataGView.Size = new System.Drawing.Size(705, 264);
            this.dataGView.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnDelete.Location = new System.Drawing.Point(188, 514);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 34);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChange.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnChange.Location = new System.Drawing.Point(326, 514);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(112, 34);
            this.btnChange.TabIndex = 3;
            this.btnChange.Text = "修改";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click_1);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cancel.ForeColor = System.Drawing.Color.OrangeRed;
            this.Cancel.Location = new System.Drawing.Point(596, 514);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(112, 34);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "退出";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // btnPost
            // 
            this.btnPost.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold);
            this.btnPost.Location = new System.Drawing.Point(458, 514);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(112, 34);
            this.btnPost.TabIndex = 8;
            this.btnPost.Text = "发布";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(726, 573);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGView);
            this.Controls.Add(this.Gbox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button btnPost;
    }
}