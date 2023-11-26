using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class VehicleType
    {
        public VehicleType()
        {
            BranchTransferReceives = new HashSet<BranchTransferReceive>();
            BranchTransferSends = new HashSet<BranchTransferSend>();
            ContractualProductionTransferRawMaterials = new HashSet<ContractualProductionTransferRawMaterial>();
            CreditNotes = new HashSet<CreditNote>();
            Sales = new HashSet<Sale>();
        }

        public int VehicleTypeId { get; set; }
        public int OrganizationId { get; set; }
        public string VehicleTypeName { get; set; } = null!;
        public bool IsRequireRegistration { get; set; }
        public string? Description { get; set; }
        public string? ReferenceKey { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual Organization Organization { get; set; } = null!;
        public virtual ICollection<BranchTransferReceive> BranchTransferReceives { get; set; }
        public virtual ICollection<BranchTransferSend> BranchTransferSends { get; set; }
        public virtual ICollection<ContractualProductionTransferRawMaterial> ContractualProductionTransferRawMaterials { get; set; }
        public virtual ICollection<CreditNote> CreditNotes { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
