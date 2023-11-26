using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class DeliveryMethod
    {
        public DeliveryMethod()
        {
            Sales = new HashSet<Sale>();
        }

        public int DeliveryMethodId { get; set; }
        public string Name { get; set; } = null!;
        public bool IsDeliveryDetailRequired { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }
    }
}
