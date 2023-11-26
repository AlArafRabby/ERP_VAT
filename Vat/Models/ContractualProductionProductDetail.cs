using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class ContractualProductionProductDetail
    {
        public int ContractualProductionProductDetailsId { get; set; }
        public int ContractualProductionId { get; set; }
        public int ProductId { get; set; }
        public decimal Quantity { get; set; }
        public int MeasurementUnitId { get; set; }
        public string? ReferenceKey { get; set; }

        public virtual ContractualProduction ContractualProduction { get; set; } = null!;
        public virtual MeasurementUnit MeasurementUnit { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
