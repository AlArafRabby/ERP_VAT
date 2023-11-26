using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class PurchaseType
    {
        public PurchaseType()
        {
            Purchases = new HashSet<Purchase>();
        }

        public int PurchaseTypeId { get; set; }
        public string Name { get; set; } = null!;
        public bool IsActive { get; set; }

        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}
