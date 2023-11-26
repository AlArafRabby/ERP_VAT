using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class Vendor
    {
        public Vendor()
        {
            ContractualProductions = new HashSet<ContractualProduction>();
            Purchases = new HashSet<Purchase>();
        }

        public int VendorId { get; set; }
        public int? OrganizationId { get; set; }
        public int? VendorOrganizationId { get; set; }
        public string Name { get; set; } = null!;
        public string? AccountCode { get; set; }
        public string? BinNo { get; set; }
        public string? NationalIdNo { get; set; }
        public string? Tinno { get; set; }
        public bool? IsVds { get; set; }
        public decimal? Vdsrate { get; set; }
        public bool? IsTds { get; set; }
        public decimal? Tdsrate { get; set; }
        public bool? IsRegisteredUnderActNinetyFour { get; set; }
        public string? RegistrationNumberUnderActNinetyFour { get; set; }
        public int? CustomsAndVatcommissionarateId { get; set; }
        public string? ServiceVatCode { get; set; }
        public int? CountryId { get; set; }
        public int? DistrictOrCityId { get; set; }
        public int? DivisionOrStateId { get; set; }
        public string Address { get; set; } = null!;
        public string? PostCode { get; set; }
        public string? ContactNo { get; set; }
        public string? EmailAddress { get; set; }
        public bool IsActive { get; set; }
        public string? ContactPerson { get; set; }
        public string? ContactPersonDesignation { get; set; }
        public string? ContactPersonMobile { get; set; }
        public string? ContactPersonEmailAddress { get; set; }
        public string? BankAccountNo { get; set; }
        public string? BankRoutingCode { get; set; }
        public int? BankId { get; set; }
        public string? BankBranchName { get; set; }
        public int? BankBranchCountryId { get; set; }
        public int? BankBranchDistrictOrCityId { get; set; }
        public string? BankBranchAddress { get; set; }
        public int? BusinessNatureId { get; set; }
        public int? BusinessCategoryId { get; set; }
        public string? BusinessCategoryDescription { get; set; }
        public bool IsRegisteredAsTurnOverOrg { get; set; }
        public bool IsRegistered { get; set; }
        public bool IsForeignVendor { get; set; }
        public string? ReferenceKey { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public long? ApiTransactionId { get; set; }
        public long? ExcelDataUploadId { get; set; }

        public virtual Bank? Bank { get; set; }
        public virtual Country? BankBranchCountry { get; set; }
        public virtual DistrictOrCity? BankBranchDistrictOrCity { get; set; }
        public virtual BusinessCategory? BusinessCategory { get; set; }
        public virtual BusinessNature? BusinessNature { get; set; }
        public virtual Country? Country { get; set; }
        public virtual CustomsAndVatcommissionarate? CustomsAndVatcommissionarate { get; set; }
        public virtual DistrictOrCity? DistrictOrCity { get; set; }
        public virtual DivisionOrState? DivisionOrState { get; set; }
        public virtual Organization? Organization { get; set; }
        public virtual ICollection<ContractualProduction> ContractualProductions { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}
