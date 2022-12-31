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
            this.rdbtnSearchMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnSearchMSSV.Location = new System.Drawing.Point(45, 15);
            this.rdbtnSearchMSSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbtnSearchMSSV.Name = "rdbtnSearchMSSV";
            this.rdbtnSearchMSSV.Size = new System.Drawing.Size(216, 26);
            this.rdbtnSearchMSSV.TabIndex = 0;
            this.rdbtnSearchMSSV.TabStop = true;
            this.rdbtnSearchMSSV.Text = "Tìm kiếm theo MSSV";
            this.rdbtnSearchMSSV.UseVisualStyleBackColor = true;
            this.rdbtnSearchMSSV.CheckedChanged += new System.EventHandler(this.rdbtnSearchMSSV_CheckedChanged);
            // 
            // rdbtnSearchName
            // 
            this.rdbtnSearchName.AutoSize = true;
            this.rdbtnSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnSearchName.Location = new System.Drawing.Point(45, 65);
            this.rdbtnSearchName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbtnSearchName.Name = "rdbtnSearchName";
            this.rdbtnSearchName.Size = new System.Drawing.Size(190, 26);
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
            this.txbSearchMSSV.Location = new System.Drawing.Point(311, 15);
            this.txbSearchMSSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbSearchMSSV.Name = "txbSearchMSSV";
            this.txbSearchMSSV.Size = new System.Drawing.Size(290, 29);
            this.txbSearchMSSV.TabIndex = 2;
            // 
            // txbSearchName
            // 
            this.txbSearchName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSearchName.Enabled = false;
            this.txbSearchName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchName.Location = new System.Drawing.Point(311, 65);
            this.txbSearchName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbSearchName.Name = "txbSearchName";
            this.txbSearchName.Size = new System.Drawing.Size(290, 29);
            this.txbSearchName.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Location = new System.Drawing.Point(233, 118);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(168, 44);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "TÌM KIẾM";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(433, 118);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(168, 44);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "HỦY";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // fSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(628, 184);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txbSearchName);
            this.Controls.Add(this.txbSearchMSSV);
            this.Controls.Add(this.rdbtnSearchName);
            this.Controls.Add(this.rdbtnSearchMSSV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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