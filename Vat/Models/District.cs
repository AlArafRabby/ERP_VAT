using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class District
    {
        public District()
        {
            OrgBranches = new HashSet<OrgBranch>();
            PurchaseImportTaxPayments = new HashSet<PurchaseImportTaxPayment>();
        }

        public int DistrictId { get; set; }
        public string Name { get; set; } = null!;
        public string NameInBangla { get; set; } = null!;

        public virtual ICollection<OrgBranch> OrgBranches { get; set; }
        public virtual ICollection<PurchaseImportTaxPayment> PurchaseImportTaxPayments { get; set; }
    }
}
