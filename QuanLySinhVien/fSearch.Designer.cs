namespace QuanLySinhVien
{
    partial class fSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSearch));
            this.rdbtnSearchMSSV = new System.Windows.Forms.RadioButton();
            this.rdbtnSearchName = new System.Windows.Forms.RadioButton();
            this.txbSearchMSSV = new System.Windows.Forms.TextBox();
            this.txbSearchName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbtnSearchMSSV
            // 
            this.rdbtnSearchMSSV.AutoSize = true;
            this.rdbtnSearchMSSV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnSearchMSSV.Location = new System.Drawing.Point(34, 12);
            this.rdbtnSearchMSSV.Name = "rdbtnSearchMSSV";
            this.rdbtnSearchMSSV.Size = new System.Drawing.Size(155, 21);
            this.rdbtnSearchMSSV.TabIndex = 0;
            this.rdbtnSearchMSSV.TabStop = true;
            this.rdbtnSearchMSSV.Text = "Tìm kiếm theo MSSV";
            this.rdbtnSearchMSSV.UseVisualStyleBackColor = true;
            this.rdbtnSearchMSSV.CheckedChanged += new System.EventHandler(this.rdbtnSearchMSSV_CheckedChanged);
            // 
            // rdbtnSearchName
            // 
            this.rdbtnSearchName.AutoSize = true;
            this.rdbtnSearchName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnSearchName.Location = new System.Drawing.Point(34, 53);
            this.rdbtnSearchName.Name = "rdbtnSearchName";
            this.rdbtnSearchName.Size = new System.Drawing.Size(140, 21);
            this.rdbtnSearchName.TabIndex = 1;
            this.rdbtnSearchName.TabStop = true;
            this.rdbtnSearchName.Text = "Tìm kiếm theo tên";
            this.rdbtnSearchName.UseVisualStyleBackColor = true;
            this.rdbtnSearchName.CheckedChanged += new System.EventHandler(this.rdbtnSearchName_CheckedChanged);
            // 
            // txbSearchMSSV
            // 
            this.txbSearchMSSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSearchMSSV.Enabled = false;
            this.txbSearchMSSV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchMSSV.Location = new System.Drawing.Point(212, 12);
            this.txbSearchMSSV.Name = "txbSearchMSSV";
            this.txbSearchMSSV.Size = new System.Drawing.Size(218, 25);
            this.txbSearchMSSV.TabIndex = 2;
            // 
            // txbSearchName
            // 
            this.txbSearchName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSearchName.Enabled = false;
            this.txbSearchName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchName.Location = new System.Drawing.Point(212, 53);
            this.txbSearchName.Name = "txbSearchName";
            this.txbSearchName.Size = new System.Drawing.Size(218, 25);
            this.txbSearchName.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(63, 108);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(126, 57);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(282, 108);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 57);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // fSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(481, 186);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txbSearchName);
            this.Controls.Add(this.txbSearchMSSV);
            this.Controls.Add(this.rdbtnSearchName);
            this.Controls.Add(this.rdbtnSearchMSSV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fSearch";
            this.Text = "Tìm kiếm thông tin sinh viên";
            this.Load += new System.EventHandler(this.fSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbtnSearchMSSV;
        private System.Windows.Forms.RadioButton rdbtnSearchName;
        private System.Windows.Forms.TextBox txbSearchMSSV;
        private System.Windows.Forms.TextBox txbSearchName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
    }
}