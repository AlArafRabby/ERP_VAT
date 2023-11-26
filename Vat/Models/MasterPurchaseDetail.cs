using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class MasterPurchaseDetail
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public int? Qty { get; set; }
        public decimal? Price { get; set; }
        public long? PurchaseId { get; set; }

        public virtual MasterPurchase? Purchase { get; set; }
    }
}
