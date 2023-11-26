using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class PriceSetupProductCost
    {
        public int PriceSetupProductCostId { get; set; }
        public int PriceSetupId { get; set; }
        public int? RawMaterialId { get; set; }
        public decimal? RequiredQty { get; set; }
        public int? MeasurementUnitId { get; set; }
        public int? OverHeadCostId { get; set; }
        public decimal Cost { get; set; }
        public decimal? WastagePercentage { get; set; }
        public bool IsRawMaterial { get; set; }
        public string? ReferenceKey { get; set; }

        public virtual MeasurementUnit? MeasurementUnit { get; set; }
        public virtual OverHeadCost? OverHeadCost { get; set; }
        public virtual PriceSetup PriceSetup { get; set; } = null!;
        public virtual Product? RawMaterial { get; set; }
    }
}
