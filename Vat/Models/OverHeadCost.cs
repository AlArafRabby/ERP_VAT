using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class OverHeadCost
    {
        public OverHeadCost()
        {
            PriceSetupProductCosts = new HashSet<PriceSetupProductCost>();
        }

        public int OverHeadCostId { get; set; }
        public int? OrganizationId { get; set; }
        public string Name { get; set; } = null!;
        public bool IsActive { get; set; }
        public bool IsApplicableAsRawMaterial { get; set; }
        public string? ReferenceKey { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public long? ApiTransactionId { get; set; }

        public virtual ApiTransaction? ApiTransaction { get; set; }
        public virtual ICollection<PriceSetupProductCost> PriceSetupProductCosts { get; set; }
    }
}
