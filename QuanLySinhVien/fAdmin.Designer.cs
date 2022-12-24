namespace QuanLySinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAdmin));
            this.listviewAccountList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.columnHeader3});
            this.listviewAccountList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listviewAccountList.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listviewAccountList.FullRowSelect = true;
            this.listviewAccountList.GridLines = true;
            this.listviewAccountList.HideSelection = false;
            this.listviewAccountList.Location = new System.Drawing.Point(12, 124);
            this.listviewAccountList.Name = "listviewAccountList";
            this.listviewAccountList.Size = new System.Drawing.Size(705, 459);
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
            this.columnHeader7.Width = 114;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên tài khoản";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 156;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên hiển thị";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 150;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbMssv);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(723, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 46);
            this.panel1.TabIndex = 6;
            // 
            // txbMssv
            // 
            this.txbMssv.BackColor = System.Drawing.SystemColors.Window;
            this.txbMssv.Cursor = System.Windows.Forms.Cursors.Default;
            this.txbMssv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMssv.Location = new System.Drawing.Point(168, 5);
            this.txbMssv.Name = "txbMssv";
            this.txbMssv.ReadOnly = true;
            this.txbMssv.Size = new System.Drawing.Size(271, 34);
            this.txbMssv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã số SV";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(723, 238);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 47);
            this.panel2.TabIndex = 7;
            // 
            // txbName
            // 
            this.txbName.BackColor = System.Drawing.SystemColors.Window;
            this.txbName.Cursor = System.Windows.Forms.Cursors.Default;
            this.txbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(168, 7);
            this.txbName.Name = "txbName";
            this.txbName.ReadOnly = true;
            this.txbName.Size = new System.Drawing.Size(271, 34);
            this.txbName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ và tên";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbClass);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(723, 291);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(443, 48);
            this.panel3.TabIndex = 7;
            // 
            // txbClass
            // 
            this.txbClass.BackColor = System.Drawing.SystemColors.Window;
            this.txbClass.Cursor = System.Windows.Forms.Cursors.Default;
            this.txbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbClass.Location = new System.Drawing.Point(168, 5);
            this.txbClass.Name = "txbClass";
            this.txbClass.ReadOnly = true;
            this.txbClass.Size = new System.Drawing.Size(271, 34);
            this.txbClass.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lớp";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbUsername);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(723, 345);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(443, 47);
            this.panel4.TabIndex = 7;
            // 
            // txbUsername
            // 
            this.txbUsername.BackColor = System.Drawing.SystemColors.Window;
            this.txbUsername.Cursor = System.Windows.Forms.Cursors.Default;
            this.txbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsername.Location = new System.Drawing.Point(168, 5);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.ReadOnly = true;
            this.txbUsername.Size = new System.Drawing.Size(271, 34);
            this.txbUsername.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên Tài Khoản";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txbPassword);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(723, 398);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(443, 45);
            this.panel5.TabIndex = 8;
            // 
            // txbPassword
            // 
            this.txbPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txbPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.txbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassword.Location = new System.Drawing.Point(168, 3);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.ReadOnly = true;
            this.txbPassword.Size = new System.Drawing.Size(271, 34);
            this.txbPassword.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tên hiển thị";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Tomato;
            this.label19.Location = new System.Drawing.Point(273, 50);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(681, 45);
            this.label19.TabIndex = 26;
            this.label19.Text = "DANH SÁCH TÀI KHOẢN SINH VIÊN";
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(719, 163);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(107, 20);
            this.lblUsername.TabIndex = 28;
            this.lblUsername.Text = "Tên truy cập:";
            // 
            // EditAccBtn
            // 
            this.EditAccBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditAccBtn.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.EditAccBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditAccBtn.Location = new System.Drawing.Point(24, 70);
            this.EditAccBtn.Name = "EditAccBtn";
            this.EditAccBtn.Size = new System.Drawing.Size(153, 48);
            this.EditAccBtn.TabIndex = 6;
            this.EditAccBtn.Text = "CHỈNH SỬA";
            this.EditAccBtn.UseVisualStyleBackColor = false;
            this.EditAccBtn.Click += new System.EventHandler(this.EditAccBtn_Click);
            // 
            // DeleteAccBtn
            // 
            this.DeleteAccBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteAccBtn.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.DeleteAccBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAccBtn.Location = new System.Drawing.Point(214, 9);
            this.DeleteAccBtn.Name = "DeleteAccBtn";
            this.DeleteAccBtn.Size = new System.Drawing.Size(163, 48);
            this.DeleteAccBtn.TabIndex = 7;
            this.DeleteAccBtn.Text = "XÓA";
            this.DeleteAccBtn.UseVisualStyleBackColor = false;
            this.DeleteAccBtn.Click += new System.EventHandler(this.DeleteAccBtn_Click);
            // 
            // FillterBtn
            // 
            this.FillterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FillterBtn.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.FillterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FillterBtn.Location = new System.Drawing.Point(24, 9);
            this.FillterBtn.Name = "FillterBtn";
            this.FillterBtn.Size = new System.Drawing.Size(153, 48);
            this.FillterBtn.TabIndex = 5;
            this.FillterBtn.Text = "LỌC";
            this.FillterBtn.UseVisualStyleBackColor = false;
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
            this.panel6.Location = new System.Drawing.Point(749, 449);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(398, 121);
            this.panel6.TabIndex = 29;
            // 
            // SreachAccBtn
            // 
            this.SreachAccBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SreachAccBtn.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.SreachAccBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SreachAccBtn.Location = new System.Drawing.Point(214, 70);
            this.SreachAccBtn.Name = "SreachAccBtn";
            this.SreachAccBtn.Size = new System.Drawing.Size(162, 48);
            this.SreachAccBtn.TabIndex = 8;
            this.SreachAccBtn.Text = "TÌM KIẾM";
            this.SreachAccBtn.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Tổng số sinh viên: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLySinhVien.Properties.Resources.fithcmue;
            this.pictureBox1.Location = new System.Drawing.Point(1031, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1178, 28);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.đăngXuấtToolStripMenuItem.Text = "Trở Lại";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem1
            // 
            this.đăngXuấtToolStripMenuItem1.Name = "đăngXuấtToolStripMenuItem1";
            this.đăngXuấtToolStripMenuItem1.Size = new System.Drawing.Size(94, 24);
            this.đăngXuấtToolStripMenuItem1.Text = "Đăng xuất";
            // 
            // fAdmin
            // 
            this.AcceptButton = this.EditAccBtn;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1178, 595);
            this.Controls.Add(this.pictureBox1);
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
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listviewAccountList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
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
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem1;
    }
}