using QLTDN5.Data;
using QLTDN5.Entities;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QLTDN5.WinForms.Forms
{
    public partial class FormChiSoDien : Form
    {
        private readonly QLTDN5Context db = new QLTDN5Context();

        public FormChiSoDien()
        {
            InitializeComponent();
            LoadData();
            dgvChiSo.CellClick += DgvChiSo_CellClick;
        }

        private Label lblTitle;
        private DataGridView dgvChiSo;
        private Label lblMaKH, lblThang, lblNam, lblCu, lblMoi;
        private TextBox txtMaKH, txtThang, txtNam, txtChiSoCu, txtChiSoMoi;
        private Button btnThem, btnSua, btnXoa;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

        private void InitializeComponent()
        {
            lblTitle = new Label();
            dgvChiSo = new DataGridView();
            lblMaKH = new Label();
            txtMaKH = new TextBox();
            lblThang = new Label();
            txtThang = new TextBox();
            lblNam = new Label();
            txtNam = new TextBox();
            lblCu = new Label();
            txtChiSoCu = new TextBox();
            lblMoi = new Label();
            txtChiSoMoi = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvChiSo).BeginInit();
            SuspendLayout();
            //
            // lblTitle
            //
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(300, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(343, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Danh sách chỉ số điện";
            //
            // dgvChiSo
            //
            dgvChiSo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiSo.ColumnHeadersHeight = 34;
            dgvChiSo.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dgvChiSo.Location = new System.Drawing.Point(30, 60);
            dgvChiSo.Name = "dgvChiSo";
            dgvChiSo.RowHeadersWidth = 62;
            dgvChiSo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiSo.Size = new System.Drawing.Size(820, 293);
            dgvChiSo.TabIndex = 1;
            //
            // lblMaKH
            //
            lblMaKH.Location = new System.Drawing.Point(53, 367);
            lblMaKH.Name = "lblMaKH";
            lblMaKH.Size = new System.Drawing.Size(100, 23);
            lblMaKH.TabIndex = 2;
            lblMaKH.Text = "Mã KH:";
            //
            // txtMaKH
            //
            txtMaKH.Location = new System.Drawing.Point(173, 364);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new System.Drawing.Size(250, 31);
            txtMaKH.TabIndex = 3;
            //
            // lblThang
            //
            lblThang.Location = new System.Drawing.Point(522, 359);
            lblThang.Name = "lblThang";
            lblThang.Size = new System.Drawing.Size(72, 36);
            lblThang.TabIndex = 4;
            lblThang.Text = "Tháng:";
            //
            // txtThang
            //
            txtThang.Location = new System.Drawing.Point(600, 359);
            txtThang.Name = "txtThang";
            txtThang.Size = new System.Drawing.Size(250, 31);
            txtThang.TabIndex = 5;
            //
            // lblNam
            //
            lblNam.Location = new System.Drawing.Point(522, 427);
            lblNam.Name = "lblNam";
            lblNam.Size = new System.Drawing.Size(72, 23);
            lblNam.TabIndex = 6;
            lblNam.Text = "Năm:";
            //
            // txtNam
            //
            txtNam.Location = new System.Drawing.Point(600, 424);
            txtNam.Name = "txtNam";
            txtNam.Size = new System.Drawing.Size(250, 31);
            txtNam.TabIndex = 7;
            //
            // lblCu
            //
            lblCu.Location = new System.Drawing.Point(53, 479);
            lblCu.Name = "lblCu";
            lblCu.Size = new System.Drawing.Size(100, 33);
            lblCu.TabIndex = 8;
            lblCu.Text = "Chỉ số cũ:";
            //
            // txtChiSoCu
            //
            txtChiSoCu.Location = new System.Drawing.Point(173, 479);
            txtChiSoCu.Name = "txtChiSoCu";
            txtChiSoCu.Size = new System.Drawing.Size(250, 31);
            txtChiSoCu.TabIndex = 9;
            //
            // lblMoi
            //
            lblMoi.Location = new System.Drawing.Point(53, 424);
            lblMoi.Name = "lblMoi";
            lblMoi.Size = new System.Drawing.Size(114, 23);
            lblMoi.TabIndex = 10;
            lblMoi.Text = "Chỉ số mới:";
            //
            // txtChiSoMoi
            //
            txtChiSoMoi.Location = new System.Drawing.Point(173, 421);
            txtChiSoMoi.Name = "txtChiSoMoi";
            txtChiSoMoi.Size = new System.Drawing.Size(250, 31);
            txtChiSoMoi.TabIndex = 11;
            //
            // btnThem
            //
            btnThem.Location = new System.Drawing.Point(476, 499);
            btnThem.Name = "btnThem";
            btnThem.Size = new System.Drawing.Size(90, 36);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.Click += BtnThem_Click;
            //
            // btnSua
            //
            btnSua.Location = new System.Drawing.Point(617, 497);
            btnSua.Name = "btnSua";
            btnSua.Size = new System.Drawing.Size(90, 36);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.Click += BtnSua_Click;
            //
            // btnXoa
            //
            btnXoa.Location = new System.Drawing.Point(760, 496);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new System.Drawing.Size(90, 36);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.Click += BtnXoa_Click;
            //
            // dataGridViewTextBoxColumn1
            //
            dataGridViewTextBoxColumn1.HeaderText = "Mã KH";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            //
            // dataGridViewTextBoxColumn2
            //
            dataGridViewTextBoxColumn2.HeaderText = "Tháng";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            //
            // dataGridViewTextBoxColumn3
            //
            dataGridViewTextBoxColumn3.HeaderText = "Năm";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            //
            // dataGridViewTextBoxColumn4
            //
            dataGridViewTextBoxColumn4.HeaderText = "Chỉ số cũ";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            //
            // dataGridViewTextBoxColumn5
            //
            dataGridViewTextBoxColumn5.HeaderText = "Chỉ số mới";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            //
            // FormChiSoDien
            //
            ClientSize = new System.Drawing.Size(900, 550);
            Controls.Add(lblTitle);
            Controls.Add(dgvChiSo);
            Controls.Add(lblMaKH);
            Controls.Add(txtMaKH);
            Controls.Add(lblThang);
            Controls.Add(txtThang);
            Controls.Add(lblNam);
            Controls.Add(txtNam);
            Controls.Add(lblCu);
            Controls.Add(txtChiSoCu);
            Controls.Add(lblMoi);
            Controls.Add(txtChiSoMoi);
            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Name = "FormChiSoDien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý chỉ số điện";
            ((System.ComponentModel.ISupportInitialize)dgvChiSo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void LoadData()
        {
            dgvChiSo.Rows.Clear();
            var data = db.ChiSoDiens.ToList();
            foreach (var item in data)
            {
                dgvChiSo.Rows.Add(
                    item.CongToDienId,
                    item.ThangNam.Month,
                    item.ThangNam.Year,
                    item.ChiSoCu,
                    item.ChiSoMoi
                );
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtMaKH.Text, out int maKH) ||
                    !int.TryParse(txtThang.Text, out int thang) ||
                    !int.TryParse(txtNam.Text, out int nam) ||
                    !int.TryParse(txtChiSoCu.Text, out int chiSoCu) ||
                    !int.TryParse(txtChiSoMoi.Text, out int chiSoMoi))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng.");
                    return;
                }

                var thangNam = new DateTime(nam, thang, 1);
                var csd = new ChiSoDien
                {
                    CongToDienId = maKH,
                    ThangNam = thangNam,
                    NgayGhi = DateTime.Now,
                    ChiSoCu = chiSoCu,
                    ChiSoMoi = chiSoMoi
                };

                db.ChiSoDiens.Add(csd);
                db.SaveChanges();
                LoadData();
                ClearInputs();
                MessageBox.Show("Thêm thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtMaKH.Text, out int maKH) ||
                    !int.TryParse(txtThang.Text, out int thang) ||
                    !int.TryParse(txtNam.Text, out int nam) ||
                    !int.TryParse(txtChiSoCu.Text, out int chiSoCu) ||
                    !int.TryParse(txtChiSoMoi.Text, out int chiSoMoi))
                {
                    MessageBox.Show("Dữ liệu không hợp lệ.");
                    return;
                }

                var thangNam = new DateTime(nam, thang, 1);
                var csd = db.ChiSoDiens.FirstOrDefault(x => x.CongToDienId == maKH && x.ThangNam == thangNam);

                if (csd != null)
                {
                    csd.ChiSoCu = chiSoCu;
                    csd.ChiSoMoi = chiSoMoi;
                    db.SaveChanges();
                    LoadData();
                    ClearInputs();
                    MessageBox.Show("Cập nhật thành công.");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy bản ghi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtMaKH.Text, out int maKH) ||
                    !int.TryParse(txtThang.Text, out int thang) ||
                    !int.TryParse(txtNam.Text, out int nam))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin.");
                    return;
                }

                var thangNam = new DateTime(nam, thang, 1);
                var csd = db.ChiSoDiens.FirstOrDefault(x => x.CongToDienId == maKH && x.ThangNam == thangNam);

                if (csd != null)
                {
                    db.ChiSoDiens.Remove(csd);
                    db.SaveChanges();
                    LoadData();
                    ClearInputs();
                    MessageBox.Show("Xóa thành công.");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy bản ghi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void DgvChiSo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvChiSo.CurrentRow != null)
            {
                txtMaKH.Text = dgvChiSo.CurrentRow.Cells[0].Value?.ToString();
                txtThang.Text = dgvChiSo.CurrentRow.Cells[1].Value?.ToString();
                txtNam.Text = dgvChiSo.CurrentRow.Cells[2].Value?.ToString();
                txtChiSoCu.Text = dgvChiSo.CurrentRow.Cells[3].Value?.ToString();
                txtChiSoMoi.Text = dgvChiSo.CurrentRow.Cells[4].Value?.ToString();
            }
        }

        private void ClearInputs()
        {
            txtMaKH.Text = "";
            txtThang.Text = "";
            txtNam.Text = "";
            txtChiSoCu.Text = "";
            txtChiSoMoi.Text = "";
        }
    }
}