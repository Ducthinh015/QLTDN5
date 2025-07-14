using System;
using System.Linq;
using System.Windows.Forms;
using QLTDN5.Data;
using QLTDN5.Entities;

namespace QLTDN5.WinForms.Forms
{
    public partial class FormBangGia : Form
    {
        private QLTDN5Context db = new QLTDN5Context();

        private DataGridView dgvBangGia;
        private TextBox txtMaBac, txtTenBac, txtDonGia, txtMoTa, txtMucDien, txtMaGia;
        private Button btnThem, btnSua, btnXoa;
        private Label label;
        private Label lblDonGia, lblMoTa, lblMaBac, lblTenBac, lblMucDien, lblMaGia;

        public FormBangGia()
        {
            InitializeComponent();
            InitDataGridView();
            LoadData();
            dgvBangGia.CellClick += DgvBangGia_CellClick;
        }

        private void InitializeComponent()
        {
            label = new Label();
            dgvBangGia = new DataGridView();
            txtMaBac = new TextBox();
            txtTenBac = new TextBox();
            txtDonGia = new TextBox();
            txtMoTa = new TextBox();
            txtMucDien = new TextBox();
            txtMaGia = new TextBox();
            lblMaBac = new Label();
            lblTenBac = new Label();
            lblDonGia = new Label();
            lblMoTa = new Label();
            lblMucDien = new Label();
            lblMaGia = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBangGia).BeginInit();
            SuspendLayout();
            //
            // label
            //
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            label.Location = new System.Drawing.Point(320, 20);
            label.Name = "label";
            label.Size = new System.Drawing.Size(198, 38);
            label.TabIndex = 0;
            label.Text = "Bảng giá điện";
            //
            // dgvBangGia
            //
            dgvBangGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBangGia.ColumnHeadersHeight = 34;
            dgvBangGia.Location = new System.Drawing.Point(30, 70);
            dgvBangGia.Name = "dgvBangGia";
            dgvBangGia.ReadOnly = true;
            dgvBangGia.RowHeadersWidth = 62;
            dgvBangGia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBangGia.Size = new System.Drawing.Size(820, 250);
            dgvBangGia.TabIndex = 1;
            //
            // txtMaBac
            //
            txtMaBac.Location = new System.Drawing.Point(130, 337);
            txtMaBac.Name = "txtMaBac";
            txtMaBac.Size = new System.Drawing.Size(200, 31);
            txtMaBac.TabIndex = 3;
            //
            // txtTenBac
            //
            txtTenBac.Location = new System.Drawing.Point(470, 337);
            txtTenBac.Name = "txtTenBac";
            txtTenBac.Size = new System.Drawing.Size(200, 31);
            txtTenBac.TabIndex = 5;
            //
            // txtDonGia
            //
            txtDonGia.Location = new System.Drawing.Point(130, 377);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new System.Drawing.Size(200, 31);
            txtDonGia.TabIndex = 7;
            //
            // txtMoTa
            //
            txtMoTa.Location = new System.Drawing.Point(470, 377);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new System.Drawing.Size(200, 31);
            txtMoTa.TabIndex = 9;
            //
            // txtMucDien
            //
            txtMucDien.Location = new System.Drawing.Point(130, 417);
            txtMucDien.Name = "txtMucDien";
            txtMucDien.Size = new System.Drawing.Size(200, 31);
            txtMucDien.TabIndex = 11;
            //
            // txtMaGia
            //
            txtMaGia = new TextBox();
            txtMaGia.Location = new System.Drawing.Point(470, 417);
            txtMaGia.Name = "txtMaGia";
            txtMaGia.Size = new System.Drawing.Size(200, 31);

            //
            // lblMaBac
            //
            lblMaBac.Location = new System.Drawing.Point(30, 340);
            lblMaBac.Name = "lblMaBac";
            lblMaBac.Size = new System.Drawing.Size(100, 23);
            lblMaBac.TabIndex = 2;
            lblMaBac.Text = "Mã Bậc:";
            //
            // lblTenBac
            //
            lblTenBac.Location = new System.Drawing.Point(380, 340);
            lblTenBac.Name = "lblTenBac";
            lblTenBac.Size = new System.Drawing.Size(84, 23);
            lblTenBac.TabIndex = 4;
            lblTenBac.Text = "Tên Bậc:";
            //
            // lblDonGia
            //
            lblDonGia.Location = new System.Drawing.Point(30, 380);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new System.Drawing.Size(100, 23);
            lblDonGia.TabIndex = 6;
            lblDonGia.Text = "Đơn Giá:";
            //
            // lblMoTa
            //
            lblMoTa.Location = new System.Drawing.Point(380, 380);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new System.Drawing.Size(84, 23);
            lblMoTa.TabIndex = 8;
            lblMoTa.Text = "Mô Tả:";
            //
            // lblMucDien
            //
            lblMucDien.Location = new System.Drawing.Point(30, 420);
            lblMucDien.Name = "lblMucDien";
            lblMucDien.Size = new System.Drawing.Size(94, 23);
            lblMucDien.TabIndex = 10;
            lblMucDien.Text = "Mức điện:";
            //
            // lblMaGia
            //
            lblMaGia.Location = new System.Drawing.Point(380, 420);
            lblMaGia.Name = "lblMaGia";
            lblMaGia.Size = new System.Drawing.Size(84, 23);
            lblMaGia.Text = "Mã Giá:";

