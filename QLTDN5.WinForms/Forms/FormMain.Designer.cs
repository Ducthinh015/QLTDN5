using System.Drawing;
using System.Windows.Forms;

namespace QLTDN5.WinForms.Forms
{
    partial class FormMain
    {
        private Label lblWelcome;
        private Button btnNhanVien;
        private Button btnKhachHang;
        private Button btnHoaDon;
        private Button btnBaoCao;
        private Button btnBangGia;
        private Button btnTramDien;
        private Button btnCongToDien;
        private Button btnChiSoDien;
        private Button btnDangXuat;


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            lblWelcome = new Label();
            btnNhanVien = new Button();
            btnKhachHang = new Button();
            btnHoaDon = new Button();
            btnBaoCao = new Button();
            btnBangGia = new Button();
            btnTramDien = new Button();
            btnCongToDien = new Button();
            btnChiSoDien = new Button();
            btnDangXuat = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblWelcome.Location = new Point(20, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(0, 28);
            lblWelcome.TabIndex = 0;
            // 
            // btnNhanVien
            // 
            btnNhanVien.Location = new Point(12, 247);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(197, 40);
            btnNhanVien.TabIndex = 1;
            btnNhanVien.Text = "Quản Lý Nhân viên";
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnKhachHang
            // 
            btnKhachHang.Location = new Point(12, 293);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(197, 40);
            btnKhachHang.TabIndex = 2;
            btnKhachHang.Text = "Quản Lý Khách hàng";
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // btnHoaDon
            // 
            btnHoaDon.Location = new Point(12, 342);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(197, 40);
            btnHoaDon.TabIndex = 3;
            btnHoaDon.Text = "Quản Lý Hóa đơn";
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // btnBaoCao
            // 
            btnBaoCao.Location = new Point(465, 390);
            btnBaoCao.Name = "btnBaoCao";
            btnBaoCao.Size = new Size(197, 40);
            btnBaoCao.TabIndex = 4;
            btnBaoCao.Text = "Quản Lý Báo cáo";
            btnBaoCao.Click += btnBaoCao_Click;
            // 
            // btnBangGia
            // 
            btnBangGia.Location = new Point(12, 201);
            btnBangGia.Name = "btnBangGia";
            btnBangGia.Size = new Size(197, 40);
            btnBangGia.TabIndex = 5;
            btnBangGia.Text = "Quản Lý Bảng giá";
            btnBangGia.Click += btnBangGia_Click;
            // 
            // btnTramDien
            // 
            btnTramDien.Location = new Point(12, 155);
            btnTramDien.Name = "btnTramDien";
            btnTramDien.Size = new Size(197, 40);
            btnTramDien.TabIndex = 6;
            btnTramDien.Text = "Quản Lý Trạm điện";
            btnTramDien.Click += btnTramDien_Click;
            // 
            // btnCongToDien
            // 
            btnCongToDien.Location = new Point(238, 388);
            btnCongToDien.Name = "btnCongToDien";
            btnCongToDien.Size = new Size(197, 42);
            btnCongToDien.TabIndex = 7;
            btnCongToDien.Text = "Quản Lý Công tơ điện";
            btnCongToDien.Click += btnCongToDien_Click;
            // 
            // btnChiSoDien
            // 
            btnChiSoDien.Location = new Point(12, 388);
            btnChiSoDien.Name = "btnChiSoDien";
            btnChiSoDien.Size = new Size(197, 40);
            btnChiSoDien.TabIndex = 8;
            btnChiSoDien.Text = "Quản Lý Chỉ số điện";
            btnChiSoDien.Click += btnChiSoDien_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.Red;
            btnDangXuat.Location = new Point(482, 485);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(197, 37);
            btnDangXuat.TabIndex = 9;
            btnDangXuat.Text = "Đăng Xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(238, 155);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(424, 207);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FormMain
            // 
            ClientSize = new Size(700, 534);
            Controls.Add(pictureBox1);
            Controls.Add(btnDangXuat);
            Controls.Add(lblWelcome);
            Controls.Add(btnNhanVien);
            Controls.Add(btnKhachHang);
            Controls.Add(btnHoaDon);
            Controls.Add(btnBaoCao);
            Controls.Add(btnBangGia);
            Controls.Add(btnTramDien);
            Controls.Add(btnCongToDien);
            Controls.Add(btnChiSoDien);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang chính quản lý";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Button button1;
        private PictureBox pictureBox1;
    }
}
