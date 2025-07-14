using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QLTDN5.Data;
using QLTDN5.Entities;

namespace QLTDN5.WinForms.Forms
{
    public partial class FormCongToDien : Form
    {
        private QLTDN5Context db = new QLTDN5Context();
        private DataGridView dgvCongTo;
        private TextBox txtMaCongTo, txtSoSerial, txtMaKH;
        private ComboBox cboTrangThai;
        private Button btnThem, btnSua, btnXoa;
        private Label lblTitle, lblMa, lblSerial, lblKH, lblTrangThai;
        private System.Windows.Forms.TextBox txtKhachHangId;
        private System.Windows.Forms.CheckBox chkTrangThai;
        private Label lblBangGia;
        private System.Windows.Forms.ComboBox cboBangGia;
        private Label lblTramDien;
        private System.Windows.Forms.ComboBox cboTramDien;

        public FormCongToDien()
        {
            InitializeComponent();
            LoadBangGia();
            LoadTramDien();
            LoadData();

            dgvCongTo.CellClick += DgvCongTo_CellClick;
        }

        private void LoadTramDien()
        {
            // Lấy tối đa 10 trạm điện đầu tiên
            var ds = db.TramDiens.OrderBy(t => t.Id).Take(10)
                .Select(t => new { t.Id, t.TenTram })
                .ToList();
            cboTramDien.DataSource = ds;
            cboTramDien.DisplayMember = "TenTram";
            cboTramDien.ValueMember = "Id";
        }

        private void InitializeComponent()
        {
            txtKhachHangId = new TextBox();
            chkTrangThai = new CheckBox();
            cboBangGia = new ComboBox();
            lblBangGia = new Label();
            lblTitle = new Label();
            dgvCongTo = new DataGridView();
            lblMa = new Label();
            txtMaCongTo = new TextBox();
            lblSerial = new Label();
            txtSoSerial = new TextBox();
            lblKH = new Label();
            txtMaKH = new TextBox();
            lblTrangThai = new Label();
            cboTrangThai = new ComboBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            lblTramDien = new Label();
            cboTramDien = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvCongTo).BeginInit();
            SuspendLayout();
            // 
            // txtKhachHangId
            // 
            txtKhachHangId.Location = new Point(0, 0);
            txtKhachHangId.Name = "txtKhachHangId";
            txtKhachHangId.Size = new Size(100, 31);
            txtKhachHangId.TabIndex = 0;
            // 
            // chkTrangThai
            // 
            chkTrangThai.Location = new Point(0, 0);
            chkTrangThai.Name = "chkTrangThai";
            chkTrangThai.Size = new Size(104, 24);
            chkTrangThai.TabIndex = 0;
            // 
            // cboBangGia
            // 
            cboBangGia.Location = new Point(730, 441);
            cboBangGia.Name = "cboBangGia";
            cboBangGia.Size = new Size(150, 33);
            cboBangGia.TabIndex = 1;
            // 
            // lblBangGia
            // 
            lblBangGia.Location = new Point(635, 444);
            lblBangGia.Name = "lblBangGia";
            lblBangGia.Size = new Size(89, 30);
            lblBangGia.TabIndex = 0;
            lblBangGia.Text = "Bậc Giá:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(320, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(327, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Danh sách công tơ điện";
            // 
            // dgvCongTo
            // 
            dgvCongTo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCongTo.ColumnHeadersHeight = 34;
            dgvCongTo.Location = new Point(30, 100);
            dgvCongTo.Name = "dgvCongTo";
            dgvCongTo.ReadOnly = true;
            dgvCongTo.RowHeadersWidth = 62;
            dgvCongTo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCongTo.Size = new Size(820, 291);
            dgvCongTo.TabIndex = 1;
            // 
            // lblMa
            // 
            lblMa.Location = new Point(30, 430);
            lblMa.Name = "lblMa";
            lblMa.Size = new Size(114, 28);
            lblMa.TabIndex = 2;
            lblMa.Text = "Mã Công Tơ:";
            // 
            // txtMaCongTo
            // 
            txtMaCongTo.Location = new Point(150, 427);
            txtMaCongTo.Name = "txtMaCongTo";
            txtMaCongTo.Size = new Size(150, 31);
            txtMaCongTo.TabIndex = 3;
            // 
            // lblSerial
            // 
            lblSerial.Location = new Point(330, 430);
            lblSerial.Name = "lblSerial";
            lblSerial.Size = new Size(100, 23);
            lblSerial.TabIndex = 4;
            lblSerial.Text = "Số Serial:";
            // 
            // txtSoSerial
            // 
            txtSoSerial.Location = new Point(430, 427);
            txtSoSerial.Name = "txtSoSerial";
            txtSoSerial.Size = new Size(150, 31);
            txtSoSerial.TabIndex = 5;
            // 
            // lblKH
            // 
            lblKH.Location = new Point(30, 480);
            lblKH.Name = "lblKH";
            lblKH.Size = new Size(100, 23);
            lblKH.TabIndex = 6;
            lblKH.Text = "Mã KH:";
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(150, 477);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(150, 31);
            txtMaKH.TabIndex = 7;
            // 
            // lblTrangThai
            // 
            lblTrangThai.Location = new Point(330, 480);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(100, 41);
            lblTrangThai.TabIndex = 8;
            lblTrangThai.Text = "Trạng thái:";
            // 
            // cboTrangThai
            // 
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.Items.AddRange(new object[] { "Đang hoạt động", "Ngừng hoạt động" });
            cboTrangThai.Location = new Point(430, 477);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(150, 33);
            cboTrangThai.TabIndex = 9;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(602, 480);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(80, 35);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.Click += BtnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(699, 480);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(80, 35);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.Click += BtnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(800, 480);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(80, 35);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.Click += BtnXoa_Click;
            // 
            // lblTramDien
            // 
            lblTramDien.Location = new Point(635, 400);
            lblTramDien.Name = "lblTramDien";
            lblTramDien.Size = new Size(89, 30);
            lblTramDien.TabIndex = 0;
            lblTramDien.Text = "Trạm điện:";
            lblTramDien.Click += lblTramDien_Click;
            // 
            // cboTramDien
            // 
            cboTramDien.Location = new Point(730, 397);
            cboTramDien.Name = "cboTramDien";
            cboTramDien.Size = new Size(150, 33);
            cboTramDien.TabIndex = 1;
            // 
            // FormCongToDien
            // 
            ClientSize = new Size(920, 522);
            Controls.Add(lblTramDien);
            Controls.Add(cboTramDien);
            Controls.Add(lblBangGia);
            Controls.Add(cboBangGia);
            Controls.Add(lblTitle);
            Controls.Add(dgvCongTo);
            Controls.Add(lblMa);
            Controls.Add(txtMaCongTo);
            Controls.Add(lblSerial);
            Controls.Add(txtSoSerial);
            Controls.Add(lblKH);
            Controls.Add(txtMaKH);
            Controls.Add(lblTrangThai);
            Controls.Add(cboTrangThai);
            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Name = "FormCongToDien";
            Text = "Quản lý công tơ điện";
            ((System.ComponentModel.ISupportInitialize)dgvCongTo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void LoadBangGia()
        {
            var ds = db.BangGiaDiens
                .Select(bg => new
                {
                    bg.Id,
                    DisplayText = bg.TenBac + " (Giá " + bg.DonGia + ")"
                })
                .ToList();

            cboBangGia.DataSource = ds;
            cboBangGia.DisplayMember = "DisplayText";
            cboBangGia.ValueMember = "Id";
        }

        private void LoadData()
        {
            var data = db.CongToDiens
                .Select(ct => new
                {
                    ct.MaCongTo,
                    ct.SoSerial,
                    ct.KhachHangId,
                    TenTram = ct.TramDien != null ? ct.TramDien.TenTram : "",
                    TenBac = ct.BangGia.TenBac,
                    TrangThai = ct.TrangThai ? "Đang hoạt động" : "Ngừng hoạt động"
                })
                .ToList();

            dgvCongTo.DataSource = data;
        }

        private void DgvCongTo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCongTo.Rows[e.RowIndex];

                txtMaCongTo.Text = row.Cells["MaCongTo"].Value?.ToString();
                txtSoSerial.Text = row.Cells["SoSerial"].Value?.ToString();
                txtKhachHangId.Text = row.Cells["KhachHangId"].Value?.ToString();

                string trangThai = row.Cells["TrangThai"].Value?.ToString();
                chkTrangThai.Checked = trangThai == "Đang hoạt động";

                if (row.Cells["TenBac"].Value != null)
                {
                    string tenBac = row.Cells["TenBac"].Value.ToString();
                    cboBangGia.SelectedIndex = cboBangGia.FindStringExact(tenBac);
                }

                if (row.Cells["TenTram"].Value != null)
                {
                    string tenTram = row.Cells["TenTram"].Value.ToString();
                    cboTramDien.SelectedIndex = cboTramDien.FindStringExact(tenTram);
                }
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMaKH.Text, out int khId))
            {
                MessageBox.Show("Mã khách hàng phải là số nguyên.");
                return;
            }

