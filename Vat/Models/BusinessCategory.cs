using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class BusinessCategory
    {
        public BusinessCategory()
        {
            Customers = new HashSet<Customer>();
            Organizations = new HashSet<Organization>();
            Vendors = new HashSet<Vendor>();
        }

        public int BusinessCategoryId { get; set; }
        public string Name { get; set; } = null!;
        public string NameInBangla { get; set; } = null!;

        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Organization> Organizations { get; set; }
        public virtual ICollection<Vendor> Vendors { get; set; }
    }
}
