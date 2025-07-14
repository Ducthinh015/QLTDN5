using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using QLTDN5.Data;
using QLTDN5.Entities;

namespace QLTDN5.WinForms.Forms
{
    public partial class FormHoaDon : Form
    {
        private QLTDN5Context db = new QLTDN5Context();
        private HoaDon hoaDonHienTai;

        private Label lblTitle, lblMaKH, lblChiSoCu, lblChiSoMoi, lblBacGia, lblSoDien, lblSoTien, lblTongTien;
        private TextBox txtMaKH, txtChiSoCu, txtChiSoMoi, txtSoDien, txtSoTien;
        private ComboBox cbBacGia;
        private Button btnTao, btnIn, btnXoa;
        private DataGridView dgvHoaDon;

        public FormHoaDon()
        {
            InitializeComponent();
            LoadBangGia();
            LoadHoaDonGrid();
            dgvHoaDon.CellClick += DgvHoaDon_CellClick;
            txtMaKH.TextChanged += txtMaKH_TextChanged;
            txtChiSoMoi.TextChanged += txtChiSoMoi_TextChanged;
            cbBacGia.SelectedIndexChanged += cbBacGia_SelectedIndexChanged;
            SetupKhachHangAutoComplete();
        }

        private void InitializeComponent()
        {
            // Cấu hình AutoComplete cho txtMaKH
            txtMaKH = new TextBox();
            txtMaKH.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtMaKH.AutoCompleteSource = AutoCompleteSource.CustomSource;
        
            lblTitle = new Label();
            dgvHoaDon = new DataGridView();
            lblMaKH = new Label();
            txtMaKH = new TextBox();
            lblChiSoCu = new Label();
            txtChiSoCu = new TextBox();
            lblChiSoMoi = new Label();
            txtChiSoMoi = new TextBox();
            lblBacGia = new Label();
            cbBacGia = new ComboBox();
            lblSoDien = new Label();
            txtSoDien = new TextBox();
            lblSoTien = new Label();
            txtSoTien = new TextBox();
            btnTao = new Button();
            btnIn = new Button();
            btnXoa = new Button();
            lblTongTien = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            SuspendLayout();
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(330, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(270, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Danh sách hóa đơn";
            //
            // dgvHoaDon
            //
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.ColumnHeadersHeight = 34;
            dgvHoaDon.Location = new Point(30, 61);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.ReadOnly = true;
            dgvHoaDon.RowHeadersWidth = 62;
            dgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHoaDon.Size = new Size(820, 363);
            dgvHoaDon.TabIndex = 1;
            //
            // lblMaKH
            //
            lblMaKH.Location = new Point(30, 440);
            lblMaKH.Name = "lblMaKH";
            lblMaKH.Size = new Size(56, 23);
            lblMaKH.TabIndex = 2;
            lblMaKH.Text = "Mã KH:";
            //
            // txtMaKH
            //
            txtMaKH.Location = new Point(92, 439);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(110, 31);
            txtMaKH.TabIndex = 3;
            //
            // lblChiSoCu
            //
            lblChiSoCu.Location = new Point(208, 439);
            lblChiSoCu.Name = "lblChiSoCu";
            lblChiSoCu.Size = new Size(88, 30);
            lblChiSoCu.TabIndex = 4;
            lblChiSoCu.Text = "Chỉ số cũ:";
            //
            // txtChiSoCu
            //
            txtChiSoCu.Location = new Point(294, 440);
            txtChiSoCu.Name = "txtChiSoCu";
            txtChiSoCu.ReadOnly = true;
            txtChiSoCu.Size = new Size(80, 31);
            txtChiSoCu.TabIndex = 5;
            //
            // lblChiSoMoi
            //
            lblChiSoMoi.Location = new Point(380, 440);
            lblChiSoMoi.Name = "lblChiSoMoi";
            lblChiSoMoi.Size = new Size(105, 33);
            lblChiSoMoi.TabIndex = 6;
            lblChiSoMoi.Text = "Chỉ số mới:";
            //
            // txtChiSoMoi
            //
            txtChiSoMoi.Location = new Point(485, 441);
            txtChiSoMoi.Name = "txtChiSoMoi";
            txtChiSoMoi.Size = new Size(129, 31);
            txtChiSoMoi.TabIndex = 7;
            //
            // lblBacGia
            //
            lblBacGia.Location = new Point(620, 444);
            lblBacGia.Name = "lblBacGia";
            lblBacGia.Size = new Size(67, 30);
            lblBacGia.TabIndex = 10;
            lblBacGia.Text = "Bậc giá:";
            //
            // cbBacGia
            //
            cbBacGia.Location = new Point(693, 441);
            cbBacGia.Name = "cbBacGia";
            cbBacGia.Size = new Size(157, 33);
            cbBacGia.TabIndex = 11;
            //
            // lblSoDien
            //
            lblSoDien.Location = new Point(30, 483);
            lblSoDien.Name = "lblSoDien";
            lblSoDien.Size = new Size(78, 32);
            lblSoDien.TabIndex = 10;
            lblSoDien.Text = "Số điện:";
            //
            // txtSoDien
            //
            txtSoDien.Location = new Point(108, 480);
            txtSoDien.Name = "txtSoDien";
            txtSoDien.ReadOnly = true;
            txtSoDien.Size = new Size(94, 31);
            txtSoDien.TabIndex = 11;
            //
            // lblSoTien
            //
            lblSoTien.Location = new Point(220, 480);
            lblSoTien.Name = "lblSoTien";
            lblSoTien.Size = new Size(76, 31);
            lblSoTien.TabIndex = 12;
            lblSoTien.Text = "Số tiền:";
            //
            // txtSoTien
            //
            txtSoTien.Location = new Point(294, 480);
            txtSoTien.Name = "txtSoTien";
            txtSoTien.ReadOnly = true;
            txtSoTien.Size = new Size(129, 31);
            txtSoTien.TabIndex = 13;
            //
            // btnTao
            //
            btnTao.BackColor = SystemColors.Info;
            btnTao.Location = new Point(568, 496);
            btnTao.Name = "btnTao";
            btnTao.Size = new Size(81, 32);
            btnTao.TabIndex = 14;
            btnTao.Text = "Tạo HĐ";
            btnTao.UseVisualStyleBackColor = false;
            btnTao.Click += BtnTao_Click;
            //
            // btnIn
            //
            btnIn.BackColor = SystemColors.ActiveCaption;
            btnIn.Location = new Point(671, 496);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(80, 32);
            btnIn.TabIndex = 15;
            btnIn.Text = "In";
            btnIn.UseVisualStyleBackColor = false;
            btnIn.Click += btnIn_Click;
            //
            // btnXoa
            //
            btnXoa.Location = new Point(770, 496);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(80, 32);
            btnXoa.TabIndex = 16;
            btnXoa.Text = "Xóa";
            btnXoa.Click += BtnXoa_Click;
            //
            // lblTongTien
            //
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTongTien.ForeColor = Color.DarkGreen;
            lblTongTien.Location = new Point(26, 609);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(176, 28);
            lblTongTien.TabIndex = 17;
            lblTongTien.Text = "Tổng tiền: 0 VNĐ";
            //
            // FormHoaDon
            //
            ClientSize = new Size(900, 646);
            Controls.Add(lblTitle);
            Controls.Add(dgvHoaDon);
            Controls.Add(lblMaKH);
            Controls.Add(txtMaKH);
            Controls.Add(lblChiSoCu);
            Controls.Add(txtChiSoCu);
            Controls.Add(lblChiSoMoi);
            Controls.Add(txtChiSoMoi);
            Controls.Add(lblBacGia);
            Controls.Add(cbBacGia);
            Controls.Add(lblSoDien);
            Controls.Add(txtSoDien);
            Controls.Add(lblSoTien);
            Controls.Add(txtSoTien);
            Controls.Add(btnTao);
            Controls.Add(btnIn);
            Controls.Add(btnXoa);
            Controls.Add(lblTongTien);
            Name = "FormHoaDon";
            Text = "Tạo và in hóa đơn tiền điện";
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private class BacGiaItem
        {
            public BangGia BangGia { get; set; }
            public string MoTa { get; set; }

            public override string ToString() => MoTa;
        }

        private void LoadBangGia()
        {
            var dsBac = db.BangGiaDiens.OrderBy(b => b.MucTu).ToList();
            cbBacGia.Items.Clear();
            foreach (var b in dsBac)
            {
                cbBacGia.Items.Add(new BacGiaItem
                {
                    BangGia = b,
                    MoTa = $"Bậc {b.Id}: {b.MucTu}-{b.MucDen} kWh ({b.DonGia:N0}đ/kWh)"
                });
            }
            if (cbBacGia.Items.Count > 0) cbBacGia.SelectedIndex = 0;
        }

        private void LoadHoaDonGrid()
        {
            var data = db.HoaDons
                .Select(h => new
                {
                    h.Id,
                    h.KhachHangId,
                    MaKH = h.KhachHang != null ? h.KhachHang.MaKH : "",
                    TenKH = h.KhachHang != null ? h.KhachHang.TenKhachHang : "",
                    h.NgayLap,
                    h.ChiSoDienId,
                    ChiSoCu = h.ChiSoDien != null ? h.ChiSoDien.ChiSoCu : 0,
                    ChiSoMoi = h.ChiSoDien != null ? h.ChiSoDien.ChiSoMoi : 0,
                    NgayGhi = h.ChiSoDien != null ? h.ChiSoDien.NgayGhi : (DateTime?)null,
                    SoDien = h.SoDien,
                    h.SoTien
                }).ToList();
            dgvHoaDon.DataSource = data;
            UpdateTongTien();
        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            txtChiSoCu.Clear();
            txtSoDien.Clear();
            txtSoTien.Clear();

            if (!int.TryParse(txtMaKH.Text, out int khachHangId))
            {
                txtChiSoCu.Text = "";
                return;
            }
            var kh = db.KhachHangs.FirstOrDefault(k => k.Id == khachHangId);
            if (kh == null)
            {
                txtChiSoCu.Text = "";
                return;
            }
            var cs = db.ChiSoDiens
                       .Where(c => c.KhachHangId == kh.Id)
                       .OrderByDescending(c => c.NgayGhi)
                       .FirstOrDefault();
            txtChiSoCu.Text = cs == null ? "0" : cs.ChiSoMoi.ToString();
        }

        private void txtChiSoMoi_TextChanged(object sender, EventArgs e)
        {
            TinhSoTien();
        }

        private void cbBacGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            TinhSoTien();
        }

        private void TinhSoTien()
        {
            if (!int.TryParse(txtChiSoCu.Text, out int chiSoCu) ||
                !int.TryParse(txtChiSoMoi.Text, out int chiSoMoi))

            {
                txtSoDien.Text = "";
                txtSoTien.Text = "";
                return;
            }
            int soDien = chiSoMoi - chiSoCu;
            if (soDien < 0)
            {
                // Nếu số điện bị âm, tự động tính lại theo kiểu quay vòng
                int maxCongTo = 99999;
                soDien = (maxCongTo - chiSoCu) + chiSoMoi + 1;
            }
            txtSoDien.Text = soDien > 0 ? soDien.ToString() : "";

            var bacGia = cbBacGia.SelectedItem as BacGiaItem;
            if (bacGia != null)
            {
                decimal tongTien = soDien * bacGia.BangGia.DonGia;
                txtSoTien.Text = tongTien.ToString("N0");
            }
            else
            {
                txtSoTien.Text = "";
            }
        }

        private void BtnTao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKH.Text)
                || !int.TryParse(txtChiSoCu.Text, out int chiSoCu)
                || !int.TryParse(txtChiSoMoi.Text, out int chiSoMoi)
                || chiSoMoi < chiSoCu
                || cbBacGia.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và đúng định dạng thông tin.");
                return;
            }

