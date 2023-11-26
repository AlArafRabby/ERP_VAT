using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class PaymentReason
    {
        public int PaymentReasonId { get; set; }
        public string ReasonName { get; set; } = null!;
    }
}
