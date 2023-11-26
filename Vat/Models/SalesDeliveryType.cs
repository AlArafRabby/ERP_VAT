using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class SalesDeliveryType
    {
        public SalesDeliveryType()
        {
            Sales = new HashSet<Sale>();
        }

        public int SalesDeliveryTypeId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeliveryDetailRequired { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }
    }
}
