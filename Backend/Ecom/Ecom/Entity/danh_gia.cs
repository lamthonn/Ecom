using Ecom.Entity.common;

namespace Ecom.Entity
{
    public class danh_gia : BaseModel
    {
        public Guid Id { get; set; }
        public Guid chi_tiet_san_pham_id { get; set; }
        public Guid nguoi_dung_id { get; set; }
        public int danh_gia_chat_luong { get; set; }
        public string? noi_dung_danh_gia { get; set; }
        public virtual chi_tiet_san_pham Chi_Tiet_San_Pham { get; set; }
        public virtual account Account { get; set; }
    }
}
