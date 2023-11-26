using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class CreditNoteDetail
    {
        public CreditNoteDetail()
        {
            ProductTransactionBooks = new HashSet<ProductTransactionBook>();
        }

        public int CreditNoteDetailId { get; set; }
        public int CreditNoteId { get; set; }
        public int SalesDetailId { get; set; }
        public string? ReasonOfReturn { get; set; }
        public decimal ReturnQuantity { get; set; }
        public int MeasurementUnitId { get; set; }
        public string? ReasonOfReturnInDetail { get; set; }
        public string? ReferenceKey { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual CreditNote CreditNote { get; set; } = null!;
        public virtual MeasurementUnit MeasurementUnit { get; set; } = null!;
        public virtual SalesDetail SalesDetail { get; set; } = null!;
        public virtual ICollection<ProductTransactionBook> ProductTransactionBooks { get; set; }
    }
}
