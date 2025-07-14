using QLTDN5.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLTDN5.Entities
{
    [Table("CongToDien")]
    public class CongToDien
    {
        [Key]
        public int Id { get; set; }

        public string SoSerial { get; set; }
        public string MaCongTo { get; set; }

        public int KhachHangId { get; set; }

        [ForeignKey("KhachHangId")]
        public bool TrangThai { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public int? BangGiaId { get; set; }
        public int? TramDienId { get; set; }

        [ForeignKey("TramDienId")]
        public virtual TramDien TramDien { get; set; }

        [ForeignKey("BangGiaId")]
        public virtual BangGia BangGia { get; set; }

        public virtual ICollection<ChiSoDien> ChiSoDiens { get; set; } = new List<ChiSoDien>();
    }
}