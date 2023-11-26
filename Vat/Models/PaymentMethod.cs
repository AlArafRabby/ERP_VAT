using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class PaymentMethod
    {
        public PaymentMethod()
        {
            PurchasePayments = new HashSet<PurchasePayment>();
            SalesPaymentReceives = new HashSet<SalesPaymentReceive>();
        }

        public int PaymentMethodId { get; set; }
        public string Name { get; set; } = null!;
        public bool IsBankingChannel { get; set; }
        public bool IsMobileTransaction { get; set; }
        public bool IsCash { get; set; }
        public bool IsCheque { get; set; }
        public bool IsUseInChallanPayment { get; set; }

        public virtual ICollection<PurchasePayment> PurchasePayments { get; set; }
        public virtual ICollection<SalesPaymentReceive> SalesPaymentReceives { get; set; }
    }
}
