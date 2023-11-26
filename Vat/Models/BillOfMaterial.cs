using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class BillOfMaterial
    {
        public BillOfMaterial()
        {
            ProductTransactionBooks = new HashSet<ProductTransactionBook>();
        }

        public long BillOfMaterialId { get; set; }
        public long ProductionReceiveId { get; set; }
        public int RawMaterialId { get; set; }
        public decimal UsedQuantity { get; set; }
        public int MeasurementUnitId { get; set; }
        public long ProductTransactionBookId { get; set; }
        public string? ReferenceKey { get; set; }
        public bool IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual MeasurementUnit MeasurementUnit { get; set; } = null!;
        public virtual ProductTransactionBook ProductTransactionBook { get; set; } = null!;
        public virtual ProductionReceive ProductionReceive { get; set; } = null!;
        public virtual Product RawMaterial { get; set; } = null!;
        public virtual ICollection<ProductTransactionBook> ProductTransactionBooks { get; set; }
    }
}
