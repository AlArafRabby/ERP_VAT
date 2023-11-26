using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class SupplimentaryDuty
    {
        public int SupplimentaryDutyId { get; set; }
        public int OrganizationId { get; set; }
        public int ProductId { get; set; }
        public decimal SdPercent { get; set; }
        public bool IsActive { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public DateTime? EffectiveTo { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public long? ApiTransactionId { get; set; }

        public virtual Organization Organization { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
