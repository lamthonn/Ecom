using Ecom.Entity.common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecom.Entity
{
    public class don_hang : BaseModel
    {
        public Guid Id { get; set; }
        public Guid nguoi_dung_id { get; set; }
        public string ma_don_hang { get; set; }
        public int trang_thai { get; set; }
        public DateTime ngay_mua { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal tong_tien { get; set; }
        public Guid? giam_gia_id { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal thanh_tien { get; set; }
        public Guid dvvc_id { get; set; }
        public virtual account Account { get; set; }
        public virtual ma_giam_gia ma_giam_gia { get; set; }
        public virtual dvvc dvvc { get; set; }
    }
}
