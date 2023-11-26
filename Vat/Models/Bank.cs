using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class Bank
    {
        public Bank()
        {
            Customers = new HashSet<Customer>();
            MushakReturnPayments = new HashSet<MushakReturnPayment>();
            PurchaseImportTaxPayments = new HashSet<PurchaseImportTaxPayment>();
            PurchasePayments = new HashSet<PurchasePayment>();
            Purchases = new HashSet<Purchase>();
            Sales = new HashSet<Sale>();
            SalesPaymentReceives = new HashSet<SalesPaymentReceive>();
            Vendors = new HashSet<Vendor>();
        }

        public int BankId { get; set; }
        public int OrganizationId { get; set; }
        public string Name { get; set; } = null!;
        public string NameInBangla { get; set; } = null!;
        public string? ReferenceKey { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public long? ApiTransactionId { get; set; }
        public long? ExcelDataUploadId { get; set; }

        public virtual Organization Organization { get; set; } = null!;
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<MushakReturnPayment> MushakReturnPayments { get; set; }
        public virtual ICollection<PurchaseImportTaxPayment> PurchaseImportTaxPayments { get; set; }
        public virtual ICollection<PurchasePayment> PurchasePayments { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
        public virtual ICollection<SalesPaymentReceive> SalesPaymentReceives { get; set; }
        public virtual ICollection<Vendor> Vendors { get; set; }
    }
}
