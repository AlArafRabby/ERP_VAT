using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class Brand
    {
        public Brand()
        {
            Products = new HashSet<Product>();
        }

        public int BrandId { get; set; }
        public int OrganizationId { get; set; }
        public string Name { get; set; } = null!;
        public string? NameInBangla { get; set; }
        public string? Description { get; set; }
        public string? ReferenceKey { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public long? ApiTransactionId { get; set; }
        public long? ExcelDataUploadId { get; set; }

        public virtual Organization Organization { get; set; } = null!;
        public virtual ICollection<Product> Products { get; set; }
    }
}
