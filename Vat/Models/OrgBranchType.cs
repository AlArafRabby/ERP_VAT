using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class OrgBranchType
    {
        public OrgBranchType()
        {
            OrgBranches = new HashSet<OrgBranch>();
        }

        public int OrgBranchTypeId { get; set; }
        public string BranchTypeName { get; set; } = null!;
        public string BranchTypeNameBangla { get; set; } = null!;

        public virtual ICollection<OrgBranch> OrgBranches { get; set; }
    }
}
