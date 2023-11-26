using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class SalesPriceAdjustmentDetail
    {
        public int SalesPriceAdjustmentDetailId { get; set; }
        public int SalesPriceAdjustmentId { get; set; }
        public int ProductId { get; set; }
        public int SalesDetailId { get; set; }
        public decimal QuantityToChange { get; set; }
        public decimal ChangeAmountPerItem { get; set; }
        public int MeasurementUnitId { get; set; }
        public string ReasonOfChange { get; set; } = null!;
        public string? ReferenceKey { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual MeasurementUnit MeasurementUnit { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
        public virtual SalesDetail SalesDetail { get; set; } = null!;
        public virtual SalesPriceAdjustment SalesPriceAdjustment { get; set; } = null!;
    }
}