            //
            // btnThem
            //
            btnThem.Location = new System.Drawing.Point(130, 470);
            btnThem.Name = "btnThem";
            btnThem.Size = new System.Drawing.Size(75, 34);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.Click += BtnThem_Click;

            //
            // btnSua
            //
            btnSua.Location = new System.Drawing.Point(270, 470);
            btnSua.Name = "btnSua";
            btnSua.Size = new System.Drawing.Size(75, 34);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.Click += BtnSua_Click;
            //
            // btnXoa
            //
            btnXoa.Location = new System.Drawing.Point(410, 470);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new System.Drawing.Size(75, 34);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.Click += BtnXoa_Click;
            //
            // FormBangGia
            //
            ClientSize = new System.Drawing.Size(878, 530);
            Controls.Add(label);
            Controls.Add(dgvBangGia);
            Controls.Add(lblMaBac);
            Controls.Add(txtMaBac);
            Controls.Add(lblTenBac);
            Controls.Add(txtTenBac);
            Controls.Add(lblDonGia);
            Controls.Add(txtDonGia);
            Controls.Add(lblMoTa);
            Controls.Add(txtMoTa);
            Controls.Add(lblMucDien);
            Controls.Add(txtMucDien);
            Controls.Add(lblMaGia);
            Controls.Add(txtMaGia);

            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Name = "FormBangGia";
            Text = "Bảng giá điện";
            ((System.ComponentModel.ISupportInitialize)dgvBangGia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void InitDataGridView()
        {
            dgvBangGia.Columns.Clear();
            dgvBangGia.AutoGenerateColumns = false;

            dgvBangGia.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Mã Bậc",
                DataPropertyName = "MaBac"
            });
            dgvBangGia.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Tên Bậc",
                DataPropertyName = "TenBac"
            });
            dgvBangGia.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Đơn Giá",
                DataPropertyName = "DonGia"
            });
            dgvBangGia.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Mô Tả",
                DataPropertyName = "MoTa"
            });
            dgvBangGia.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Mức Điện",
                DataPropertyName = "MucDien"
            });

            dgvBangGia.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Mã Giá",
                DataPropertyName = "MaGia"
            });
        }

        private void LoadData()
        {
            dgvBangGia.DataSource = db.BangGiaDiens.Select(bg => new
            {
                bg.MaBac,
                bg.TenBac,
                bg.DonGia,
                bg.MoTa,
                bg.MucDien,
                bg.MaGia
            }).ToList();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaBac.Text) || string.IsNullOrWhiteSpace(txtDonGia.Text) || string.IsNullOrWhiteSpace(txtMucDien.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc.");
                    return;
                }

                if (!decimal.TryParse(txtDonGia.Text, out decimal donGia))
                {
                    MessageBox.Show("Đơn giá phải là số hợp lệ.");
                    return;
                }

                var bg = new BangGia
                {
                    MaBac = txtMaBac.Text,
                    TenBac = txtTenBac.Text,
                    DonGia = donGia,
                    MoTa = txtMoTa.Text,
                    MucDien = txtMucDien.Text,
                    MaGia = string.IsNullOrWhiteSpace(txtMaGia.Text) ? 0 : int.Parse(txtMaGia.Text)
                };

                db.BangGiaDiens.Add(bg);
                db.SaveChanges();
                LoadData();
                ClearInputs();
                MessageBox.Show("Đã thêm thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (dgvBangGia.CurrentRow != null)
            {
                var maBac = dgvBangGia.CurrentRow.Cells[0].Value.ToString();
                var bg = db.BangGiaDiens.FirstOrDefault(x => x.MaBac == maBac);
                if (bg != null)
                {
                    bg.TenBac = txtTenBac.Text;
                    bg.DonGia = decimal.TryParse(txtDonGia.Text, out var donGia) ? donGia : 0;
                    bg.MoTa = txtMoTa.Text;
                    bg.MucDien = txtMucDien.Text;
                    bg.MaGia = int.TryParse(txtMaGia.Text, out var maGia) ? maGia : 0;

                    db.SaveChanges();
                    LoadData();
                    ClearInputs();
                    MessageBox.Show("Cập nhật thành công.");
                }
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (dgvBangGia.CurrentRow != null)
            {
                var maBac = dgvBangGia.CurrentRow.Cells[0].Value.ToString();
                var bg = db.BangGiaDiens.FirstOrDefault(x => x.MaBac == maBac);
                if (bg != null)
                {
                    db.BangGiaDiens.Remove(bg);
                    db.SaveChanges();
                    LoadData();
                    ClearInputs();
                    MessageBox.Show("Đã xóa thành công.");
                }
            }
        }

        private void DgvBangGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBangGia.CurrentRow != null)
            {
                txtMaBac.Text = dgvBangGia.CurrentRow.Cells[0].Value?.ToString();
                txtTenBac.Text = dgvBangGia.CurrentRow.Cells[1].Value?.ToString();
                txtDonGia.Text = dgvBangGia.CurrentRow.Cells[2].Value?.ToString();
                txtMoTa.Text = dgvBangGia.CurrentRow.Cells[3].Value?.ToString();
                txtMucDien.Text = dgvBangGia.CurrentRow.Cells[4].Value?.ToString();
                txtMaGia.Text = dgvBangGia.CurrentRow.Cells[5].Value?.ToString();
            }
        }

        private void ClearInputs()
        {
            txtMaBac.Text = "";
            txtTenBac.Text = "";
            txtDonGia.Text = "";
            txtMoTa.Text = "";
            txtMucDien.Text = "";
        }
    }
}