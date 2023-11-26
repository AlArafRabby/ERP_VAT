using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class ProductVattype
    {
        public ProductVattype()
        {
            ProductVats = new HashSet<ProductVat>();
            PurchaseDetails = new HashSet<PurchaseDetail>();
            SalesDetails = new HashSet<SalesDetail>();
        }

        public int ProductVattypeId { get; set; }
        public string Name { get; set; } = null!;
        public string NameInBangla { get; set; } = null!;
        public decimal DefaultVatPercent { get; set; }
        public bool IsVatapplicable { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public DateTime? EffectiveTo { get; set; }
        public bool IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public bool IsApplicableForLocalPurchase { get; set; }
        public bool IsApplicableForImport { get; set; }
        public bool IsApplicableForLocalSale { get; set; }
        public bool IsApplicableForExport { get; set; }
        public bool IsRequireVds { get; set; }
        public string? LocalPurchaseNote { get; set; }
        public string? LocalPurchaseNoteInBn { get; set; }
        public string? ImportNote { get; set; }
        public string? ImportNoteInBn { get; set; }
        public string? LocalSaleNote { get; set; }
        public string? LocalSaleNoteInBn { get; set; }
        public string? ExportNote { get; set; }
        public string? ExportNoteInBn { get; set; }
        public bool IsVatUpdatable { get; set; }

        public virtual ICollection<ProductVat> ProductVats { get; set; }
        public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; }
        public virtual ICollection<SalesDetail> SalesDetails { get; set; }
    }
}
