using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class MushakGeneration
    {
        public MushakGeneration()
        {
            CreditNotes = new HashSet<CreditNote>();
            DebitNotes = new HashSet<DebitNote>();
        }

        public int MushakGenerationId { get; set; }
        public int OrganizationId { get; set; }
        public int MushakForYear { get; set; }
        public int MushakForMonth { get; set; }
        public DateTime GenerateDate { get; set; }

        public virtual Organization Organization { get; set; } = null!;
        public virtual ICollection<CreditNote> CreditNotes { get; set; }
        public virtual ICollection<DebitNote> DebitNotes { get; set; }
    }
}
