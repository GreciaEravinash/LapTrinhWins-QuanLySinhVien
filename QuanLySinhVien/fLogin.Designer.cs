namespace QuanLySinhVien
{
    partial class fLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.logicBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.UserNameTxt = new System.Windows.Forms.TextBox();
            this.PassTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(75, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(465, 108);
            this.label3.TabIndex = 2;
            this.label3.Text = "PHẦN MỀM QUẢN LÝ SINH VIÊN KHOA CÔNG NGHỆ THÔNG TIN";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logicBtn
            // 
            this.logicBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logicBtn.Location = new System.Drawing.Point(137, 272);
            this.logicBtn.Name = "logicBtn";
            this.logicBtn.Size = new System.Drawing.Size(156, 49);
            this.logicBtn.TabIndex = 2;
            this.logicBtn.Text = "ĐĂNG NHẬP";
            this.logicBtn.Click += new System.EventHandler(this.logicBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(329, 272);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(156, 49);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "THOÁT";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // UserNameTxt
            // 
            this.UserNameTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.UserNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTxt.Location = new System.Drawing.Point(243, 149);
            this.UserNameTxt.Name = "UserNameTxt";
            this.UserNameTxt.Size = new System.Drawing.Size(282, 34);
            this.UserNameTxt.TabIndex = 0;
            // 
            // PassTxt
            // 
            this.PassTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.PassTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassTxt.Location = new System.Drawing.Point(243, 215);
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.Size = new System.Drawing.Size(282, 34);
            this.PassTxt.TabIndex = 1;
            this.PassTxt.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phần mềm được xây dựng bởi nhóm NoWindow";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fLogin
            // 
            this.AcceptButton = this.logicBtn;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(570, 358);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PassTxt);
            this.Controls.Add(this.UserNameTxt);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.logicBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập Phần mềm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FLogin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button logicBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox UserNameTxt;
        private System.Windows.Forms.TextBox PassTxt;
        private System.Windows.Forms.Label label4;
    }
}

