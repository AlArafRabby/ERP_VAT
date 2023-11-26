using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class CustomsAndVatcommissionarate
    {
        public CustomsAndVatcommissionarate()
        {
            Customers = new HashSet<Customer>();
            MushakReturnPayments = new HashSet<MushakReturnPayment>();
            Organizations = new HashSet<Organization>();
            PurchaseImportTaxPayments = new HashSet<PurchaseImportTaxPayment>();
            Purchases = new HashSet<Purchase>();
            Vendors = new HashSet<Vendor>();
        }

        public int CustomsAndVatcommissionarateId { get; set; }
        public string Name { get; set; } = null!;
        public string NameInBangla { get; set; } = null!;
        public int DistrictId { get; set; }
        public string Address { get; set; } = null!;
        public string OperationalCode { get; set; } = null!;
        public string OperationalCode1stDigit { get; set; } = null!;
        public string OperationalCode2ndDigit { get; set; } = null!;
        public string OperationalCode3rdDigit { get; set; } = null!;
        public string OperationalCode4thDigit { get; set; } = null!;
        public bool IsActive { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<MushakReturnPayment> MushakReturnPayments { get; set; }
        public virtual ICollection<Organization> Organizations { get; set; }
        public virtual ICollection<PurchaseImportTaxPayment> PurchaseImportTaxPayments { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
        public virtual ICollection<Vendor> Vendors { get; set; }
    }
}
