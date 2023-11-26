using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class OrgStaticDataType
    {
        public OrgStaticDataType()
        {
            OrgStaticData = new HashSet<OrgStaticDatum>();
        }

        public int OrgStaticDataTypeId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<OrgStaticDatum> OrgStaticData { get; set; }
    }
}
