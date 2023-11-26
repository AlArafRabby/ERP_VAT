using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class OrganizationConfigurationArea
    {
        public OrganizationConfigurationArea()
        {
            OrganizationConfigurationBooleanTypes = new HashSet<OrganizationConfigurationBooleanType>();
            OrganizationConfigurationDecimalTypes = new HashSet<OrganizationConfigurationDecimalType>();
            OrganizationConfigurationIntTypes = new HashSet<OrganizationConfigurationIntType>();
            OrganizationConfigurationStringTypes = new HashSet<OrganizationConfigurationStringType>();
        }

        public int OrganizationConfigurationAreaId { get; set; }
        public string OrganizationConfigurationAreaName { get; set; } = null!;

        public virtual ICollection<OrganizationConfigurationBooleanType> OrganizationConfigurationBooleanTypes { get; set; }
        public virtual ICollection<OrganizationConfigurationDecimalType> OrganizationConfigurationDecimalTypes { get; set; }
        public virtual ICollection<OrganizationConfigurationIntType> OrganizationConfigurationIntTypes { get; set; }
        public virtual ICollection<OrganizationConfigurationStringType> OrganizationConfigurationStringTypes { get; set; }
    }
}
