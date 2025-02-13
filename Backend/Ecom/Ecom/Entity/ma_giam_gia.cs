using Ecom.Entity.common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecom.Entity
{
    public class ma_giam_gia : BaseModel
    {
        public Guid Id { get; set; }
        public string ten { get; set; }
        public bool loai_giam_gia { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? giam_gia { get; set; }
        public DateTime? thoi_gian_ap_dung_tu { get; set; }
        public DateTime? thoi_gian_ap_dung_den { get; set; }
        public int? so_luong { get; set; }
        public bool is_active { get; set; } = true;
    }
}
