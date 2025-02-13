using Ecom.Entity.common;

namespace Ecom.Entity
{
    public class gio_hang : BaseModel
    {
        public Guid Id { get; set; }
        public Guid nguoi_dung_id { get; set; }
        public virtual account account { get; set; }
    }
}
