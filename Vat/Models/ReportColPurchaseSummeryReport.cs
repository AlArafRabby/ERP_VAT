using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class ReportColPurchaseSummeryReport
    {
        public long? SlNo { get; set; }
        public int OrganizationId { get; set; }
        public string OrganizationName { get; set; } = null!;
        public string OrganizationAddress { get; set; } = null!;
        public string? OrganizationBin { get; set; }
        public int? OrgBranchId { get; set; }
        public string BranchName { get; set; } = null!;
        public string BranchAddress { get; set; } = null!;
        public string ReceiveAddress { get; set; } = null!;
        public int? VendorId { get; set; }
        public string VendorName { get; set; } = null!;
        public string? VendorBinOrNid { get; set; }
        public string VendorAddress { get; set; } = null!;
        public int PurchaseTypeId { get; set; }
        public string PurchaseTypeName { get; set; } = null!;
        public decimal? TotalPriceWithoutVat { get; set; }
        public decimal? DiscountOnTotalPrice { get; set; }
        public decimal? TotalDiscountOnIndividualProduct { get; set; }
        public decimal? TotalCustomDuty { get; set; }
        public decimal? TotalImportDuty { get; set; }
        public decimal? TotalRegulatoryDuty { get; set; }
        public decimal? TotalSupplementaryDuty { get; set; }
        public decimal? TotalVat { get; set; }
        public decimal? TotalAdvanceTax { get; set; }
        public decimal? TotalAdvanceIncomeTax { get; set; }
        public decimal? TdsAmount { get; set; }
        public decimal? VdsAmount { get; set; }
        public decimal? PayableAmount { get; set; }
        public decimal? PaidAmount { get; set; }
        public decimal? DueAmount { get; set; }
    }
}
