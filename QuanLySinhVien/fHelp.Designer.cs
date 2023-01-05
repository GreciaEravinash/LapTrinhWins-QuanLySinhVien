namespace QuanLySinhVien
{
    partial class fHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHelp));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label19 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Info;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Items.AddRange(new object[] {
            "Đây là phần mềm Quản lý sinh viên do nhóm NoWindows đang phát triển bao gồm các t" +
                "hành viên:",
            "- Nguyễn Hoàng Trung",
            "- Phạm Lê Khánh Minh",
            "- Nguyễn Thị Thu Hằng",
            "",
            "Bước 1:",
            "- Sử dụng tài khoản admin hoặc tài khoản sinh viên (mã số sinh viên) để đăng nhập" +
                ": ",
            "",
            "Bước 2:",
            "Đối với tài khoản sinh viên sẽ có giao diện như sau:",
            "Về Chức năng có sẵn dành cho người dùng:",
            "- Tìm kiếm và xem thông tin sinh viên",
            "+ Ở đây có chức năng xem , khi ấn vào một dòng bất kì trong bên bảng trái sẽ hiện" +
                " rõ thông tin chi tiết ",
            "+ Chức năng tìm sẽ 2 chế độ tìm là : tìm kiếm theo Mã số sinh viên , Họ và tên si" +
                "nh viên.",
            "Khi tìm thấy sinh viên sẽ hiển thị bên bảng trái , còn không sẽ không xuất hiện",
            "- Đổi mật khẩu ",
            "+ Khi đó, người dùng cần nhập mật khẩu cũ , mật khẩu mới và nhập lại mật khẩu mới" +
                " để được cập nhật.",
            "Và ngoài ra còn có các chức năng khác ấn nút …. Để làm mới danh sách hiện tại khi" +
                " ứng dụng không hiển thị danh sách mới sau khi thao tác các chức năng ",
            " ",
            "Đối với tài khoản admin sẽ có giao diện như sau:",
            "Về chức năng của quản trị viên bao gồm:",
            "- Chỉnh sửa , thêm xóa , sinh viên ",
            "+ Chỉnh sửa sinh viên sẽ thay đổi thông tin ngoại trừ Mã số sinh viên.",
            "+ Thêm sinh viên sẽ yêu cầu nhập toàn bộ thông tin cần thiết để cập nhật",
            "+ Xóa sinh viên sẽ hoạt động nếu bạn ấn vào bất kì dòng thông tin nào cần xóa ",
            "",
            "- Xem danh sách tài khoản",
            "+ Sẽ mở ra Danh sách tài khoản hiện có của sinh viên",
            "",
            "- Thêm, xóa tài khoản sinh viên và quản trị viên",
            "+ Sẽ tạo cho sinh viên tài khoản có tên tài khoản là mã số sinh viên và mật khẩu " +
                "mặc định là 123",
            "+ Nếu là admin thì tạo tài khoản mà khoong cần mã số sinh viên",
            "+ Ấn chọn 1 tài khoản bất kì và xóa nó",
            "",
            "- Cài đặt mật khẩu mặc định cho sinh viên",
            "+ Ấn chọn 1 tài khoản bất kì sau đó ấn nút Reset để mật khẩu reset về mặc định là" +
                " 123",
            "",
            "- Chức năng tìm kiếm tài khoản theo mssv ,tên tài khoản , tên hiển thị",
            "- Bao gồm các chức năng mặc định của người dùng (Xem thông tin , Đổi mật khẩu )",
            "",
            "Và ngoài ra còn có các chức năng khác ấn nút Refesh để làm mới danh sách hiện tại" +
                " khi ứng dụng không hiển thị danh sách mới sau khi thao tác các chức năng "});
            this.listBox1.Location = new System.Drawing.Point(2, 88);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(1367, 575);
            this.listBox1.TabIndex = 36;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Tomato;
            this.label19.Location = new System.Drawing.Point(534, 21);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(444, 45);
            this.label19.TabIndex = 37;
            this.label19.Text = "HƯỚNG DẪN SỬ DỤNG";
            // 
            // fHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1374, 670);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trợ giúp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label19;
    }
}