            if (!int.TryParse(txtMaKH.Text, out int khachHangId))
            {
                MessageBox.Show("Mã KH phải là số ID khách hàng.");
                return;
            }
            var kh = db.KhachHangs.FirstOrDefault(x => x.Id == khachHangId);
            if (kh == null)
            {
                MessageBox.Show("Không tìm thấy mã khách hàng.");
                return;
            }

            int soDien = chiSoMoi - chiSoCu;
            if (soDien < 0)
            {
                int maxCongTo = 99999;
                soDien = (maxCongTo - chiSoCu) + chiSoMoi + 1;
            }
            var bacGia = cbBacGia.SelectedItem as BacGiaItem;
            decimal tongTien = soDien * bacGia.BangGia.DonGia;

            // Lưu chỉ số điện mới
            var cs = new ChiSoDien
            {
                KhachHangId = kh.Id,
                ChiSoCu = chiSoCu,
                ChiSoMoi = chiSoMoi,
                NgayGhi = DateTime.Now,
            };
            db.ChiSoDiens.Add(cs);
            db.SaveChanges();

            // Lưu hóa đơn
            var hd = new HoaDon
            {
                KhachHangId = kh.Id,
                ChiSoDienId = cs.Id,
                NgayLap = DateTime.Now,
                Thang = DateTime.Now.Month,
                Nam = DateTime.Now.Year,
                SoDien = soDien,
                SoTien = tongTien
            };

