using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class PurchaseDetail
    {
        public PurchaseDetail()
        {
            DamageDetails = new HashSet<DamageDetail>();
            DebitNoteDetails = new HashSet<DebitNoteDetail>();
            ProductTransactionBooks = new HashSet<ProductTransactionBook>();
        }

        public int PurchaseDetailId { get; set; }
        public int PurchaseId { get; set; }
        public int ProductId { get; set; }
        public string? ProductDescription { get; set; }
        public string? Hscode { get; set; }
        public string? ProductCode { get; set; }
        public string? PartNo { get; set; }
        public string? GoodsId { get; set; }
        public string? Skuno { get; set; }
        public string? Skuid { get; set; }
        public int ProductVattypeId { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal DiscountPerItem { get; set; }
        public decimal CustomDutyPercent { get; set; }
        public decimal ImportDutyPercent { get; set; }
        public decimal RegulatoryDutyPercent { get; set; }
        public decimal SupplementaryDutyPercent { get; set; }
        public decimal Vatpercent { get; set; }
        public decimal AdvanceTaxPercent { get; set; }
        public decimal AdvanceIncomeTaxPercent { get; set; }
        public int MeasurementUnitId { get; set; }
        public string? ReferenceKey { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual MeasurementUnit MeasurementUnit { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
        public virtual ProductVattype ProductVattype { get; set; } = null!;
        public virtual Purchase Purchase { get; set; } = null!;
        public virtual ICollection<DamageDetail> DamageDetails { get; set; }
        public virtual ICollection<DebitNoteDetail> DebitNoteDetails { get; set; }
        public virtual ICollection<ProductTransactionBook> ProductTransactionBooks { get; set; }
    }
}
