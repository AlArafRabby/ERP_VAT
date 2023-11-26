using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class OrganizationConfigurationIntType
    {
        public int OrganizationConfigurationIntTypeId { get; set; }
        public int OrganizationConfigurationAreaId { get; set; }
        public string OrganizationConfigurationIntTypeName { get; set; } = null!;
        public int DefaultValue { get; set; }

        public virtual OrganizationConfigurationArea OrganizationConfigurationArea { get; set; } = null!;
    }
}
