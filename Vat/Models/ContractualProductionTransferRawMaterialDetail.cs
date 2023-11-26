using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class ContractualProductionTransferRawMaterialDetail
    {
        public int ContractualProductionTransferRawMaterialDetailsId { get; set; }
        public int ContractualProductionTransferRawMaterialId { get; set; }
        public int RawMaterialId { get; set; }
        public int MeasurementUnitId { get; set; }
        public decimal Quantity { get; set; }
        public string? ReferenceKey { get; set; }

        public virtual ContractualProductionTransferRawMaterial ContractualProductionTransferRawMaterial { get; set; } = null!;
        public virtual MeasurementUnit MeasurementUnit { get; set; } = null!;
        public virtual Product RawMaterial { get; set; } = null!;
    }
}
