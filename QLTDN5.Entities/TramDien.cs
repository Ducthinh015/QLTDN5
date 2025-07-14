using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLTDN5.Entities
{
    [Table("TramDien")]
    public class TramDien
    {
        [Key]
        public int Id { get; set; }

        public string MaTram { get; set; }

        public string TenTram { get; set; }

        public string ViTri { get; set; }

        public string GhiChu { get; set; }
        public virtual ICollection<CongToDien> CongToDiens { get; set; } = new List<CongToDien>();
    }
}