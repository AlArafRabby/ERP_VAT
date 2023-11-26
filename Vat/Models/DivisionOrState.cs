using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class DivisionOrState
    {
        public DivisionOrState()
        {
            DistrictOrCities = new HashSet<DistrictOrCity>();
            Vendors = new HashSet<Vendor>();
        }

        public int DivisionOrStateId { get; set; }
        public int OrganizationId { get; set; }
        public int CountryId { get; set; }
        public string DivisionOrStateName { get; set; } = null!;
        public string? DivisionOrStateShortName { get; set; }
        public string? ReferenceKey { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }

        public virtual Country Country { get; set; } = null!;
        public virtual Organization Organization { get; set; } = null!;
        public virtual ICollection<DistrictOrCity> DistrictOrCities { get; set; }
        public virtual ICollection<Vendor> Vendors { get; set; }
    }
}
