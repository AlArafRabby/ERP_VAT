using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class PurchaseImportTariff
    {
        public long PurchaseImportTariffId { get; set; }
        public string HsCode { get; set; } = null!;
        public string ItemDescription { get; set; } = null!;
        public decimal IdPercent { get; set; }
        public decimal CdPercent { get; set; }
        public decimal SdPercent { get; set; }
        public decimal VatPercent { get; set; }
        public decimal AitPercent { get; set; }
        public decimal RdPercent { get; set; }
        public decimal AtPercent { get; set; }
        public decimal? TtiPercent { get; set; }
        public int ProductVatTypeId { get; set; }
        public bool IsActive { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public DateTime? EffectiveTo { get; set; }
    }
}
