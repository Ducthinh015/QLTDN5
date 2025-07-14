using System;
using System.Windows.Forms;
using QLTDN5.WinForms.Forms;

namespace QLTDN5.WinForms
{
    public enum Role
    {
        Admin,
        NhanVien,
        KeToan
    }

    public static class CurrentUser
    {
        public static string Username { get; set; }
        public static Role UserRole { get; set; }
    }

    internal static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Khởi chạy form đăng nhập đầu tiên
            using (var loginForm = new FormDangNhap())
            {
                if (loginForm.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(CurrentUser.Username))
                {
                    Application.Run(new FormMain());
                }
            }
        }
    }
}