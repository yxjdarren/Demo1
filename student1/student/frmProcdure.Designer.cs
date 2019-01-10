namespace student
{
    partial class frmProcdure
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
            this.laT = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.txtSno = new System.Windows.Forms.TextBox();
            this.dataGView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).BeginInit();
            this.SuspendLayout();
            // 
            // laT
            // 
            this.laT.AutoSize = true;
            this.laT.Location = new System.Drawing.Point(150, 81);
            this.laT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laT.Name = "laT";
            this.laT.Size = new System.Drawing.Size(44, 18);
            this.laT.TabIndex = 0;
            this.laT.Text = "学号";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnDelete.Location = new System.Drawing.Point(153, 405);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 34);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "查询";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cancel.ForeColor = System.Drawing.Color.OrangeRed;
            this.Cancel.Location = new System.Drawing.Point(409, 405);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(112, 34);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "退出";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // txtSno
            // 
            this.txtSno.Location = new System.Drawing.Point(302, 70);
            this.txtSno.Name = "txtSno";
            this.txtSno.Size = new System.Drawing.Size(162, 28);
            this.txtSno.TabIndex = 6;
            // 
            // dataGView
            // 
            this.dataGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGView.Location = new System.Drawing.Point(63, 120);
            this.dataGView.Name = "dataGView";
            this.dataGView.RowTemplate.Height = 30;
            this.dataGView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGView.Size = new System.Drawing.Size(592, 253);
            this.dataGView.TabIndex = 7;
            // 
            // frmProcdure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(726, 573);
            this.Controls.Add(this.dataGView);
            this.Controls.Add(this.txtSno);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.laT);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProcdure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "调用存储过程窗口";
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laT;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox txtSno;
        private System.Windows.Forms.DataGridView dataGView;
    }
}