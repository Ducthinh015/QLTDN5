using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLTDN5.Entities
{
    [Table("NhanVien")]
    public class NhanVien
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string MaNV { get; set; }

        [Required]
        [MaxLength(100)]
        public string TenNV { get; set; }

        [Phone]
        [MaxLength(20)]
        public string DienThoai { get; set; }

        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        [MaxLength(50)]
        public string TaiKhoan { get; set; }

        [Required]
        [MaxLength(100)]
        public string MatKhau { get; set; }

        [Required]
        [MaxLength(20)]
        public string VaiTro { get; set; }
    }
}