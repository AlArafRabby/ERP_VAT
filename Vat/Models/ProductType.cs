using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class ProductType
    {
        public ProductType()
        {
            Products = new HashSet<Product>();
        }

        public int ProductTypeId { get; set; }
        public string Name { get; set; } = null!;
        public string ShortName { get; set; } = null!;
        public bool IsPurchaseable { get; set; }
        public bool IsSellable { get; set; }
        public bool IsProductionable { get; set; }
        public bool IsInventory { get; set; }
        public bool IsUsedInProduction { get; set; }
        public bool IsTrading { get; set; }
        public bool IsMeasurable { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
