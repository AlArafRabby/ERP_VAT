using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class OrganizationConfigurationDecimalType
    {
        public int OrganizationConfigurationDecimalTypeId { get; set; }
        public int OrganizationConfigurationAreaId { get; set; }
        public string OrganizationConfigurationDecimalTypeName { get; set; } = null!;
        public decimal DefaultValue { get; set; }

        public virtual OrganizationConfigurationArea OrganizationConfigurationArea { get; set; } = null!;
    }
}
