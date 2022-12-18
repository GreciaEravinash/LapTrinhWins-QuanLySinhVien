namespace QuanLySinhVien
{
    partial class fAccount
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
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbDisplayname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbCurrentPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbNewPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txbReenterNewPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Location = new System.Drawing.Point(252, 430);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(126, 53);
            this.BtnUpdate.TabIndex = 4;
            this.BtnUpdate.Text = "Cập nhật";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbUsername);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 70);
            this.panel1.TabIndex = 5;
            // 
            // txbUsername
            // 
            this.txbUsername.Cursor = System.Windows.Forms.Cursors.Default;
            this.txbUsername.Enabled = false;
            this.txbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsername.Location = new System.Drawing.Point(221, 18);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.ReadOnly = true;
            this.txbUsername.Size = new System.Drawing.Size(282, 28);
            this.txbUsername.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên tài khoản:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbDisplayname);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(518, 70);
            this.panel2.TabIndex = 6;
            // 
            // txbDisplayname
            // 
            this.txbDisplayname.Cursor = System.Windows.Forms.Cursors.Default;
            this.txbDisplayname.Enabled = false;
            this.txbDisplayname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDisplayname.Location = new System.Drawing.Point(221, 16);
            this.txbDisplayname.Name = "txbDisplayname";
            this.txbDisplayname.ReadOnly = true;
            this.txbDisplayname.Size = new System.Drawing.Size(282, 28);
            this.txbDisplayname.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên hiển thị:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbCurrentPassword);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(12, 189);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(518, 70);
            this.panel3.TabIndex = 6;
            // 
            // txbCurrentPassword
            // 
            this.txbCurrentPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.txbCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCurrentPassword.Location = new System.Drawing.Point(221, 16);
            this.txbCurrentPassword.Name = "txbCurrentPassword";
            this.txbCurrentPassword.Size = new System.Drawing.Size(282, 28);
            this.txbCurrentPassword.TabIndex = 1;
            this.txbCurrentPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập mật khẩu hiện tại:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbNewPassword);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(12, 265);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(518, 70);
            this.panel4.TabIndex = 7;
            // 
            // txbNewPassword
            // 
            this.txbNewPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.txbNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNewPassword.Location = new System.Drawing.Point(221, 17);
            this.txbNewPassword.Name = "txbNewPassword";
            this.txbNewPassword.Size = new System.Drawing.Size(282, 28);
            this.txbNewPassword.TabIndex = 2;
            this.txbNewPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Đặt mật khẩu mới:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txbReenterNewPassword);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(12, 341);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(518, 70);
            this.panel5.TabIndex = 7;
            // 
            // txbReenterNewPassword
            // 
            this.txbReenterNewPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.txbReenterNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbReenterNewPassword.Location = new System.Drawing.Point(221, 16);
            this.txbReenterNewPassword.Name = "txbReenterNewPassword";
            this.txbReenterNewPassword.Size = new System.Drawing.Size(282, 28);
            this.txbReenterNewPassword.TabIndex = 3;
            this.txbReenterNewPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nhập lại mật khẩu mới:";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(389, 431);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(126, 53);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.Text = "Thoát";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // fAccount
            // 
            this.AcceptButton = this.BtnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 497);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnUpdate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "fAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin cá nhân";
            this.Load += new System.EventHandler(this.fAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbDisplayname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbCurrentPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbNewPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txbReenterNewPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ExitBtn;
    }
}