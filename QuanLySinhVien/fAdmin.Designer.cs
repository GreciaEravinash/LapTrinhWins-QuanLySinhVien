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
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbMssv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txbDisplayName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.ResetPassBtn = new System.Windows.Forms.Button();
            this.DeleteAccBtn = new System.Windows.Forms.Button();
            this.AddAccBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.SreachAccBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.listviewAccountList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listviewAccountList_ColumnClick);
            this.listviewAccountList.SelectedIndexChanged += new System.EventHandler(this.listviewAccountList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MSSV";
            this.columnHeader1.Width = 170;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ và tên";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 197;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên tài khoản";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 159;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên hiển thị";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 173;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbMssv);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(723, 225);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 46);
            this.panel1.TabIndex = 6;
            // 
            // txbMssv
            // 
            this.txbMssv.BackColor = System.Drawing.SystemColors.Window;
            this.txbMssv.Cursor = System.Windows.Forms.Cursors.Default;
            this.txbMssv.Enabled = false;
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
            this.panel2.Location = new System.Drawing.Point(723, 277);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 47);
            this.panel2.TabIndex = 7;
            // 
            // txbName
            // 
            this.txbName.BackColor = System.Drawing.SystemColors.Window;
            this.txbName.Cursor = System.Windows.Forms.Cursors.Default;
            this.txbName.Enabled = false;
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
            // panel4
            // 
            this.panel4.Controls.Add(this.txbUsername);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(723, 330);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(443, 47);
            this.panel4.TabIndex = 7;
            // 
            // txbUsername
            // 
            this.txbUsername.BackColor = System.Drawing.SystemColors.Window;
            this.txbUsername.Cursor = System.Windows.Forms.Cursors.Default;
            this.txbUsername.Enabled = false;
            this.txbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsername.Location = new System.Drawing.Point(168, 5);
            this.txbUsername.Name = "txbUsername";
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
            this.panel5.Controls.Add(this.txbDisplayName);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(723, 383);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(443, 45);
            this.panel5.TabIndex = 8;
            // 
            // txbDisplayName
            // 
            this.txbDisplayName.BackColor = System.Drawing.SystemColors.Window;
            this.txbDisplayName.Cursor = System.Windows.Forms.Cursors.Default;
            this.txbDisplayName.Enabled = false;
            this.txbDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDisplayName.Location = new System.Drawing.Point(168, 3);
            this.txbDisplayName.Name = "txbDisplayName";
            this.txbDisplayName.Size = new System.Drawing.Size(271, 34);
            this.txbDisplayName.TabIndex = 4;
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
            this.label19.Location = new System.Drawing.Point(326, 49);
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
            this.lblUsername.Location = new System.Drawing.Point(719, 192);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(107, 20);
            this.lblUsername.TabIndex = 28;
            this.lblUsername.Text = "Tên truy cập:";
            // 
            // ResetPassBtn
            // 
            this.ResetPassBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetPassBtn.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ResetPassBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetPassBtn.Location = new System.Drawing.Point(24, 70);
            this.ResetPassBtn.Name = "ResetPassBtn";
            this.ResetPassBtn.Size = new System.Drawing.Size(128, 48);
            this.ResetPassBtn.TabIndex = 6;
            this.ResetPassBtn.Text = "RESET";
            this.ResetPassBtn.UseVisualStyleBackColor = false;
            this.ResetPassBtn.Click += new System.EventHandler(this.ResetPassBtn_Click);
            // 
            // DeleteAccBtn
            // 
            this.DeleteAccBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteAccBtn.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.DeleteAccBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAccBtn.Location = new System.Drawing.Point(175, 9);
            this.DeleteAccBtn.Name = "DeleteAccBtn";
            this.DeleteAccBtn.Size = new System.Drawing.Size(127, 48);
            this.DeleteAccBtn.TabIndex = 7;
            this.DeleteAccBtn.Text = "XÓA";
            this.DeleteAccBtn.UseVisualStyleBackColor = false;
            this.DeleteAccBtn.Click += new System.EventHandler(this.DeleteAccBtn_Click);
            // 
            // AddAccBtn
            // 
            this.AddAccBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddAccBtn.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.AddAccBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAccBtn.Location = new System.Drawing.Point(24, 9);
            this.AddAccBtn.Name = "AddAccBtn";
            this.AddAccBtn.Size = new System.Drawing.Size(128, 48);
            this.AddAccBtn.TabIndex = 5;
            this.AddAccBtn.Text = "THÊM";
            this.AddAccBtn.UseVisualStyleBackColor = false;
            this.AddAccBtn.Click += new System.EventHandler(this.AddAccBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshBtn.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.RefreshBtn.BackgroundImage = global::QuanLySinhVien.Properties.Resources.Refresh;
            this.RefreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RefreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.ForeColor = System.Drawing.Color.Black;
            this.RefreshBtn.Location = new System.Drawing.Point(318, 39);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(63, 52);
            this.RefreshBtn.TabIndex = 36;
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // SreachAccBtn
            // 
            this.SreachAccBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SreachAccBtn.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.SreachAccBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SreachAccBtn.Location = new System.Drawing.Point(175, 70);
            this.SreachAccBtn.Name = "SreachAccBtn";
            this.SreachAccBtn.Size = new System.Drawing.Size(127, 48);
            this.SreachAccBtn.TabIndex = 8;
            this.SreachAccBtn.Text = "TÌM KIẾM";
            this.SreachAccBtn.UseVisualStyleBackColor = false;
            this.SreachAccBtn.Click += new System.EventHandler(this.SreachAccBtn_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Tổng số tài khoản:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLySinhVien.Properties.Resources.fithcmue;
            this.pictureBox1.Location = new System.Drawing.Point(1037, 49);
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
            this.trợGiúpToolStripMenuItem});
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
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.trợGiúpToolStripMenuItem.Text = "Trợ Giúp";
            this.trợGiúpToolStripMenuItem.Click += new System.EventHandler(this.trợGiúpToolStripMenuItem_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.AutoSize = true;
            this.panel6.Controls.Add(this.RefreshBtn);
            this.panel6.Controls.Add(this.SreachAccBtn);
            this.panel6.Controls.Add(this.AddAccBtn);
            this.panel6.Controls.Add(this.ResetPassBtn);
            this.panel6.Controls.Add(this.DeleteAccBtn);
            this.panel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(749, 446);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(715, 121);
            this.panel6.TabIndex = 29;
            // 
            // fAdmin
            // 
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
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listviewAccountList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbMssv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txbDisplayName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button ResetPassBtn;
        private System.Windows.Forms.Button DeleteAccBtn;
        private System.Windows.Forms.Button AddAccBtn;
        private System.Windows.Forms.Button SreachAccBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
    }
}