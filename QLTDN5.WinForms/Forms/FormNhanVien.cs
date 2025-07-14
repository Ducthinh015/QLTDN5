using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QLTDN5.Data;
using QLTDN5.Entities;

namespace QLTDN5.WinForms.Forms
{
    public partial class FormNhanVien : Form
    {
        private QLTDN5Context db = new QLTDN5Context();
        private DataGridView dgvNhanVien;
        private TextBox txtMaNV, txtTenNV, txtVaiTro, txtDienThoai, txtEmail, txtTaiKhoan, txtMatKhau;
        private Button btnThem, btnSua, btnXoa;
        private Label lblTitle, lblMaNV, lblTenNV, lblVaiTro, lblDT, lblEmail, lblTaiKhoan, lblMatKhau;

        public FormNhanVien()
        {
            InitializeComponent();
            LoadData();
            dgvNhanVien.CellClick += DgvNhanVien_CellClick;
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            dgvNhanVien = new DataGridView();
            lblMaNV = new Label();
            txtMaNV = new TextBox();
            lblTenNV = new Label();
            txtTenNV = new TextBox();
            lblVaiTro = new Label();
            txtVaiTro = new TextBox();
            lblDT = new Label();
            txtDienThoai = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblTaiKhoan = new Label();
            txtTaiKhoan = new TextBox();
            lblMatKhau = new Label();
            txtMatKhau = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(320, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(289, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Danh sách nhân viên";
            //
            // dgvNhanVien
            //
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.ColumnHeadersHeight = 34;
            dgvNhanVien.Location = new Point(30, 70);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.RowHeadersWidth = 62;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.Size = new Size(840, 354);
            dgvNhanVien.TabIndex = 1;
            //
            // lblMaNV
            //
            lblMaNV.Location = new Point(30, 430);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(80, 23);
            lblMaNV.TabIndex = 2;
            lblMaNV.Text = "Mã NV:";
            //
            // txtMaNV
            //
            txtMaNV.Location = new Point(145, 430);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(200, 31);
            txtMaNV.TabIndex = 3;
            //
            // lblTenNV
            //
            lblTenNV.Location = new Point(30, 488);
            lblTenNV.Name = "lblTenNV";
            lblTenNV.Size = new Size(94, 23);
            lblTenNV.TabIndex = 4;
            lblTenNV.Text = "Tên NV:";
            //
            // txtTenNV
            //
            txtTenNV.Location = new Point(145, 480);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(200, 31);
            txtTenNV.TabIndex = 5;
            //
            // lblVaiTro
            //
            lblVaiTro.Location = new Point(560, 438);
            lblVaiTro.Name = "lblVaiTro";
            lblVaiTro.Size = new Size(84, 23);
            lblVaiTro.TabIndex = 6;
            lblVaiTro.Text = "Vai Trò:";
            //
            // txtVaiTro
            //
            txtVaiTro.Location = new Point(670, 430);
            txtVaiTro.Name = "txtVaiTro";
            txtVaiTro.Size = new Size(200, 31);
            txtVaiTro.TabIndex = 7;
            //
            // lblDT
            //
            lblDT.Location = new Point(560, 483);
            lblDT.Name = "lblDT";
            lblDT.Size = new Size(84, 23);
            lblDT.TabIndex = 8;
            lblDT.Text = "SĐT:";
            //
            // txtDienThoai
            //
            txtDienThoai.Location = new Point(670, 480);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(200, 31);
            txtDienThoai.TabIndex = 9;
            //
            // lblEmail
            //
            lblEmail.Location = new Point(30, 534);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(80, 23);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email:";
            //
            // txtEmail
            //
            txtEmail.Location = new Point(145, 531);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 31);
            txtEmail.TabIndex = 11;
            //
            // lblTaiKhoan
            //
            lblTaiKhoan.Location = new Point(560, 531);
            lblTaiKhoan.Name = "lblTaiKhoan";
            lblTaiKhoan.Size = new Size(104, 23);
            lblTaiKhoan.TabIndex = 12;
            lblTaiKhoan.Text = "Tài khoản:";
            //
            // txtTaiKhoan
            //
            txtTaiKhoan.Location = new Point(670, 523);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(200, 31);
            txtTaiKhoan.TabIndex = 13;
            //
            // lblMatKhau
            //
            lblMatKhau.Location = new Point(26, 584);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(98, 23);
            lblMatKhau.TabIndex = 14;
            lblMatKhau.Text = "Mật khẩu:";
            //
            // txtMatKhau
            //
            txtMatKhau.Location = new Point(145, 581);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(200, 31);
            txtMatKhau.TabIndex = 15;
            //
            // btnThem
            //
            btnThem.Location = new Point(560, 581);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 38);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.Click += BtnThem_Click;
            //
            // btnSua
            //
            btnSua.Location = new Point(684, 581);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 38);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.Click += BtnSua_Click;
            //
            // btnXoa
            //
            btnXoa.Location = new Point(795, 581);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 38);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.Click += BtnXoa_Click;
            //
            // FormNhanVien
            //
            ClientSize = new Size(900, 640);
            Controls.Add(lblTitle);
            Controls.Add(dgvNhanVien);
            Controls.Add(lblMaNV);
            Controls.Add(txtMaNV);
            Controls.Add(lblTenNV);
            Controls.Add(txtTenNV);
            Controls.Add(lblVaiTro);
            Controls.Add(txtVaiTro);
            Controls.Add(lblDT);
            Controls.Add(txtDienThoai);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblTaiKhoan);
            Controls.Add(txtTaiKhoan);
            Controls.Add(lblMatKhau);
            Controls.Add(txtMatKhau);
            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Name = "FormNhanVien";
            Text = "Quản lý danh sách nhân viên";
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void LoadData()
        {
            var data = db.NhanViens
                .Select(nv => new
                {
                    nv.MaNV,
                    nv.TenNV,
                    nv.VaiTro,
                    nv.DienThoai,
                    nv.Email,
                    nv.TaiKhoan
                })
                .ToList();

            dgvNhanVien.DataSource = data;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text) ||
                string.IsNullOrWhiteSpace(txtTenNV.Text) ||
                string.IsNullOrWhiteSpace(txtVaiTro.Text) ||
                string.IsNullOrWhiteSpace(txtDienThoai.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtTaiKhoan.Text) ||
                string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var existing = db.NhanViens.FirstOrDefault(x => x.MaNV == txtMaNV.Text);
            if (existing != null)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var nv = new NhanVien
            {
                MaNV = txtMaNV.Text,
                TenNV = txtTenNV.Text,
                VaiTro = txtVaiTro.Text,
                DienThoai = txtDienThoai.Text,
                Email = txtEmail.Text,
                TaiKhoan = txtTaiKhoan.Text,
                MatKhau = txtMatKhau.Text
            };

            db.NhanViens.Add(nv);
            db.SaveChanges();
            LoadData();
            ClearInputs();

            MessageBox.Show("Đã thêm nhân viên thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null) return;

            string ma = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            var nv = db.NhanViens.FirstOrDefault(x => x.MaNV == ma);
            if (nv != null)
            {
                nv.TenNV = txtTenNV.Text;
                nv.VaiTro = txtVaiTro.Text;
                nv.DienThoai = txtDienThoai.Text;
                nv.Email = txtEmail.Text;
                nv.TaiKhoan = txtTaiKhoan.Text;
                nv.MatKhau = txtMatKhau.Text;
                db.SaveChanges();
                LoadData();
                ClearInputs();
                MessageBox.Show("Cập nhật thông tin thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null) return;

            string ma = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            var nv = db.NhanViens.FirstOrDefault(x => x.MaNV == ma);
            if (nv != null)
            {
                var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    db.NhanViens.Remove(nv);
                    db.SaveChanges();
                    LoadData();
                    ClearInputs();
                    MessageBox.Show("Xóa thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ClearInputs()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtVaiTro.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
        }

        private void DgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNhanVien.CurrentRow != null)
            {
                txtMaNV.Text = dgvNhanVien.CurrentRow.Cells[0].Value?.ToString();
                txtTenNV.Text = dgvNhanVien.CurrentRow.Cells[1].Value?.ToString();
                txtVaiTro.Text = dgvNhanVien.CurrentRow.Cells[2].Value?.ToString();
                txtDienThoai.Text = dgvNhanVien.CurrentRow.Cells[3].Value?.ToString();
                txtEmail.Text = dgvNhanVien.CurrentRow.Cells[4].Value?.ToString();
                txtTaiKhoan.Text = dgvNhanVien.CurrentRow.Cells[5].Value?.ToString();
            }
        }
    }
}