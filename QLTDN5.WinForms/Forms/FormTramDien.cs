using System;
using System.Linq;
using System.Windows.Forms;
using QLTDN5.Data;
using QLTDN5.Entities;

namespace QLTDN5.WinForms.Forms
{
    public partial class FormTramDien : Form
    {
        private QLTDN5Context db = new QLTDN5Context();
        private DataGridView dgvTram;
        private TextBox txtMaTram, txtTenTram, txtViTri, txtGhiChu;
        private Button btnThem, btnSua, btnXoa;
        private Label lblTitle;
        private Label lblMaTram, lblTenTram, lblViTri, lblGhiChu;

        public FormTramDien()
        {
            InitializeComponent();
            LoadData();
            dgvTram.CellClick += DgvTram_CellClick;
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            dgvTram = new DataGridView();
            lblMaTram = new Label();
            txtMaTram = new TextBox();
            lblTenTram = new Label();
            txtTenTram = new TextBox();
            lblViTri = new Label();
            txtViTri = new TextBox();
            lblGhiChu = new Label();
            txtGhiChu = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTram).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(330, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(289, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Danh sách trạm điện";
            // 
            // dgvTram
            // 
            dgvTram.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTram.ColumnHeadersHeight = 34;
            dgvTram.Location = new System.Drawing.Point(30, 70);
            dgvTram.Name = "dgvTram";
            dgvTram.ReadOnly = true;
            dgvTram.RowHeadersWidth = 62;
            dgvTram.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTram.Size = new System.Drawing.Size(820, 300);
            dgvTram.TabIndex = 1;
            // 
            // lblMaTram
            // 
            lblMaTram.Location = new System.Drawing.Point(30, 390);
            lblMaTram.Name = "lblMaTram";
            lblMaTram.Size = new System.Drawing.Size(94, 23);
            lblMaTram.TabIndex = 2;
            lblMaTram.Text = "Mã Trạm:";
            // 
            // txtMaTram
            // 
            txtMaTram.Location = new System.Drawing.Point(130, 390);
            txtMaTram.Name = "txtMaTram";
            txtMaTram.Size = new System.Drawing.Size(200, 31);
            txtMaTram.TabIndex = 3;
            // 
            // lblTenTram
            // 
            lblTenTram.Location = new System.Drawing.Point(30, 430);
            lblTenTram.Name = "lblTenTram";
            lblTenTram.Size = new System.Drawing.Size(94, 23);
            lblTenTram.TabIndex = 4;
            lblTenTram.Text = "Tên Trạm:";
            // 
            // txtTenTram
            // 
            txtTenTram.Location = new System.Drawing.Point(130, 430);
            txtTenTram.Name = "txtTenTram";
            txtTenTram.Size = new System.Drawing.Size(200, 31);
            txtTenTram.TabIndex = 5;
            // 
            // lblViTri
            // 
            lblViTri.Location = new System.Drawing.Point(380, 390);
            lblViTri.Name = "lblViTri";
            lblViTri.Size = new System.Drawing.Size(73, 23);
            lblViTri.TabIndex = 6;
            lblViTri.Text = "Vị trí:";
            // 
            // txtViTri
            // 
            txtViTri.Location = new System.Drawing.Point(470, 390);
            txtViTri.Name = "txtViTri";
            txtViTri.Size = new System.Drawing.Size(200, 31);
            txtViTri.TabIndex = 7;
            // 
            // lblGhiChu
            // 
            lblGhiChu.Location = new System.Drawing.Point(380, 430);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new System.Drawing.Size(84, 23);
            lblGhiChu.TabIndex = 8;
            lblGhiChu.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new System.Drawing.Point(470, 430);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new System.Drawing.Size(200, 31);
            txtGhiChu.TabIndex = 9;
            // 
            // btnThem
            // 
            btnThem.Location = new System.Drawing.Point(130, 480);
            btnThem.Name = "btnThem";
            btnThem.Size = new System.Drawing.Size(75, 38);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.Click += BtnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new System.Drawing.Point(270, 480);
            btnSua.Name = "btnSua";
            btnSua.Size = new System.Drawing.Size(75, 38);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.Click += BtnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new System.Drawing.Point(410, 480);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new System.Drawing.Size(75, 38);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.Click += BtnXoa_Click;
            // 
            // FormTramDien
            // 
            ClientSize = new System.Drawing.Size(900, 530);
            Controls.Add(lblTitle);
            Controls.Add(dgvTram);
            Controls.Add(lblMaTram);
            Controls.Add(txtMaTram);
            Controls.Add(lblTenTram);
            Controls.Add(txtTenTram);
            Controls.Add(lblViTri);
            Controls.Add(txtViTri);
            Controls.Add(lblGhiChu);
            Controls.Add(txtGhiChu);
            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Name = "FormTramDien";
            Text = "Cấu hình trạm / cột điện";
            ((System.ComponentModel.ISupportInitialize)dgvTram).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void LoadData()
        {
            var data = db.TramDiens.Select(t => new
            {
                t.MaTram,
                t.TenTram,
                t.ViTri,
                t.GhiChu
            }).ToList();
            dgvTram.DataSource = data;
        }

        private void DgvTram_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTram.CurrentRow != null)
            {
                txtMaTram.Text = dgvTram.CurrentRow.Cells[0].Value?.ToString();
                txtTenTram.Text = dgvTram.CurrentRow.Cells[1].Value?.ToString();
                txtViTri.Text = dgvTram.CurrentRow.Cells[2].Value?.ToString();
                txtGhiChu.Text = dgvTram.CurrentRow.Cells[3].Value?.ToString();
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaTram.Text) || string.IsNullOrWhiteSpace(txtTenTram.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã trạm và Tên trạm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var exists = db.TramDiens.Any(t => t.MaTram == txtMaTram.Text);
            if (exists)
            {
                MessageBox.Show("Mã trạm đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var tram = new TramDien
            {
                MaTram = txtMaTram.Text,
                TenTram = txtTenTram.Text,
                ViTri = txtViTri.Text,
                GhiChu = txtGhiChu.Text
            };

            db.TramDiens.Add(tram);
            db.SaveChanges();
            LoadData();
            ClearInputs();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            var ma = txtMaTram.Text;
            var tram = db.TramDiens.FirstOrDefault(t => t.MaTram == ma);
            if (tram != null)
            {
                tram.TenTram = txtTenTram.Text;
                tram.ViTri = txtViTri.Text;
                tram.GhiChu = txtGhiChu.Text;
                db.SaveChanges();
                LoadData();
                ClearInputs();
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            var ma = txtMaTram.Text;
            var tram = db.TramDiens.FirstOrDefault(t => t.MaTram == ma);
            if (tram != null)
            {
                db.TramDiens.Remove(tram);
                db.SaveChanges();
                LoadData();
                ClearInputs();
            }
        }

        private void ClearInputs()
        {
            txtMaTram.Text = "";
            txtTenTram.Text = "";
            txtViTri.Text = "";
            txtGhiChu.Text = "";
        }
    }
}