            var exists = db.CongToDiens.Any(c => c.MaCongTo == txtMaCongTo.Text);
            if (exists)
            {
                MessageBox.Show("Mã công tơ đã tồn tại.");
                return;
            }

            var ct = new CongToDien
            {
                MaCongTo = txtMaCongTo.Text,
                SoSerial = txtSoSerial.Text,
                KhachHangId = khId,
                TrangThai = cboTrangThai.SelectedItem.ToString() == "Đang hoạt động",
                BangGiaId = (int)cboBangGia.SelectedValue,
                TramDienId = (int)cboTramDien.SelectedValue
            };

            db.CongToDiens.Add(ct);
            db.SaveChanges();
            LoadData();
            ClearInputs();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMaKH.Text, out int khId))
            {
                MessageBox.Show("Mã khách hàng phải là số nguyên.");
                return;
            }

            var ct = db.CongToDiens.FirstOrDefault(c => c.MaCongTo == txtMaCongTo.Text);
            if (ct != null)
            {
                ct.SoSerial = txtSoSerial.Text;
                ct.KhachHangId = khId;
                ct.TrangThai = cboTrangThai.SelectedItem.ToString() == "Đang hoạt động";
                ct.BangGiaId = (int)cboBangGia.SelectedValue;
                ct.TramDienId = (int)cboTramDien.SelectedValue;

                db.SaveChanges();
                LoadData();
                ClearInputs();
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            var ct = db.CongToDiens.FirstOrDefault(c => c.MaCongTo == txtMaCongTo.Text);
            if (ct != null)
            {
                db.CongToDiens.Remove(ct);
                db.SaveChanges();
                LoadData();
                ClearInputs();
            }
        }

        private void ClearInputs()
        {
            txtMaCongTo.Text = "";
            txtSoSerial.Text = "";
            txtMaKH.Text = "";
            cboTrangThai.SelectedIndex = -1;
        }

        private void lblTramDien_Click(object sender, EventArgs e)
        {

        }
    }
}