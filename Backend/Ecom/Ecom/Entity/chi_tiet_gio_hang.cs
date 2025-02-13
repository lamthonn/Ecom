using Ecom.Entity.common;

namespace Ecom.Entity
{
    public class chi_tiet_gio_hang : BaseModel
    {
        public Guid Id { get; set; }
        public Guid chi_tiet_san_pham_id { get; set; }
        public Guid nguoi_dung_id { get; set; }
        public virtual chi_tiet_san_pham chi_tiet_san_pham { get; set; }
        public virtual account account { get; set; }
    }
}
