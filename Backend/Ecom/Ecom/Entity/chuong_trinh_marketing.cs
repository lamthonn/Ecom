using Ecom.Entity.common;

namespace Ecom.Entity
{
    public class chuong_trinh_marketing : BaseModel
    {
        public Guid Id { get; set; }
        public Guid ma_giam_gia_id { get; set; }
        public string? ten { get; set; }
        public int? cong_cu { get; set; }
        public virtual ma_giam_gia ma_giam_gia { get; set; }
    }
}
