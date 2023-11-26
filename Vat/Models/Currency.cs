using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class Currency
    {
        public int CurrencyId { get; set; }
        public string CurrencyName { get; set; } = null!;
        public string CurrencyCode { get; set; } = null!;
        public string CurrencySymbol { get; set; } = null!;
        public bool IsDefaultCurrency { get; set; }
    }
}
