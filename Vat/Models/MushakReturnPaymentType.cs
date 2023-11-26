using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class MushakReturnPaymentType
    {
        public MushakReturnPaymentType()
        {
            MushakReturnPayments = new HashSet<MushakReturnPayment>();
        }

        public int MushakReturnPaymentTypeId { get; set; }
        public int NbrEconomicCodeId { get; set; }
        public string SubFormId { get; set; } = null!;
        public string SubFormName { get; set; } = null!;
        public string NoteNo { get; set; } = null!;
        public string TypeName { get; set; } = null!;
        public string TypeNameBn { get; set; } = null!;
        public bool IsActive { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public DateTime? EffectiveTo { get; set; }
        public int PaymentReasonId { get; set; }

        public virtual NbrEconomicCode NbrEconomicCode { get; set; } = null!;
        public virtual ICollection<MushakReturnPayment> MushakReturnPayments { get; set; }
    }
}
