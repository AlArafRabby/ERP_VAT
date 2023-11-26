using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class NbrEconomicCodeType
    {
        public NbrEconomicCodeType()
        {
            NbrEconomicCodes = new HashSet<NbrEconomicCode>();
        }

        public int NbrEconomicCodeTypeId { get; set; }
        public string CodeTypeName { get; set; } = null!;

        public virtual ICollection<NbrEconomicCode> NbrEconomicCodes { get; set; }
    }
}
