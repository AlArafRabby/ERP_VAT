using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class SalesType
    {
        public SalesType()
        {
            Sales = new HashSet<Sale>();
        }

        public int SalesTypeId { get; set; }
        public string SalesTypeName { get; set; } = null!;
        public string? Description { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }
    }
}
