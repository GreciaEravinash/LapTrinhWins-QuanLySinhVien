﻿namespace QuanLySinhVien
{
    partial class fAdmin
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
            this.listviewAccountList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbMssv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbClass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.EditAccBtn = new System.Windows.Forms.Button();
            this.DeleteAccBtn = new System.Windows.Forms.Button();
            this.FillterBtn = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.SreachAccBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // listviewAccountList
            // 
            this.listviewAccountList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listviewAccountList.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listviewAccountList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader7,
            this.columnHeader4,
            this.columnHeader5});
            this.listviewAccountList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listviewAccountList.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listviewAccountList.FullRowSelect = true;
            this.listviewAccountList.GridLines = true;
            this.listviewAccountList.HideSelection = false;
            this.listviewAccountList.Location = new System.Drawing.Point(12, 113);
            this.listviewAccountList.Name = "listviewAccountList";
            this.listviewAccountList.Size = new System.Drawing.Size(675, 470);
            this.listviewAccountList.TabIndex = 2;
            this.listviewAccountList.UseCompatibleStateImageBehavior = false;
            this.listviewAccountList.View = System.Windows.Forms.View.Details;
            this.listviewAccountList.SelectedIndexChanged += new System.EventHandler(this.listviewAccountList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MSSV";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ và tên";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 180;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Lớp";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên tài khoản";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 156;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mật khẩu ";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 154;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbMssv);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(699, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 46);
            this.panel1.TabIndex = 6;
            // 
            // txbMssv
            // 
            this.txbMssv.Cursor = System.Windows.Forms.Cursors.Default;
            this.txbMssv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMssv.Location = new System.Drawing.Point(186, 6);
            this.txbMssv.Name = "txbMssv";
            this.txbMssv.ReadOnly = true;
            this.txbMssv.Size = new System.Drawing.Size(255, 28);
            this.txbMssv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "MSSV:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(699, 221);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 47);
            this.panel2.TabIndex = 7;
            // 
            // txbName
            // 
            this.txbName.Cursor = System.Windows.Forms.Cursors.Default;
            this.txbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(186, 8);
            this.txbName.Name = "txbName";
            this.txbName.ReadOnly = true;
            this.txbName.Size = new System.Drawing.Size(255, 28);
            this.txbName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ và tên:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbClass);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(699, 274);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(457, 48);
            this.panel3.TabIndex = 7;
            // 
            // txbClass
            // 
            this.txbClass.Cursor = System.Windows.Forms.Cursors.Default;
            this.txbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbClass.Location = new System.Drawing.Point(186, 9);
            this.txbClass.Name = "txbClass";
            this.txbClass.ReadOnly = true;
            this.txbClass.Size = new System.Drawing.Size(255, 28);
            this.txbClass.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lớp:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbUsername);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(699, 328);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(457, 47);
            this.panel4.TabIndex = 7;
            // 
            // txbUsername
            // 
            this.txbUsername.Cursor = System.Windows.Forms.Cursors.Default;
            this.txbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsername.Location = new System.Drawing.Point(186, 7);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.ReadOnly = true;
            this.txbUsername.Size = new System.Drawing.Size(255, 28);
            this.txbUsername.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên tài khoản:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txbPassword);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(699, 381);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(457, 45);
            this.panel5.TabIndex = 8;
            // 
            // txbPassword
            // 
            this.txbPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.txbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassword.Location = new System.Drawing.Point(186, 6);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.ReadOnly = true;
            this.txbPassword.Size = new System.Drawing.Size(255, 28);
            this.txbPassword.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mật khẩu:";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(270, 43);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(554, 36);
            this.label19.TabIndex = 26;
            this.label19.Text = "DANH SÁCH TÀI KHOẢN SINH VIÊN";
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(699, 124);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(92, 17);
            this.lblUsername.TabIndex = 28;
            this.lblUsername.Text = "Tên truy cập:";
            // 
            // EditAccBtn
            // 
            this.EditAccBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditAccBtn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditAccBtn.Location = new System.Drawing.Point(24, 68);
            this.EditAccBtn.Name = "EditAccBtn";
            this.EditAccBtn.Size = new System.Drawing.Size(184, 48);
            this.EditAccBtn.TabIndex = 6;
            this.EditAccBtn.Text = "CHỈNH SỬA";
            this.EditAccBtn.UseVisualStyleBackColor = true;
            this.EditAccBtn.Click += new System.EventHandler(this.EditAccBtn_Click);
            // 
            // DeleteAccBtn
            // 
            this.DeleteAccBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteAccBtn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAccBtn.Location = new System.Drawing.Point(214, 7);
            this.DeleteAccBtn.Name = "DeleteAccBtn";
            this.DeleteAccBtn.Size = new System.Drawing.Size(194, 48);
            this.DeleteAccBtn.TabIndex = 7;
            this.DeleteAccBtn.Text = "XÓA";
            this.DeleteAccBtn.UseVisualStyleBackColor = true;
            // 
            // FillterBtn
            // 
            this.FillterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FillterBtn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FillterBtn.Location = new System.Drawing.Point(24, 7);
            this.FillterBtn.Name = "FillterBtn";
            this.FillterBtn.Size = new System.Drawing.Size(184, 48);
            this.FillterBtn.TabIndex = 5;
            this.FillterBtn.Text = "LỌC";
            this.FillterBtn.UseVisualStyleBackColor = true;
            this.FillterBtn.Click += new System.EventHandler(this.AcpHaxBtn_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.AutoSize = true;
            this.panel6.Controls.Add(this.SreachAccBtn);
            this.panel6.Controls.Add(this.FillterBtn);
            this.panel6.Controls.Add(this.EditAccBtn);
            this.panel6.Controls.Add(this.DeleteAccBtn);
            this.panel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(727, 433);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(429, 119);
            this.panel6.TabIndex = 29;
            // 
            // SreachAccBtn
            // 
            this.SreachAccBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SreachAccBtn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SreachAccBtn.Location = new System.Drawing.Point(214, 68);
            this.SreachAccBtn.Name = "SreachAccBtn";
            this.SreachAccBtn.Size = new System.Drawing.Size(193, 48);
            this.SreachAccBtn.TabIndex = 8;
            this.SreachAccBtn.Text = "TIM KIEM";
            this.SreachAccBtn.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(699, 563);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "Tổng số sinh viên: ";
            // 
            // fAdmin
            // 
            this.AcceptButton = this.EditAccBtn;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1178, 595);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listviewAccountList);
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông tin tài khoản - mật khẩu Sinh viên";
            this.Load += new System.EventHandler(this.fAdmin_Load);
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
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listviewAccountList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbMssv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button EditAccBtn;
        private System.Windows.Forms.Button DeleteAccBtn;
        private System.Windows.Forms.Button FillterBtn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button SreachAccBtn;
        private System.Windows.Forms.Label label8;
    }
}