using Ecom.Entity.common;

namespace Ecom.Entity
{
    public class account_giam_gia : BaseModel
    {
        public Guid Id { get; set; }
        public Guid account_id { get; set; }
        public Guid ma_giam_gia_id { get; set; }
        public virtual account account { get; set; }
        public virtual ma_giam_gia ma_Giam_Gia{ get; set; }
    }
}
