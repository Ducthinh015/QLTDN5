using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLTDN5.Entities
{
    [Table("KhachHang")]
    public class KhachHang
    {
        [Key]
        public int Id { get; set; }


        public string MaKH { get; set; }
        public string TenKhachHang { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string CCCD { get; set; }
        public string Email { get; set; }
        public string MaSoThue { get; set; }
        public string GhiChu { get; set; }

        public virtual ICollection<CongToDien> CongToDiens { get; set; }
        public virtual ICollection<ChiSoDien> ChiSoDiens { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}