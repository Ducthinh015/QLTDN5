using System;
using System.Windows.Forms;

namespace QLTDN5.WinForms.Forms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Xin chào: {CurrentUser.Username} ({CurrentUser.UserRole})";

            switch (CurrentUser.UserRole)
            {
                case Role.Admin:
                    break;

                case Role.NhanVien:
                    btnNhanVien.Visible = false;
                    btnBangGia.Visible = false;
                    btnTramDien.Visible = false;
                    break;

                case Role.KeToan:
                    btnNhanVien.Visible = false;
                    btnKhachHang.Visible = false;
                    btnHoaDon.Visible = false;
                    btnBangGia.Visible = false;
                    btnTramDien.Visible = false;
                    break;
            }
        }

        private void btnNhanVien_Click(object sender, EventArgs e) => new FormNhanVien().ShowDialog();

        private void btnKhachHang_Click(object sender, EventArgs e) => new FormKhachHang().ShowDialog();

        private void btnHoaDon_Click(object sender, EventArgs e) => new FormHoaDon().ShowDialog();

        private void btnBaoCao_Click(object sender, EventArgs e) => new FormBaoCao().ShowDialog();

        private void btnBangGia_Click(object sender, EventArgs e) => new FormBangGia().ShowDialog();

        private void btnTramDien_Click(object sender, EventArgs e) => new FormTramDien().ShowDialog();

        private void btnCongToDien_Click(object sender, EventArgs e)
        {
            new FormCongToDien().ShowDialog();
        }

        private void btnChiSoDien_Click(object sender, EventArgs e)
        {
            new FormChiSoDien().ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();

                FormDangNhap formDangNhap = new FormDangNhap();
                formDangNhap.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}