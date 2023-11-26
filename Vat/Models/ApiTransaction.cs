using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class ApiTransaction
    {
        public ApiTransaction()
        {
            OverHeadCosts = new HashSet<OverHeadCost>();
        }

        public long ApiTransactionId { get; set; }
        public int ApiTransactionTypeId { get; set; }
        public string? SecurityToken { get; set; }
        public int NumberOfItem { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual ApiTransactionType ApiTransactionType { get; set; } = null!;
        public virtual ICollection<OverHeadCost> OverHeadCosts { get; set; }
    }
}
