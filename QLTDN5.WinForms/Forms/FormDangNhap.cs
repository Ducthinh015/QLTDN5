using System;
using System.Windows.Forms;

namespace QLTDN5.WinForms.Forms
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            label = new Label();
            txtTaiKhoan = new TextBox();
            txtMatKhau = new TextBox();
            lblTaiKhoan = new Label();
            lblMatKhau = new Label();
            btnDangNhap = new Button();
            btnThoat = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            label.Location = new System.Drawing.Point(341, 12);
            label.Name = "label";
            label.Size = new System.Drawing.Size(387, 38);
            label.TabIndex = 0;
            label.Text = "Hệ thống Quản Lý Tiền Điện";
            label.Click += label_Click;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new System.Drawing.Point(387, 79);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new System.Drawing.Size(250, 31);
            txtTaiKhoan.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new System.Drawing.Point(387, 131);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new System.Drawing.Size(250, 31);
            txtMatKhau.TabIndex = 4;
            // 
            // lblTaiKhoan
            // 
            lblTaiKhoan.AutoSize = true;
            lblTaiKhoan.Location = new System.Drawing.Point(291, 85);
            lblTaiKhoan.Name = "lblTaiKhoan";
            lblTaiKhoan.Size = new System.Drawing.Size(90, 25);
            lblTaiKhoan.TabIndex = 1;
            lblTaiKhoan.Text = "Tài khoản:";
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Location = new System.Drawing.Point(291, 137);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new System.Drawing.Size(90, 25);
            lblMatKhau.TabIndex = 3;
            lblMatKhau.Text = "Mật khẩu:";
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = System.Drawing.Color.Lime;
            btnDangNhap.Location = new System.Drawing.Point(387, 180);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new System.Drawing.Size(250, 37);
            btnDangNhap.TabIndex = 5;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = System.Drawing.Color.Red;
            btnThoat.Location = new System.Drawing.Point(562, 237);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new System.Drawing.Size(75, 37);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(223, 224);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.SystemColors.ControlDark;
            label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            label1.Location = new System.Drawing.Point(12, 249);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(78, 28);
            label1.TabIndex = 10;
            label1.Text = "Nhóm 09 ";
            label1.Click += label1_Click;
            // 
            // FormDangNhap
            // 
            ClientSize = new System.Drawing.Size(651, 286);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label);
            Controls.Add(lblTaiKhoan);
            Controls.Add(txtTaiKhoan);
            Controls.Add(lblMatKhau);
            Controls.Add(txtMatKhau);
            Controls.Add(btnDangNhap);
            Controls.Add(btnThoat);
            Name = "FormDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập hệ thống Quản Lý Tiền Điện";
            Load += FormDangNhap_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tk = txtTaiKhoan.Text.Trim();
            string mk = txtMatKhau.Text.Trim();

            // Tài khoản giả lập
            if (tk == "admin" && mk == "123")
            {
                CurrentUser.Username = tk;
                CurrentUser.UserRole = Role.Admin;
                MessageBox.Show("Đăng nhập thành công (Admin)!", "Thông báo");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (tk == "nv" && mk == "123")
            {
                CurrentUser.Username = tk;
                CurrentUser.UserRole = Role.NhanVien;
                MessageBox.Show("Đăng nhập thành công (Nhân viên)!", "Thông báo");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (tk == "ketoan" && mk == "123")
            {
                CurrentUser.Username = tk;
                CurrentUser.UserRole = Role.KeToan;
                MessageBox.Show("Đăng nhập thành công (Kế toán)!", "Thông báo");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Label label;
        private Label lblTaiKhoan;
        private Label lblMatKhau;
        private TextBox txtTaiKhoan;
        private TextBox txtMatKhau;
        private Button btnDangNhap;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnThoat;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label_Click(object sender, EventArgs e)
        {
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}