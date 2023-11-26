using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class PurchaseImportTaxPayment
    {
        public int PurchaseImportTaxPaymentId { get; set; }
        public int PurchaseImportTaxPaymentTypeId { get; set; }
        public int PurchaseId { get; set; }
        public int PitpVatCommissionarateId { get; set; }
        public int PitpBankId { get; set; }
        public string PitpBankBranchName { get; set; } = null!;
        public int PitpBankBranchDistrictId { get; set; }
        public string PitpAccCode { get; set; } = null!;
        public string PitpDocOrChallanNo { get; set; } = null!;
        public DateTime PitpDocOrChallanDate { get; set; }
        public DateTime PitpPaymentDate { get; set; }
        public decimal PitpPaidAmount { get; set; }
        public string? PitpPaymentRemarks { get; set; }

        public virtual Bank PitpBank { get; set; } = null!;
        public virtual District PitpBankBranchDistrict { get; set; } = null!;
        public virtual CustomsAndVatcommissionarate PitpVatCommissionarate { get; set; } = null!;
        public virtual Purchase Purchase { get; set; } = null!;
        public virtual PurchaseImportTaxPaymentType PurchaseImportTaxPaymentType { get; set; } = null!;
    }
}
