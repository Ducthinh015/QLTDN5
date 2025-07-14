using QLTDN5.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLTDN5.Entities
{
    [Table("BangGia")]
    public class BangGia
    {
        [Key]
        public int Id { get; set; }

        public string MaBac { get; set; }
        public string TenBac { get; set; }
        public int MaGia { get; set; }
        public string MoTa { get; set; }

        public int MucTu { get; set; }
        public int MucDen { get; set; }

        [Required]
        public string MucDien { get; set; }

        [Required]
        public decimal DonGia { get; set; }
    }
}