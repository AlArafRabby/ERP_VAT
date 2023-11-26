using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class AdjustmentType
    {
        public AdjustmentType()
        {
            Adjustments = new HashSet<Adjustment>();
            SalesPriceAdjustments = new HashSet<SalesPriceAdjustment>();
        }

        public int AdjustmentTypeId { get; set; }
        public string Name { get; set; } = null!;
        public string? NameInBangla { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual ICollection<Adjustment> Adjustments { get; set; }
        public virtual ICollection<SalesPriceAdjustment> SalesPriceAdjustments { get; set; }
    }
}
