﻿using Ecom.Entity.common;

namespace Ecom.Entity
{
    public class san_pham : BaseModel
    {
        public Guid Id { get; set; }
        public Guid danh_muc_id { get; set; }
        public string ma_san_pham { get; set; }
        public string ten_san_pham { get; set; }
        public string? mo_ta { get; set; }
        public string? xuat_xu { get; set; }
        public int? luot_ban { get; set; }
        public string sku { get; set; }
        public string? mau_sac { get; set; }
        public string? size { get; set; }
        public bool? is_active { get; set; } = true;
        public virtual danh_muc danh_Muc { get; set; }
    }
}
