using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class FinancialActivityNature
    {
        public FinancialActivityNature()
        {
            Organizations = new HashSet<Organization>();
        }

        public int FinancialActivityNatureId { get; set; }
        public string Name { get; set; } = null!;
        public string NameInBangla { get; set; } = null!;

        public virtual ICollection<Organization> Organizations { get; set; }
    }
}
