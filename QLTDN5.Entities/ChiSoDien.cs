using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLTDN5.Entities
{
    [Table("ChiSoDien")]
    public class ChiSoDien
    {
        [Key]
        public int Id { get; set; }

        public int KhachHangId { get; set; }

        [Required]
        public int CongToDienId { get; set; }

        [Required]
        public DateTime NgayGhi { get; set; }

        [Required]
        public int ChiSoCu { get; set; }

        [Required]
        public int ChiSoMoi { get; set; }

        [Required]
        public DateTime ThangNam { get; set; }

        [ForeignKey(nameof(CongToDienId))]
        public virtual CongToDien CongToDien { get; set; }

        public virtual KhachHang KhachHang { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
    }
}