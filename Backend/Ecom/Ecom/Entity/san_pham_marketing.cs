using Ecom.Entity.common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecom.Entity
{
    public class san_pham_marketing : BaseModel
    {
        public Guid Id { get; set; }
        public Guid chuong_trinh_marketing_id { get; set; }
        public Guid chi_tiet_san_pham_id { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? gia_goc {  get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? gia_sau_giam {  get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? giam_gia {  get; set; }
        public int? so_luong {  get; set; }
        public bool is_active { get; set; } = false;
        public virtual chuong_trinh_marketing Chuong_Trinh_Marketing { get; set; }
        public virtual chi_tiet_san_pham Chi_Tiet_San_Pham { get; set; }
    }
}
