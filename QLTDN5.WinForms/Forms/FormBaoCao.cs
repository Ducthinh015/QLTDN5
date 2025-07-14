using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using QLTDN5.Data;
using QLTDN5.Entities;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using Microsoft.EntityFrameworkCore;

namespace QLTDN5.WinForms.Forms
{
    public partial class FormBaoCao : Form
    {
        private QLTDN5Context db = new QLTDN5Context();

        private ComboBox cboThang;
        private ComboBox cboNam;
        private Button btnThongKe;
        private DataGridView dgvBaoCao;
        private Label lblTongDoanhThu, lblTitle, lblThang, lblNam, lblThongTin;
        private TextBox txtTimKiem;
        private Button btnIn;
        private Button btnExportExcel;

        public FormBaoCao()
        {
            InitializeComponent();
            LoadComboBoxData();
            dgvBaoCao.CellClick += DgvBaoCao_CellClick;
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblThang = new Label();
            cboThang = new ComboBox();
            lblNam = new Label();
            cboNam = new ComboBox();
            btnThongKe = new Button();
            dgvBaoCao = new DataGridView();
            lblTongDoanhThu = new Label();
            lblThongTin = new Label();
            txtTimKiem = new TextBox();
            btnIn = new Button();
            btnExportExcel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBaoCao).BeginInit();
            SuspendLayout();
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(278, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(417, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Báo cáo doanh thu theo tháng";
            //
            // lblThang
            //
            lblThang.Location = new Point(30, 58);
            lblThang.Name = "lblThang";
            lblThang.Size = new Size(78, 35);
            lblThang.TabIndex = 1;
            lblThang.Text = "Tháng:";
            //
            // cboThang
            //
            cboThang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboThang.Location = new Point(114, 55);
            cboThang.Name = "cboThang";
            cboThang.Size = new Size(96, 33);
            cboThang.TabIndex = 2;
            //
            // lblNam
            //
            lblNam.Location = new Point(233, 58);
            lblNam.Name = "lblNam";
            lblNam.Size = new Size(66, 30);
            lblNam.TabIndex = 3;
            lblNam.Text = "Năm:";
            //
            // cboNam
            //
            cboNam.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNam.Location = new Point(305, 55);
            cboNam.Name = "cboNam";
            cboNam.Size = new Size(101, 33);
            cboNam.TabIndex = 4;
            //
            // btnThongKe
            //
            btnThongKe.Location = new Point(30, 520);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(180, 36);
            btnThongKe.TabIndex = 5;
            btnThongKe.Text = "📊 Thống kê";
            btnThongKe.Click += BtnThongKe_Click;
            //
            // dgvBaoCao
            //
            dgvBaoCao.AllowUserToAddRows = false;
            dgvBaoCao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBaoCao.ColumnHeadersHeight = 34;
            dgvBaoCao.Location = new Point(30, 106);
            dgvBaoCao.Name = "dgvBaoCao";
            dgvBaoCao.ReadOnly = true;
            dgvBaoCao.RowHeadersWidth = 62;
            dgvBaoCao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBaoCao.Size = new Size(800, 408);
            dgvBaoCao.TabIndex = 7;
            //
            // lblTongDoanhThu
            //
            lblTongDoanhThu.AutoSize = true;
            lblTongDoanhThu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTongDoanhThu.Location = new Point(594, 537);
            lblTongDoanhThu.Name = "lblTongDoanhThu";
            lblTongDoanhThu.Size = new Size(236, 28);
            lblTongDoanhThu.TabIndex = 8;
            lblTongDoanhThu.Text = "Tổng doanh thu: 0 VNĐ";
            //
            // lblThongTin
            //
            lblThongTin.AutoSize = true;
            lblThongTin.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblThongTin.Location = new Point(30, 560);
            lblThongTin.Name = "lblThongTin";
            lblThongTin.Size = new Size(0, 28);
            lblThongTin.TabIndex = 9;
            //
            // txtTimKiem
            //
            txtTimKiem.Location = new Point(453, 55);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "🔍 Tìm theo tên KH hoặc mã HĐ";
            txtTimKiem.Size = new Size(377, 31);
            txtTimKiem.TabIndex = 6;
            txtTimKiem.TextChanged += TxtTimKiem_TextChanged;
            //
            // btnIn
            //
            btnIn.Location = new Point(233, 520);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(165, 36);
            btnIn.TabIndex = 10;
            btnIn.Text = "🖨 In hóa đơn";
            btnIn.Click += btnIn_Click;
            //
            // btnExportExcel
            //
            btnExportExcel.Location = new Point(423, 520);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(165, 36);
            btnExportExcel.TabIndex = 11;
            btnExportExcel.Text = "📤 Xuất Excel";
            btnExportExcel.Click += btnExportExcel_Click;
            //
            // FormBaoCao
            //
            ClientSize = new Size(881, 600);
            Controls.Add(lblTitle);
            Controls.Add(lblThang);
            Controls.Add(cboThang);
            Controls.Add(lblNam);
            Controls.Add(cboNam);
            Controls.Add(btnThongKe);
            Controls.Add(txtTimKiem);
            Controls.Add(dgvBaoCao);
            Controls.Add(lblTongDoanhThu);
            Controls.Add(lblThongTin);
            Controls.Add(btnIn);
            Controls.Add(btnExportExcel);
            Name = "FormBaoCao";
            Text = "Báo cáo doanh thu";
            ((System.ComponentModel.ISupportInitialize)dgvBaoCao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void LoadComboBoxData()
        {
            for (int i = 1; i <= 12; i++)
                cboThang.Items.Add(i.ToString());
            cboThang.SelectedIndex = DateTime.Now.Month - 1;

            for (int y = 2020; y <= 2025; y++)
                cboNam.Items.Add(y.ToString());
            cboNam.SelectedItem = DateTime.Now.Year.ToString();
        }

        private void BtnThongKe_Click(object sender, EventArgs e)
        {
            if (cboThang.SelectedItem == null || cboNam.SelectedItem == null)
                return;

            int thang = int.Parse(cboThang.SelectedItem.ToString());
            int nam = int.Parse(cboNam.SelectedItem.ToString());

            var ds = db.HoaDons
                .Include(h => h.KhachHang)
                .Where(h => h.NgayLap.Month == thang && h.NgayLap.Year == nam)
                .Select(h => new
                {
                    MaHoaDon = h.Id,
                    TenKhachHang = h.KhachHang.TenKhachHang,
                    NgayLap = h.NgayLap.ToString("dd/MM/yyyy"),
                    SoTien = h.SoTien
                }).ToList();

            dgvBaoCao.DataSource = ds;

            decimal tong = ds.Sum(x => x.SoTien);
            lblTongDoanhThu.Text = $"Tổng doanh thu: {tong:N0} VNĐ";

            int tongKH = db.KhachHangs.Count();
            int tongHD = ds.Count;
            lblThongTin.Text = $"Tổng KH: {tongKH} | Hóa đơn tháng {thang}/{nam}: {tongHD}";
        }

        private void TxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.ToLower();

            var thang = int.Parse(cboThang.SelectedItem.ToString());
            var nam = int.Parse(cboNam.SelectedItem.ToString());

            var ds = db.HoaDons
                .Where(h => h.NgayLap.Month == thang && h.NgayLap.Year == nam)
                .Where(h => h.KhachHang.TenKhachHang.ToLower().Contains(keyword)
                            || h.Id.ToString().Contains(keyword))
                .Select(h => new
                {
                    MaHoaDon = h.Id,
                    TenKhachHang = h.KhachHang.TenKhachHang,
                    NgayLap = h.NgayLap.ToString("dd/MM/yyyy"),
                    SoTien = h.SoTien
                }).ToList();

            dgvBaoCao.DataSource = ds;

            decimal tong = ds.Sum(x => x.SoTien);
            lblTongDoanhThu.Text = $"Tổng doanh thu: {tong:N0} VNĐ";
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string logPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "log_in.txt");
            Directory.CreateDirectory(Path.GetDirectoryName(logPath));

            try
            {
                File.AppendAllText(logPath, $"[{DateTime.Now}] ĐÃ VÀO btnIn_Click\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi log: " + ex.Message);
            }

            if (dgvBaoCao.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một hóa đơn để in.");
                return;
            }

            string txtPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"HoaDon_TongHop.txt");
            decimal tongTien = 0;

            try
            {
                using (StreamWriter sw = new StreamWriter(txtPath, false))
                {
                    sw.WriteLine("========== DANH SÁCH HÓA ĐƠN ==========");
                    sw.WriteLine($"Ngày in: {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
                    sw.WriteLine("=======================================");
                    sw.WriteLine();

                    foreach (DataGridViewRow row in dgvBaoCao.SelectedRows)
                    {
                        int id = Convert.ToInt32(row.Cells[0].Value);
                        File.AppendAllText(logPath, $"[{DateTime.Now}] Đã chọn HĐ ID: {id}\n");

                        var hoaDon = db.HoaDons
                                       .Where(h => h.Id == id)
                                       .Select(h => new
                                       {
                                           h.Id,
                                           h.NgayLap,
                                           h.SoTien,
                                           TenKhachHang = h.KhachHang.TenKhachHang
                                       }).FirstOrDefault();

                        if (hoaDon == null)
                        {
                            File.AppendAllText(logPath, $"[{DateTime.Now}] Không tìm thấy HĐ {id}\n");
                            continue;
                        }

                        tongTien += hoaDon.SoTien;

                        sw.WriteLine($"Mã hóa đơn : {hoaDon.Id}");
                        sw.WriteLine($"Ngày lập    : {hoaDon.NgayLap:dd/MM/yyyy}");
                        sw.WriteLine($"Tháng/Năm  : {hoaDon.NgayLap.Month}/{hoaDon.NgayLap.Year}");
                        sw.WriteLine($"Khách hàng : {hoaDon.TenKhachHang}");
                        sw.WriteLine($"Số tiền     : {hoaDon.SoTien:N0} VNĐ");
                        sw.WriteLine("---------------------------------------");
                    }

                    sw.WriteLine();
                    sw.WriteLine($"TỔNG CỘNG: {tongTien:N0} VNĐ");
                    sw.WriteLine("========== KẾT THÚC ==========");
                }

                File.AppendAllText(logPath, $"[{DateTime.Now}] Ghi xong file tổng hợp\n");

                if (File.Exists(txtPath))
                {
                    MessageBox.Show("✔ Đã in thành công các hóa đơn!");
                    System.Diagnostics.Process.Start("explorer.exe", txtPath);
                }
                else
                {
                    MessageBox.Show("❌ Không tìm thấy file sau khi in.");
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(logPath, $"[{DateTime.Now}] Lỗi in nhiều hóa đơn: {ex.Message}\n");
                MessageBox.Show("Lỗi khi tạo file: " + ex.Message);
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            string excelPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "BaoCaoDoanhThu.xlsx");

            try
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("BaoCao");

                    // Header
                    for (int i = 0; i < dgvBaoCao.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1].Value = dgvBaoCao.Columns[i].HeaderText;
                        worksheet.Cells[1, i + 1].Style.Font.Bold = true;
                    }

                    // Data
                    for (int i = 0; i < dgvBaoCao.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvBaoCao.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1].Value = dgvBaoCao.Rows[i].Cells[j].Value;
                        }
                    }

                    // Tính tổng tiền
                    decimal tongTien = dgvBaoCao.Rows.Cast<DataGridViewRow>()
                        .Sum(r => Convert.ToDecimal(r.Cells["SoTien"].Value));

                    int tongRow = dgvBaoCao.Rows.Count + 2;
                    worksheet.Cells[tongRow, 1].Value = "Tổng doanh thu:";
                    worksheet.Cells[tongRow, 1].Style.Font.Bold = true;
                    worksheet.Cells[tongRow, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Right;

                    worksheet.Cells[tongRow, 4].Value = tongTien;
                    worksheet.Cells[tongRow, 4].Style.Font.Bold = true;
                    worksheet.Cells[tongRow, 4].Style.Numberformat.Format = "#,##0 VNĐ";

                    // Tự động chỉnh cột
                    worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                    package.SaveAs(new FileInfo(excelPath));
                }

                MessageBox.Show("✔ Xuất Excel thành công!");
                System.Diagnostics.Process.Start("explorer.exe", excelPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi xuất Excel: " + ex.Message);
            }
        }

        private void DgvBaoCao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}