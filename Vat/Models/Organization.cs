using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class Organization
    {
        public Organization()
        {
            Adjustments = new HashSet<Adjustment>();
            AuditLogs = new HashSet<AuditLog>();
            Banks = new HashSet<Bank>();
            BranchTransferReceives = new HashSet<BranchTransferReceive>();
            BranchTransferSends = new HashSet<BranchTransferSend>();
            Brands = new HashSet<Brand>();
            CustomerDeliveryAddresses = new HashSet<CustomerDeliveryAddress>();
            Customers = new HashSet<Customer>();
            Damages = new HashSet<Damage>();
            DistrictOrCities = new HashSet<DistrictOrCity>();
            DivisionOrStates = new HashSet<DivisionOrState>();
            DocumentTypes = new HashSet<DocumentType>();
            MushakGenerations = new HashSet<MushakGeneration>();
            MushakReturnPayments = new HashSet<MushakReturnPayment>();
            MushakReturnRefunds = new HashSet<MushakReturnRefund>();
            MushakSubmissions = new HashSet<MushakSubmission>();
            OldAccountCurrentBalances = new HashSet<OldAccountCurrentBalance>();
            OrgBranches = new HashSet<OrgBranch>();
            OrgStaticData = new HashSet<OrgStaticDatum>();
            OrganizationConfigs = new HashSet<OrganizationConfig>();
            PriceSetups = new HashSet<PriceSetup>();
            ProductCategories = new HashSet<ProductCategory>();
            ProductGroups = new HashSet<ProductGroup>();
            ProductOpeningBalances = new HashSet<ProductOpeningBalance>();
            ProductTransactionBooks = new HashSet<ProductTransactionBook>();
            ProductionReceives = new HashSet<ProductionReceive>();
            Products = new HashSet<Product>();
            PurchaseOrganizations = new HashSet<Purchase>();
            PurchaseTransferBranches = new HashSet<Purchase>();
            Roles = new HashSet<Role>();
            SaleOrganizations = new HashSet<Sale>();
            SaleOtherBranchOrganizations = new HashSet<Sale>();
            SalesPriceAdjustments = new HashSet<SalesPriceAdjustment>();
            SupplimentaryDuties = new HashSet<SupplimentaryDuty>();
            UserLoginHistories = new HashSet<UserLoginHistory>();
            Users = new HashSet<User>();
            VehicleTypes = new HashSet<VehicleType>();
            Vendors = new HashSet<Vendor>();
        }

        public int OrganizationId { get; set; }
        public string Name { get; set; } = null!;
        public int? ParentOrganizationId { get; set; }
        public string? Code { get; set; }
        public string? VatregNo { get; set; }
        public string? Bin { get; set; }
        public int CustomsAndVatcommissionarateId { get; set; }
        public int FinancialActivityNatureId { get; set; }
        public int BusinessNatureId { get; set; }
        public int BusinessCategoryId { get; set; }
        public string? BusinessCategoryDescription { get; set; }
        public bool? IsProductionCompany { get; set; }
        public bool IsDeductVatInSource { get; set; }
        public bool IsSellStandardVatProduct { get; set; }
        public string? CertificateNo { get; set; }
        public string? EmailAddress { get; set; }
        public string? Mobile { get; set; }
        public string Address { get; set; } = null!;
        public int CountryId { get; set; }
        public int CityId { get; set; }
        public string VatResponsiblePersonName { get; set; } = null!;
        public string VatResponsiblePersonDesignation { get; set; } = null!;
        public string VatResponsiblePersonMobileNo { get; set; } = null!;
        public string VatResponsiblePersonEmailAddress { get; set; } = null!;
        public string? VatResponsiblePersonSignUrl { get; set; }
        public bool IsActive { get; set; }
        public int? EnlistedNo { get; set; }
        public int? PostalCode { get; set; }
        public bool? IsSaleSimplified { get; set; }
        public bool? IsImposeServiceCharge { get; set; }
        public decimal? ServiceChargePercent { get; set; }
        public bool? IsUserSignInSalesTaxInvoice { get; set; }
        public bool? IsRequireSku { get; set; }
        public bool? IsRequireSkuId { get; set; }
        public bool? IsRequireGoodsId { get; set; }
        public bool? IsRequirePartNo { get; set; }
        public bool? IsRequireComplecatedInformation { get; set; }
        public string? InvoiceNameEng { get; set; }
        public string? InvoiceNameBan { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }

        public virtual BusinessCategory BusinessCategory { get; set; } = null!;
        public virtual BusinessNature BusinessNature { get; set; } = null!;
        public virtual CustomsAndVatcommissionarate CustomsAndVatcommissionarate { get; set; } = null!;
        public virtual FinancialActivityNature FinancialActivityNature { get; set; } = null!;
        public virtual ICollection<Adjustment> Adjustments { get; set; }
        public virtual ICollection<AuditLog> AuditLogs { get; set; }
        public virtual ICollection<Bank> Banks { get; set; }
        public virtual ICollection<BranchTransferReceive> BranchTransferReceives { get; set; }
        public virtual ICollection<BranchTransferSend> BranchTransferSends { get; set; }
        public virtual ICollection<Brand> Brands { get; set; }
        public virtual ICollection<CustomerDeliveryAddress> CustomerDeliveryAddresses { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Damage> Damages { get; set; }
        public virtual ICollection<DistrictOrCity> DistrictOrCities { get; set; }
        public virtual ICollection<DivisionOrState> DivisionOrStates { get; set; }
        public virtual ICollection<DocumentType> DocumentTypes { get; set; }
        public virtual ICollection<MushakGeneration> MushakGenerations { get; set; }
        public virtual ICollection<MushakReturnPayment> MushakReturnPayments { get; set; }
        public virtual ICollection<MushakReturnRefund> MushakReturnRefunds { get; set; }
        public virtual ICollection<MushakSubmission> MushakSubmissions { get; set; }
        public virtual ICollection<OldAccountCurrentBalance> OldAccountCurrentBalances { get; set; }
        public virtual ICollection<OrgBranch> OrgBranches { get; set; }
        public virtual ICollection<OrgStaticDatum> OrgStaticData { get; set; }
        public virtual ICollection<OrganizationConfig> OrganizationConfigs { get; set; }
        public virtual ICollection<PriceSetup> PriceSetups { get; set; }
        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
        public virtual ICollection<ProductGroup> ProductGroups { get; set; }
        public virtual ICollection<ProductOpeningBalance> ProductOpeningBalances { get; set; }
        public virtual ICollection<ProductTransactionBook> ProductTransactionBooks { get; set; }
        public virtual ICollection<ProductionReceive> ProductionReceives { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Purchase> PurchaseOrganizations { get; set; }
        public virtual ICollection<Purchase> PurchaseTransferBranches { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<Sale> SaleOrganizations { get; set; }
        public virtual ICollection<Sale> SaleOtherBranchOrganizations { get; set; }
        public virtual ICollection<SalesPriceAdjustment> SalesPriceAdjustments { get; set; }
        public virtual ICollection<SupplimentaryDuty> SupplimentaryDuties { get; set; }
        public virtual ICollection<UserLoginHistory> UserLoginHistories { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<VehicleType> VehicleTypes { get; set; }
        public virtual ICollection<Vendor> Vendors { get; set; }
    }
}
