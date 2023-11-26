using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class ProductVat
    {
        public int ProductVatid { get; set; }
        public int ProductId { get; set; }
        public int ProductVattypeId { get; set; }
        public decimal ProductDefaultVatPercent { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public DateTime? EffectiveTo { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public long? ApiTransactionId { get; set; }

        public virtual Product Product { get; set; } = null!;
        public virtual ProductVattype ProductVattype { get; set; } = null!;
    }
}
