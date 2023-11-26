using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class NbrEconomicCode
    {
        public NbrEconomicCode()
        {
            MushakReturnPaymentTypes = new HashSet<MushakReturnPaymentType>();
            Purchases = new HashSet<Purchase>();
        }

        public int NbrEconomicCodeId { get; set; }
        public int NbrEconomicCodeTypeId { get; set; }
        public string EconomicTitle { get; set; } = null!;
        public string EconomicCode { get; set; } = null!;
        public string Code1stDisit { get; set; } = null!;
        public string Code2ndDisit { get; set; } = null!;
        public string Code3rdDisit { get; set; } = null!;
        public string Code4thDisit { get; set; } = null!;
        public string Code5thDisit { get; set; } = null!;
        public string Code6thDisit { get; set; } = null!;
        public string Code7thDisit { get; set; } = null!;
        public string Code8thDisit { get; set; } = null!;
        public string Code9thDisit { get; set; } = null!;
        public string Code10thDisit { get; set; } = null!;
        public string Code11thDisit { get; set; } = null!;
        public string Code12thDisit { get; set; } = null!;
        public string Code13thDisit { get; set; } = null!;
        public bool IsActive { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public DateTime? EffectiveTo { get; set; }

        public virtual NbrEconomicCodeType NbrEconomicCodeType { get; set; } = null!;
        public virtual ICollection<MushakReturnPaymentType> MushakReturnPaymentTypes { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}
