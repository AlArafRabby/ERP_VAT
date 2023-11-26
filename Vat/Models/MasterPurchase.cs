using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class MasterPurchase
    {
        public MasterPurchase()
        {
            MasterPurchaseDetails = new HashSet<MasterPurchaseDetail>();
        }

        public long Id { get; set; }
        public string Customername { get; set; } = null!;
        public string? CustomerContactNo { get; set; }
        public string? Description { get; set; }
        public DateTime? PurchaseDate { get; set; }

        public virtual ICollection<MasterPurchaseDetail> MasterPurchaseDetails { get; set; }
    }
}
