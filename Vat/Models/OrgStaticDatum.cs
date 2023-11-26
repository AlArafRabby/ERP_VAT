using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class OrgStaticDatum
    {
        public int OrgStaticDataId { get; set; }
        public int OrgStaticDataTypeId { get; set; }
        public int DataKey { get; set; }
        public int OrganizationId { get; set; }
        public bool IsActive { get; set; }
        public string? ReferenceKey { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public DateTime? EffectiveTo { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }

        public virtual OrgStaticDataType OrgStaticDataType { get; set; } = null!;
        public virtual Organization Organization { get; set; } = null!;
    }
}
