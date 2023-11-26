using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class PurchaseReason
    {
        public PurchaseReason()
        {
            Purchases = new HashSet<Purchase>();
        }

        public int PurchaseReasonId { get; set; }
        public string Reason { get; set; } = null!;
        public bool IsRebatable { get; set; }
        public bool IsForOfficeUse { get; set; }
        public bool IsForFactoryUse { get; set; }

        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}
