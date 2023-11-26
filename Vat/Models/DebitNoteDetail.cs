using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class DebitNoteDetail
    {
        public DebitNoteDetail()
        {
            ProductTransactionBooks = new HashSet<ProductTransactionBook>();
        }

        public int DebitNoteDetailId { get; set; }
        public int DebitNoteId { get; set; }
        public int PurchaseDetailId { get; set; }
        public string? ReasonOfReturn { get; set; }
        public decimal ReturnQuantity { get; set; }
        public int MeasurementUnitId { get; set; }
        public string? ReferenceKey { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual DebitNote DebitNote { get; set; } = null!;
        public virtual MeasurementUnit MeasurementUnit { get; set; } = null!;
        public virtual PurchaseDetail PurchaseDetail { get; set; } = null!;
        public virtual ICollection<ProductTransactionBook> ProductTransactionBooks { get; set; }
    }
}
