using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class ProductionReceive
    {
        public ProductionReceive()
        {
            BillOfMaterials = new HashSet<BillOfMaterial>();
            ProductTransactionBooks = new HashSet<ProductTransactionBook>();
        }

        public long ProductionReceiveId { get; set; }
        public string? BatchNo { get; set; }
        public int OrganizationId { get; set; }
        public int? OrgBranchId { get; set; }
        public int ProductionReceiveSlNo { get; set; }
        public int? ProductionId { get; set; }
        public int ProductId { get; set; }
        public int PriceSetupId { get; set; }
        public decimal ReceiveQuantity { get; set; }
        public int MeasurementUnitId { get; set; }
        public DateTime ReceiveTime { get; set; }
        public decimal MaterialCost { get; set; }
        public bool IsActive { get; set; }
        public bool IsContractual { get; set; }
        public int? ContractualProductionId { get; set; }
        public string? ContractualProductionChallanNo { get; set; }
        public string? ReferenceKey { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public long? ApiTransactionId { get; set; }

        public virtual ContractualProduction? ContractualProduction { get; set; }
        public virtual MeasurementUnit MeasurementUnit { get; set; } = null!;
        public virtual OrgBranch? OrgBranch { get; set; }
        public virtual Organization Organization { get; set; } = null!;
        public virtual PriceSetup PriceSetup { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
        public virtual ICollection<BillOfMaterial> BillOfMaterials { get; set; }
        public virtual ICollection<ProductTransactionBook> ProductTransactionBooks { get; set; }
    }
}
