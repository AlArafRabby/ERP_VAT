using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class DamageDetail
    {
        public DamageDetail()
        {
            ProductTransactionBooks = new HashSet<ProductTransactionBook>();
        }

        public int DamageDetailId { get; set; }
        public int DamageId { get; set; }
        public int ProductId { get; set; }
        public int? SalesDetailId { get; set; }
        public int? PurchaseDetailId { get; set; }
        public decimal DamageQty { get; set; }
        public decimal UsableQty { get; set; }
        public decimal? UsablePercent { get; set; }
        public int MeasurementUnitId { get; set; }
        public decimal SuggestedNewUnitPrice { get; set; }
        public string DamageDescription { get; set; } = null!;
        public decimal? ApprovedUsableQty { get; set; }
        public decimal? ApprovedNewUnitPrice { get; set; }

        public virtual Damage Damage { get; set; } = null!;
        public virtual MeasurementUnit MeasurementUnit { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
        public virtual PurchaseDetail? PurchaseDetail { get; set; }
        public virtual SalesDetail? SalesDetail { get; set; }
        public virtual ICollection<ProductTransactionBook> ProductTransactionBooks { get; set; }
    }
}
