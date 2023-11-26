using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class OrganizationConfigurationBooleanType
    {
        public int OrganizationConfigurationBooleanTypeId { get; set; }
        public int OrganizationConfigurationAreaId { get; set; }
        public string OrganizationConfigurationBooleanTypeName { get; set; } = null!;
        public bool DefaultValue { get; set; }

        public virtual OrganizationConfigurationArea OrganizationConfigurationArea { get; set; } = null!;
    }
}
