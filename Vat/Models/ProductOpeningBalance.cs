using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class ProductOpeningBalance
    {
        public ProductOpeningBalance()
        {
            ProductTransactionBooks = new HashSet<ProductTransactionBook>();
        }

        public int ProductOpeningBalanceId { get; set; }
        public int OrganizationId { get; set; }
        public int OrgBranchId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Quantity { get; set; }
        public int MeasurementUnitId { get; set; }
        public string? ReferenceNo { get; set; }
        public int? BookPageNo { get; set; }
        public int? BookSlNo { get; set; }
        public string? ReferenceKey { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }

        public virtual MeasurementUnit MeasurementUnit { get; set; } = null!;
        public virtual OrgBranch OrgBranch { get; set; } = null!;
        public virtual Organization Organization { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
        public virtual ICollection<ProductTransactionBook> ProductTransactionBooks { get; set; }
    }
}
