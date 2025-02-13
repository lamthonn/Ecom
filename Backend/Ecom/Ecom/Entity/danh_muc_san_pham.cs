using Ecom.Entity.common;

namespace Ecom.Entity
{
    public class danh_muc_san_pham : BaseModel
    {
        public Guid Id { get; set; }
        public string ma_danh_muc { get; set; }
        public string ten_danh_muc { get; set; }
    }
}
