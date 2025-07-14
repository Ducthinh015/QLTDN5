using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLTDN5.Entities
{
    [Table("HoaDon")]
    public class HoaDon
    {
        [Key]
        public int Id { get; set; }

        public int KhachHangId { get; set; }
        public DateTime NgayLap { get; set; }

        

        [Required]
        public decimal SoTien { get; set; }

        [ForeignKey("KhachHangId")]
        public KhachHang KhachHang { get; set; }

        public int ChiSoDienId { get; set; }
        public ChiSoDien ChiSoDien { get; set; }
        public int SoDien { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
    }s
}