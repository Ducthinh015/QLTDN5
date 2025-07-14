using System;
using System.Linq;
using System.Windows.Forms;
using QLTDN5.Data;
using QLTDN5.Entities;

namespace QLTDN5.WinForms.Forms
{
    public partial class FormKhachHang : Form
    {
        private QLTDN5Context db = new QLTDN5Context();
        private int? selectedId = null;

        private Label lblTitle, lblSearch, lblMaKH, lblTenKH, lblDiaChi, lblDT;
        private Label lblCCCD, lblEmail, lblMST, lblGhiChu;
        private TextBox txtMaKH, txtTenKH, txtDiaChi, txtDienThoai, txtTimKiem;
        private TextBox txtCCCD, txtEmail, txtMST, txtGhiChu;
        private Button btnThem, btnSua, btnXoa;
        private DataGridView dgvKhachHang;

        public FormKhachHang()
        {
            InitializeComponent();
            LoadData();
            dgvKhachHang.CellClick += dgvKhachHang_CellClick;
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblSearch = new Label();
            txtTimKiem = new TextBox();
            dgvKhachHang = new DataGridView();
            lblMaKH = new Label();
            txtMaKH = new TextBox();
            lblTenKH = new Label();
            txtTenKH = new TextBox();
            lblDiaChi = new Label();
            txtDiaChi = new TextBox();
            lblDT = new Label();
            txtDienThoai = new TextBox();
            lblCCCD = new Label();
            txtCCCD = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblMST = new Label();
            txtMST = new TextBox();
            lblGhiChu = new Label();
            txtGhiChu = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            //
            // lblTitle
            //
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(292, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(363, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Danh sách khách hàng";
            //
            // lblSearch
            //
            lblSearch.Location = new System.Drawing.Point(30, 70);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new System.Drawing.Size(94, 23);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Tìm kiếm:";
            //
            // txtTimKiem
            //
            txtTimKiem.Location = new System.Drawing.Point(145, 67);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new System.Drawing.Size(300, 31);
            txtTimKiem.TabIndex = 2;
            txtTimKiem.TextChanged += TxtTimKiem_TextChanged;
            //
            // dgvKhachHang
            //
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.ColumnHeadersHeight = 34;
            dgvKhachHang.Location = new System.Drawing.Point(30, 110);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.ReadOnly = true;
            dgvKhachHang.RowHeadersWidth = 62;
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.Size = new System.Drawing.Size(820, 250);
            dgvKhachHang.TabIndex = 3;
            //
            // lblMaKH
            //
            lblMaKH.Location = new System.Drawing.Point(30, 380);
            lblMaKH.Name = "lblMaKH";
            lblMaKH.Size = new System.Drawing.Size(80, 23);
            lblMaKH.TabIndex = 4;
            lblMaKH.Text = "Mã KH:";
            //
            // txtMaKH
            //
            txtMaKH.Location = new System.Drawing.Point(130, 377);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.ReadOnly = true;
            txtMaKH.Size = new System.Drawing.Size(162, 31);
            txtMaKH.TabIndex = 5;
            //
            // lblTenKH
            //
            lblTenKH.Location = new System.Drawing.Point(30, 420);
            lblTenKH.Name = "lblTenKH";
            lblTenKH.Size = new System.Drawing.Size(80, 23);
            lblTenKH.TabIndex = 6;
            lblTenKH.Text = "Tên KH:";
            //
            // txtTenKH
            //
            txtTenKH.Location = new System.Drawing.Point(130, 417);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new System.Drawing.Size(162, 31);
            txtTenKH.TabIndex = 7;
            //
            // lblDiaChi
            //
            lblDiaChi.Location = new System.Drawing.Point(319, 377);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new System.Drawing.Size(84, 23);
            lblDiaChi.TabIndex = 8;
            lblDiaChi.Text = "Địa chỉ:";
            //
            // txtDiaChi
            //
            txtDiaChi.Location = new System.Drawing.Point(409, 375);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new System.Drawing.Size(157, 31);
            txtDiaChi.TabIndex = 9;
            //
            // lblDT
            //
            lblDT.Location = new System.Drawing.Point(319, 417);
            lblDT.Name = "lblDT";
            lblDT.Size = new System.Drawing.Size(84, 23);
            lblDT.TabIndex = 10;
            lblDT.Text = "SĐT:";
            //
            // txtDienThoai
            //
            txtDienThoai.Location = new System.Drawing.Point(409, 417);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new System.Drawing.Size(157, 31);
            txtDienThoai.TabIndex = 11;
            //
            // lblCCCD
            //
            lblCCCD.Location = new System.Drawing.Point(602, 378);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new System.Drawing.Size(80, 23);
            lblCCCD.TabIndex = 0;
            lblCCCD.Text = "CCCD:";
            //
            // txtCCCD
            //
            txtCCCD.Location = new System.Drawing.Point(688, 377);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new System.Drawing.Size(162, 31);
            txtCCCD.TabIndex = 1;
            //
            // lblEmail
            //
            lblEmail.Location = new System.Drawing.Point(323, 460);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(80, 23);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            //
            // txtEmail
            //
            txtEmail.Location = new System.Drawing.Point(409, 457);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(157, 31);
            txtEmail.TabIndex = 3;
            //
            // lblMST
            //
            lblMST.Location = new System.Drawing.Point(602, 420);
            lblMST.Name = "lblMST";
            lblMST.Size = new System.Drawing.Size(80, 23);
            lblMST.TabIndex = 4;
            lblMST.Text = "Mã số thuế:";
            //
            // txtMST
            //
            txtMST.Location = new System.Drawing.Point(688, 420);
            txtMST.Name = "txtMST";
            txtMST.Size = new System.Drawing.Size(162, 31);
            txtMST.TabIndex = 5;
            //
            // lblGhiChu
            //
            lblGhiChu.Location = new System.Drawing.Point(30, 465);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new System.Drawing.Size(80, 23);
            lblGhiChu.TabIndex = 6;
            lblGhiChu.Text = "Ghi chú:";
            //
            // txtGhiChu
            //
            txtGhiChu.Location = new System.Drawing.Point(130, 460);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new System.Drawing.Size(162, 31);
            txtGhiChu.TabIndex = 7;
            //
            // btnThem
            //
            btnThem.Location = new System.Drawing.Point(602, 470);
            btnThem.Name = "btnThem";
            btnThem.Size = new System.Drawing.Size(75, 41);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            //
            // btnSua
            //
            btnSua.Location = new System.Drawing.Point(688, 470);
            btnSua.Name = "btnSua";
            btnSua.Size = new System.Drawing.Size(75, 41);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;
            //
            // btnXoa
            //
            btnXoa.Location = new System.Drawing.Point(775, 470);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new System.Drawing.Size(75, 41);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            //
            // FormKhachHang
            //
            ClientSize = new System.Drawing.Size(900, 530);
            Controls.Add(lblCCCD);
            Controls.Add(txtCCCD);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblMST);
            Controls.Add(txtMST);
            Controls.Add(lblGhiChu);
            Controls.Add(txtGhiChu);
            Controls.Add(lblTitle);
            Controls.Add(lblSearch);
            Controls.Add(txtTimKiem);
            Controls.Add(dgvKhachHang);
            Controls.Add(lblMaKH);
            Controls.Add(txtMaKH);
            Controls.Add(lblTenKH);
            Controls.Add(txtTenKH);
            Controls.Add(lblDiaChi);
            Controls.Add(txtDiaChi);
            Controls.Add(lblDT);
            Controls.Add(txtDienThoai);
            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Name = "FormKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý thông tin khách hàng";
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void LoadData()
        {
            var data = db.KhachHangs
                .Select(kh => new
                {
                    kh.Id,
                    kh.MaKH,
                    kh.TenKhachHang,
                    kh.DiaChi,
                    kh.SoDienThoai,
                    kh.CCCD,
                    kh.Email,
                    kh.MaSoThue,
                    kh.GhiChu
                }).ToList();

            dgvKhachHang.DataSource = data;
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKhachHang.CurrentRow != null)
            {
                selectedId = Convert.ToInt32(dgvKhachHang.CurrentRow.Cells[0].Value);
                txtMaKH.Text = dgvKhachHang.CurrentRow.Cells[1].Value?.ToString();
                txtTenKH.Text = dgvKhachHang.CurrentRow.Cells[2].Value?.ToString();
                txtDiaChi.Text = dgvKhachHang.CurrentRow.Cells[3].Value?.ToString();
                txtDienThoai.Text = dgvKhachHang.CurrentRow.Cells[4].Value?.ToString();
                txtCCCD.Text = dgvKhachHang.CurrentRow.Cells[5].Value?.ToString();
                txtEmail.Text = dgvKhachHang.CurrentRow.Cells[6].Value?.ToString();
                txtMST.Text = dgvKhachHang.CurrentRow.Cells[7].Value?.ToString();
                txtGhiChu.Text = dgvKhachHang.CurrentRow.Cells[8].Value?.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKH.Text) || string.IsNullOrWhiteSpace(txtDiaChi.Text) || string.IsNullOrWhiteSpace(txtDienThoai.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var kh = new KhachHang
            {
                MaKH = "KH" + DateTime.Now.Ticks,
                TenKhachHang = txtTenKH.Text,
                DiaChi = txtDiaChi.Text,
                SoDienThoai = txtDienThoai.Text,
                CCCD = txtCCCD.Text,
                Email = txtEmail.Text,
                MaSoThue = txtMST.Text,
                GhiChu = txtGhiChu.Text
            };
            db.KhachHangs.Add(kh);
            db.SaveChanges();
            LoadData();
            ClearInputs();
            MessageBox.Show("Đã thêm khách hàng thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectedId.HasValue)
            {
                var kh = db.KhachHangs.Find(selectedId.Value);
                if (kh != null)
                {
                    kh.TenKhachHang = txtTenKH.Text;
                    kh.DiaChi = txtDiaChi.Text;
                    kh.SoDienThoai = txtDienThoai.Text;
                    kh.CCCD = txtCCCD.Text;
                    kh.Email = txtEmail.Text;
                    kh.MaSoThue = txtMST.Text;
                    kh.GhiChu = txtGhiChu.Text;

                    db.SaveChanges();
                    LoadData();
                    ClearInputs();
                    MessageBox.Show("Cập nhật thông tin thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedId.HasValue)
            {
                var kh = db.KhachHangs.Find(selectedId.Value);
                if (kh != null)
                {
                    var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        db.KhachHangs.Remove(kh);
                        db.SaveChanges();
                        LoadData();
                        ClearInputs();
                        MessageBox.Show("Xóa thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void TxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.ToLower();
            var filtered = db.KhachHangs
                .Where(kh => kh.TenKhachHang.ToLower().Contains(keyword) || kh.SoDienThoai.Contains(keyword))
                .Select(kh => new
                {
                    kh.Id,
                    kh.MaKH,
                    kh.TenKhachHang,
                    kh.DiaChi,
                    kh.SoDienThoai,
                    kh.CCCD,
                    kh.Email,
                    kh.MaSoThue,
                    kh.GhiChu
                })
                .ToList();

            dgvKhachHang.DataSource = filtered;
        }

        private void ClearInputs()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            selectedId = null;
            txtCCCD.Text = "";
            txtEmail.Text = "";
            txtMST.Text = "";
            txtGhiChu.Text = "";
        }
    }
}