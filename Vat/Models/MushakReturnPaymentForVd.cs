using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class MushakReturnPaymentForVd
    {
        public int MushakReturnPaymentForVdsId { get; set; }
        public int MushakReturnPaymentId { get; set; }
        public int PurchaseId { get; set; }
        public decimal VdsPaidAmount { get; set; }

        public virtual MushakReturnPayment MushakReturnPayment { get; set; } = null!;
        public virtual Purchase Purchase { get; set; } = null!;
    }
}