            db.HoaDons.Add(hd);
            db.SaveChanges();

            LoadHoaDonGrid();
            ClearInputs();

            txtSoDien.Text = soDien.ToString();
            txtSoTien.Text = tongTien.ToString("N0");
            UpdateTongTien();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvHoaDon.CurrentRow.Cells["Id"].Value);
                var hd = db.HoaDons.Find(id);
                if (hd != null)
                {
                    db.HoaDons.Remove(hd);
                    db.SaveChanges();
                    LoadHoaDonGrid();
                    ClearInputs();
                }
            }
        }

        private void DgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHoaDon.CurrentRow != null && dgvHoaDon.CurrentRow.Index >= 0)
            {
                var idValue = dgvHoaDon.CurrentRow.Cells[0].Value;
                if (idValue == null || idValue == DBNull.Value)
                    return;

                int id = Convert.ToInt32(idValue);
                hoaDonHienTai = db.HoaDons.FirstOrDefault(h => h.Id == id);

                if (hoaDonHienTai != null)
                {
                    // Check null tránh lỗi
                    txtMaKH.Text = hoaDonHienTai.KhachHang != null ? hoaDonHienTai.KhachHang.MaKH : "";

                    var cs = db.ChiSoDiens.FirstOrDefault(c => c.Id == hoaDonHienTai.ChiSoDienId);
                    if (cs != null)
                    {
                        txtChiSoCu.Text = cs.ChiSoCu.ToString();
                        txtChiSoMoi.Text = cs.ChiSoMoi.ToString();
                        txtSoDien.Text = (cs.ChiSoMoi - cs.ChiSoCu).ToString();
                    }
                    else
                    {
                        txtChiSoCu.Text = "";
                        txtChiSoMoi.Text = "";
                        txtSoDien.Text = "";
                    }

                    txtSoTien.Text = hoaDonHienTai.SoTien.ToString("N0");

                    var gia = db.BangGiaDiens.FirstOrDefault(g => g.DonGia == hoaDonHienTai.SoTien / (hoaDonHienTai.SoDien == 0 ? 1 : hoaDonHienTai.SoDien));
                    if (gia != null)
                    {
                        foreach (var item in cbBacGia.Items)
                        {
                            if ((item as BacGiaItem)?.BangGia.Id == gia.Id)
                            {
                                cbBacGia.SelectedItem = item;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void UpdateTongTien()
        {
            decimal tong = db.HoaDons.Sum(h => h.SoTien);
            lblTongTien.Text = $"Tổng tiền: {tong:N0} VNĐ";
        }

        private void ClearInputs()
        {
            txtMaKH.Clear();
            txtChiSoCu.Clear();
            txtChiSoMoi.Clear();
            txtSoDien.Clear();
            txtSoTien.Clear();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để in.");
                return;
            }

            int id = Convert.ToInt32(dgvHoaDon.CurrentRow.Cells[0].Value);

            var hoaDon = db.HoaDons
                           .Where(h => h.Id == id)
                           .Select(h => new
                           {
                               h.Id,
                               h.NgayLap,
                               h.SoTien,
                               TenKhachHang = h.KhachHang != null ? h.KhachHang.TenKhachHang : ""
                           }).FirstOrDefault();

            if (hoaDon == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn trong CSDL");
                return;
            }

            string txtPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"HoaDon_{hoaDon.Id}.txt");

            try
            {
                using (StreamWriter sw = new StreamWriter(txtPath, false))
                {
                    sw.WriteLine("========== HÓA ĐƠN TIỀN ĐIỆN ==========");
                    sw.WriteLine($"Mã hóa đơn : {hoaDon.Id}");
                    sw.WriteLine($"Ngày lập    : {hoaDon.NgayLap:dd/MM/yyyy}");
                    sw.WriteLine($"Tháng/Năm  : {hoaDon.NgayLap.Month}/{hoaDon.NgayLap.Year}");
                    sw.WriteLine($"Khách hàng : {hoaDon.TenKhachHang}");
                    sw.WriteLine($"Số tiền     : {hoaDon.SoTien:N0} VNĐ");
                    sw.WriteLine("=======================================");
                }
                if (File.Exists(txtPath))
                {
                    MessageBox.Show("✔ Đã in Hóa đơn thành công!");
                    System.Diagnostics.Process.Start("explorer.exe", txtPath);
                }
                else
                {
                    MessageBox.Show("❌ Không tìm thấy file sau khi in.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo file: " + ex.Message);
            }
        }

        private void txtSoTien_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtSoDien_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblBacGia_Click(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// Thiết lập AutoComplete cho textbox mã khách hàng
        /// </summary>
        private void SetupKhachHangAutoComplete()
        {
            var autoSource = new AutoCompleteStringCollection();
            var maKHs = db.KhachHangs.Select(kh => kh.MaKH).ToList();
            autoSource.AddRange(maKHs.ToArray());
            txtMaKH.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtMaKH.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtMaKH.AutoCompleteCustomSource = autoSource;
        }
    }
}