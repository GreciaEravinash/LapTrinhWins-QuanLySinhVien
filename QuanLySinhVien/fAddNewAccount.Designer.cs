namespace QuanLySinhVien
{
    partial class fAddNewAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAddNewAccount));
            this.MssvAccTxt = new System.Windows.Forms.TextBox();
            this.NameAcctxt = new System.Windows.Forms.TextBox();
            this.UsernameAcctxt = new System.Windows.Forms.TextBox();
            this.DisplaynameAcctxt = new System.Windows.Forms.TextBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AdminRBtn = new System.Windows.Forms.RadioButton();
            this.StudentRBtn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // MssvAccTxt
            // 
            this.MssvAccTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MssvAccTxt.Location = new System.Drawing.Point(232, 178);
            this.MssvAccTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MssvAccTxt.Name = "MssvAccTxt";
            this.MssvAccTxt.Size = new System.Drawing.Size(280, 30);
            this.MssvAccTxt.TabIndex = 2;
            this.MssvAccTxt.TextChanged += new System.EventHandler(this.MssvAccTxt_TextChanged);
            // 
            // NameAcctxt
            // 
            this.NameAcctxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameAcctxt.Location = new System.Drawing.Point(232, 234);
            this.NameAcctxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameAcctxt.Name = "NameAcctxt";
            this.NameAcctxt.Size = new System.Drawing.Size(280, 30);
            this.NameAcctxt.TabIndex = 3;
            this.NameAcctxt.TextChanged += new System.EventHandler(this.NameAcctxt_TextChanged);
            // 
            // UsernameAcctxt
            // 
            this.UsernameAcctxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameAcctxt.Location = new System.Drawing.Point(232, 293);
            this.UsernameAcctxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsernameAcctxt.Name = "UsernameAcctxt";
            this.UsernameAcctxt.Size = new System.Drawing.Size(280, 30);
            this.UsernameAcctxt.TabIndex = 5;
            // 
            // DisplaynameAcctxt
            // 
            this.DisplaynameAcctxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplaynameAcctxt.Location = new System.Drawing.Point(232, 350);
            this.DisplaynameAcctxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DisplaynameAcctxt.Name = "DisplaynameAcctxt";
            this.DisplaynameAcctxt.Size = new System.Drawing.Size(280, 30);
            this.DisplaynameAcctxt.TabIndex = 6;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.Black;
            this.BtnUpdate.Location = new System.Drawing.Point(204, 404);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(139, 60);
            this.BtnUpdate.TabIndex = 7;
            this.BtnUpdate.Text = "THÊM";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(373, 404);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 60);
            this.button1.TabIndex = 8;
            this.button1.Text = "HỦY";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 178);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã số SV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 235);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Họ và tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 295);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tên tài khoản:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 348);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tên hiển thị:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Tomato;
            this.label6.Location = new System.Drawing.Point(156, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "Đăng kí tài khoản";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(28, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Mời bạn nhập thông tin";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminRBtn
            // 
            this.AdminRBtn.AutoSize = true;
            this.AdminRBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminRBtn.Location = new System.Drawing.Point(304, 119);
            this.AdminRBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdminRBtn.Name = "AdminRBtn";
            this.AdminRBtn.Size = new System.Drawing.Size(81, 26);
            this.AdminRBtn.TabIndex = 17;
            this.AdminRBtn.TabStop = true;
            this.AdminRBtn.Text = "Admin";
            this.AdminRBtn.UseVisualStyleBackColor = true;
            this.AdminRBtn.CheckedChanged += new System.EventHandler(this.AdminRBtn_CheckedChanged);
            // 
            // StudentRBtn
            // 
            this.StudentRBtn.AutoSize = true;
            this.StudentRBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentRBtn.Location = new System.Drawing.Point(407, 119);
            this.StudentRBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StudentRBtn.Name = "StudentRBtn";
            this.StudentRBtn.Size = new System.Drawing.Size(105, 26);
            this.StudentRBtn.TabIndex = 18;
            this.StudentRBtn.TabStop = true;
            this.StudentRBtn.Text = "Sinh viên";
            this.StudentRBtn.UseVisualStyleBackColor = true;
            this.StudentRBtn.CheckedChanged += new System.EventHandler(this.StudentRBtn_CheckedChanged);
            // 
            // fAddNewAccount
            // 
            this.AcceptButton = this.BtnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(545, 482);
            this.Controls.Add(this.StudentRBtn);
            this.Controls.Add(this.AdminRBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.DisplaynameAcctxt);
            this.Controls.Add(this.UsernameAcctxt);
            this.Controls.Add(this.NameAcctxt);
            this.Controls.Add(this.MssvAccTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fAddNewAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm thông tin tài khoản ";
            this.Load += new System.EventHandler(this.fAddNewAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox MssvAccTxt;
        private System.Windows.Forms.TextBox NameAcctxt;
        private System.Windows.Forms.TextBox UsernameAcctxt;
        private System.Windows.Forms.TextBox DisplaynameAcctxt;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton AdminRBtn;
        private System.Windows.Forms.RadioButton StudentRBtn;
    }
}