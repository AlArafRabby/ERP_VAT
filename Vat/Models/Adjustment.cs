using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class Adjustment
    {
        public int AdjustmentId { get; set; }
        public int AdjustmentTypeId { get; set; }
        public int OrganizationId { get; set; }
        public decimal Amount { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public bool IsActive { get; set; }
        public string? Description { get; set; }
        public string? ReferenceKey { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public long? ApiTransactionId { get; set; }

        public virtual AdjustmentType AdjustmentType { get; set; } = null!;
        public virtual Organization Organization { get; set; } = null!;
    }
}
