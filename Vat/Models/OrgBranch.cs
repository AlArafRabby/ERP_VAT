using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class OrgBranch
    {
        public OrgBranch()
        {
            BranchTransferReceiveOrgBranchReceivers = new HashSet<BranchTransferReceive>();
            BranchTransferReceiveOrgBranchSenders = new HashSet<BranchTransferReceive>();
            BranchTransferSendOrgBranchReceivers = new HashSet<BranchTransferSend>();
            BranchTransferSendOrgBranchSenders = new HashSet<BranchTransferSend>();
            ProductOpeningBalances = new HashSet<ProductOpeningBalance>();
            ProductTransactionBooks = new HashSet<ProductTransactionBook>();
            ProductionReceives = new HashSet<ProductionReceive>();
            Purchases = new HashSet<Purchase>();
            Sales = new HashSet<Sale>();
            SalesPriceAdjustments = new HashSet<SalesPriceAdjustment>();
        }

        public int OrgBranchId { get; set; }
        public int OrgBranchTypeId { get; set; }
        public int OrganizationId { get; set; }
        public string Name { get; set; } = null!;
        public string? Code { get; set; }
        public int CustomsAndVatcommissionarateId { get; set; }
        public int FinancialActivityNatureId { get; set; }
        public int BusinessNatureId { get; set; }
        public int BusinessCategoryId { get; set; }
        public string? BusinessCategoryDescription { get; set; }
        public bool IsSellStandardVatProduct { get; set; }
        public string? EmailAddress { get; set; }
        public string? Mobile { get; set; }
        public string Address { get; set; } = null!;
        public int CountryId { get; set; }
        public int? DistrictId { get; set; }
        public string VatResponsiblePersonName { get; set; } = null!;
        public string VatResponsiblePersonDesignation { get; set; } = null!;
        public string VatResponsiblePersonMobileNo { get; set; } = null!;
        public string VatResponsiblePersonEmailAddress { get; set; } = null!;
        public string? VatResponsiblePersonSignUrl { get; set; }
        public bool IsActive { get; set; }
        public int? PostalCode { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public long? ApiTransactionId { get; set; }
        public string? ReferenceKey { get; set; }
        public long? ExcelDataUploadId { get; set; }

        public virtual Country Country { get; set; } = null!;
        public virtual District? District { get; set; }
        public virtual OrgBranchType OrgBranchType { get; set; } = null!;
        public virtual Organization Organization { get; set; } = null!;
        public virtual ICollection<BranchTransferReceive> BranchTransferReceiveOrgBranchReceivers { get; set; }
        public virtual ICollection<BranchTransferReceive> BranchTransferReceiveOrgBranchSenders { get; set; }
        public virtual ICollection<BranchTransferSend> BranchTransferSendOrgBranchReceivers { get; set; }
        public virtual ICollection<BranchTransferSend> BranchTransferSendOrgBranchSenders { get; set; }
        public virtual ICollection<ProductOpeningBalance> ProductOpeningBalances { get; set; }
        public virtual ICollection<ProductTransactionBook> ProductTransactionBooks { get; set; }
        public virtual ICollection<ProductionReceive> ProductionReceives { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
        public virtual ICollection<SalesPriceAdjustment> SalesPriceAdjustments { get; set; }
    }
}
