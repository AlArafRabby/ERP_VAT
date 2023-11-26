using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class OrganizationConfig
    {
        public int OrganizationConfigId { get; set; }
        public int OrganizationId { get; set; }
        public int OrganizationConfigTypeId { get; set; }
        public string ConfigValue { get; set; } = null!;
        public DateTime EffectiveFrom { get; set; }
        public DateTime? EffectiveTo { get; set; }
        public bool IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual Organization Organization { get; set; } = null!;
        public virtual OrganizationConfigType OrganizationConfigType { get; set; } = null!;
    }
}
