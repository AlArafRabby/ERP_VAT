using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class DefaultPercent
    {
        public byte DefaultPercentId { get; set; }
        public string DefaultPercentFor { get; set; } = null!;
        public decimal DefaultPercentValue { get; set; }
    }
}
