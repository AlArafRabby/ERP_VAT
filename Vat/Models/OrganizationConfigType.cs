using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class OrganizationConfigType
    {
        public OrganizationConfigType()
        {
            OrganizationConfigs = new HashSet<OrganizationConfig>();
        }

        public int OrganizationConfigTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<OrganizationConfig> OrganizationConfigs { get; set; }
    }
}
