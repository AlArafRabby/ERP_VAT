using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class DistrictOrCity
    {
        public DistrictOrCity()
        {
            Customers = new HashSet<Customer>();
            MushakReturnPayments = new HashSet<MushakReturnPayment>();
            VendorBankBranchDistrictOrCities = new HashSet<Vendor>();
            VendorDistrictOrCities = new HashSet<Vendor>();
        }

        public int DistrictOrCityId { get; set; }
        public int OrganizationId { get; set; }
        public int DivisionOrStateId { get; set; }
        public string DistrictOrCityName { get; set; } = null!;
        public string? DistrictOrCityShortName { get; set; }
        public string? ReferenceKey { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }

        public virtual DivisionOrState DivisionOrState { get; set; } = null!;
        public virtual Organization Organization { get; set; } = null!;
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<MushakReturnPayment> MushakReturnPayments { get; set; }
        public virtual ICollection<Vendor> VendorBankBranchDistrictOrCities { get; set; }
        public virtual ICollection<Vendor> VendorDistrictOrCities { get; set; }
    }
}
