using Ecom.Entity.common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecom.Entity
{
    public class chi_tiet_san_pham : BaseModel
    {
        public Guid Id { get; set; }
        public Guid san_pham_id { get; set; }
        public int kho_hang { get; set; }
        public string? SKU_san_pham {  get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? chieu_dai { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? chieu_rong { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? can_cang { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? gia { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? gia_khuyen_mai { get; set; }
        public string? mau_sac { get; set; }
        public virtual san_pham San_Pham { get; set; }
    }
}
