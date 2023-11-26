using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class SalesDetail
    {
        public SalesDetail()
        {
            CreditNoteDetails = new HashSet<CreditNoteDetail>();
            DamageDetails = new HashSet<DamageDetail>();
            ProductTransactionBooks = new HashSet<ProductTransactionBook>();
            SalesPriceAdjustmentDetails = new HashSet<SalesPriceAdjustmentDetail>();
        }

        public int SalesDetailId { get; set; }
        public int SalesId { get; set; }
        public int ProductId { get; set; }
        public string? ProductDescription { get; set; }
        public string? Hscode { get; set; }
        public string? ProductCode { get; set; }
        public string? PartNo { get; set; }
        public string? GoodsId { get; set; }
        public string? Skuno { get; set; }
        public string? Skuid { get; set; }
        public int ProductVattypeId { get; set; }
        public long? ProductTransactionBookId { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal? ServiceChargePercent { get; set; }
        public decimal DiscountPerItem { get; set; }
        public decimal Vatpercent { get; set; }
        public decimal SupplementaryDutyPercent { get; set; }
        public int MeasurementUnitId { get; set; }
        public string? ReferenceKey { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual MeasurementUnit MeasurementUnit { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
        public virtual ProductTransactionBook? ProductTransactionBook { get; set; }
        public virtual ProductVattype ProductVattype { get; set; } = null!;
        public virtual Sale Sales { get; set; } = null!;
        public virtual ICollection<CreditNoteDetail> CreditNoteDetails { get; set; }
        public virtual ICollection<DamageDetail> DamageDetails { get; set; }
        public virtual ICollection<ProductTransactionBook> ProductTransactionBooks { get; set; }
        public virtual ICollection<SalesPriceAdjustmentDetail> SalesPriceAdjustmentDetails { get; set; }
    }
}
