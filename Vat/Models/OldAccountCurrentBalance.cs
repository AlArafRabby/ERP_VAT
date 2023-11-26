using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class OldAccountCurrentBalance
    {
        public int OldAccountCurrentBalanceId { get; set; }
        public int OrganizationId { get; set; }
        public int MushakYear { get; set; }
        public int MushakMonth { get; set; }
        public decimal RemainingVatbalance { get; set; }
        public decimal RemainingSdbalance { get; set; }
        public string? ReferenceKey { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public long? ApiTransactionId { get; set; }

        public virtual Organization Organization { get; set; } = null!;
    }
}
