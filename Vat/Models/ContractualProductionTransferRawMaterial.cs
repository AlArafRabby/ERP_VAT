﻿using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class ContractualProductionTransferRawMaterial
    {
        public ContractualProductionTransferRawMaterial()
        {
            ContractualProductionTransferRawMaterialDetails = new HashSet<ContractualProductionTransferRawMaterialDetail>();
        }

        public int ContractualProductionTransferRawMaterialId { get; set; }
        public int ContractualProductionId { get; set; }
        public DateTime TransfereDate { get; set; }
        public string Location { get; set; } = null!;
        public string ChallanNo { get; set; } = null!;
        public DateTime ChallanIssueDate { get; set; }
        public string? ReferenceKey { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public long? ApiTransactionId { get; set; }
        public int? VehicleTypeId { get; set; }
        public string? VehicleName { get; set; }
        public string? VehicleRegNo { get; set; }
        public string? VehicleDriverName { get; set; }
        public string? VehicleDriverContactNo { get; set; }

        public virtual ContractualProduction ContractualProduction { get; set; } = null!;
        public virtual VehicleType? VehicleType { get; set; }
        public virtual ICollection<ContractualProductionTransferRawMaterialDetail> ContractualProductionTransferRawMaterialDetails { get; set; }
    }
}
