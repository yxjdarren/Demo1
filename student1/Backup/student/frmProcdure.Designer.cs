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
            this.laCredit = new System.Windows.Forms.Label();
            this.datT = new System.Windows.Forms.DateTimePicker();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // laT
            // 
            this.laT.AutoSize = true;
            this.laT.Location = new System.Drawing.Point(100, 54);
            this.laT.Name = "laT";
            this.laT.Size = new System.Drawing.Size(65, 12);
            this.laT.TabIndex = 0;
            this.laT.Text = "日    期：";
            // 
            // laCredit
            // 
            this.laCredit.AutoSize = true;
            this.laCredit.Location = new System.Drawing.Point(100, 101);
            this.laCredit.Name = "laCredit";
            this.laCredit.Size = new System.Drawing.Size(65, 12);
            this.laCredit.TabIndex = 1;
            this.laCredit.Text = "最小学分：";
            // 
            // datT
            // 
            this.datT.Location = new System.Drawing.Point(201, 48);
            this.datT.Name = "datT";
            this.datT.Size = new System.Drawing.Size(109, 21);
            this.datT.TabIndex = 2;
            // 
            // txtCredit
            // 
            this.txtCredit.Location = new System.Drawing.Point(201, 92);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(109, 21);
            this.txtCredit.TabIndex = 3;
            this.txtCredit.Text = "0";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnDelete.Location = new System.Drawing.Point(102, 164);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cancel.ForeColor = System.Drawing.Color.OrangeRed;
            this.Cancel.Location = new System.Drawing.Point(235, 164);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "退出";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // frmProcdure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(484, 382);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtCredit);
            this.Controls.Add(this.datT);
            this.Controls.Add(this.laCredit);
            this.Controls.Add(this.laT);
            this.Name = "frmProcdure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "调用存储过程窗口";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laT;
        private System.Windows.Forms.Label laCredit;
        private System.Windows.Forms.DateTimePicker datT;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button Cancel;
    }
}