using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class OrganizationConfigurationStringType
    {
        public int OrganizationConfigurationStringTypeId { get; set; }
        public int OrganizationConfigurationAreaId { get; set; }
        public string OrganizationConfigurationStringTypeName { get; set; } = null!;
        public string DefaultValue { get; set; } = null!;

        public virtual OrganizationConfigurationArea OrganizationConfigurationArea { get; set; } = null!;
    }
}
