using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class Country
    {
        public Country()
        {
            CustomerBankBranchCountries = new HashSet<Customer>();
            CustomerCountries = new HashSet<Customer>();
            DivisionOrStates = new HashSet<DivisionOrState>();
            MushakReturnPayments = new HashSet<MushakReturnPayment>();
            OrgBranches = new HashSet<OrgBranch>();
            VendorBankBranchCountries = new HashSet<Vendor>();
            VendorCountries = new HashSet<Vendor>();
        }

        public int CountryId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Customer> CustomerBankBranchCountries { get; set; }
        public virtual ICollection<Customer> CustomerCountries { get; set; }
        public virtual ICollection<DivisionOrState> DivisionOrStates { get; set; }
        public virtual ICollection<MushakReturnPayment> MushakReturnPayments { get; set; }
        public virtual ICollection<OrgBranch> OrgBranches { get; set; }
        public virtual ICollection<Vendor> VendorBankBranchCountries { get; set; }
        public virtual ICollection<Vendor> VendorCountries { get; set; }
    }
}
