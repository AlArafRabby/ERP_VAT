using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class PurchaseImportTaxPaymentType
    {
        public PurchaseImportTaxPaymentType()
        {
            PurchaseImportTaxPayments = new HashSet<PurchaseImportTaxPayment>();
        }

        public int PurchaseImportTaxPaymentTypeId { get; set; }
        public string PaymentTypeName { get; set; } = null!;
        public string PaymentTypeShortName { get; set; } = null!;
        public bool IsTotal { get; set; }

        public virtual ICollection<PurchaseImportTaxPayment> PurchaseImportTaxPayments { get; set; }
    }
}
