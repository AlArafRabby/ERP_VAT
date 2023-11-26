using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class ContractualProduction
    {
        public ContractualProduction()
        {
            ContractualProductionProductDetails = new HashSet<ContractualProductionProductDetail>();
            ContractualProductionTransferRawMaterials = new HashSet<ContractualProductionTransferRawMaterial>();
            ProductionReceives = new HashSet<ProductionReceive>();
        }

        public int ContractualProductionId { get; set; }
        public int? ContractTypeId { get; set; }
        public int OrganizationId { get; set; }
        public string? ChallanNo { get; set; }
        public string ContractNo { get; set; } = null!;
        public int? VendorId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime ContractDate { get; set; }
        public bool IsClosed { get; set; }
        public DateTime ClosingDate { get; set; }
        public int? ClosedBy { get; set; }
        public string? ReferenceKey { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public long? ApiTransactionId { get; set; }

        public virtual ContractType? ContractType { get; set; }
        public virtual Customer? Customer { get; set; }
        public virtual Vendor? Vendor { get; set; }
        public virtual ICollection<ContractualProductionProductDetail> ContractualProductionProductDetails { get; set; }
        public virtual ICollection<ContractualProductionTransferRawMaterial> ContractualProductionTransferRawMaterials { get; set; }
        public virtual ICollection<ProductionReceive> ProductionReceives { get; set; }
    }
}
