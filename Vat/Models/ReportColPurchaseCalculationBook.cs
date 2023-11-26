using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class ReportColPurchaseCalculationBook
    {
        public long? SlNo { get; set; }
        public DateTime OperationTime { get; set; }
        public string? OperationType { get; set; }
        public string? OperationTypeBn { get; set; }
        public int OrganizationId { get; set; }
        public string OrganizationName { get; set; } = null!;
        public string OrganizationAddress { get; set; } = null!;
        public string? OrganizationBin { get; set; }
        public string OrganizationBranchName { get; set; } = null!;
        public string OrganizationBranchAddress { get; set; } = null!;
        public int? PurchaseDetailId { get; set; }
        public int? PurchaseId { get; set; }
        public string? InvoiceNo { get; set; }
        public string? VendorInvoiceNo { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public decimal InitialQty { get; set; }
        public decimal? InitPriceWithoutVat { get; set; }
        public string? VatChallanOrBillOfEntry { get; set; }
        public DateTime? VatChallanOrBillOfEntryDate { get; set; }
        public string? VendorName { get; set; }
        public string? VendorAddress { get; set; }
        public string? VendorBinOrNid { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string? ProductDescription { get; set; }
        public decimal? PurchaseQty { get; set; }
        public decimal? PriceWithoutVat { get; set; }
        public decimal? SupplimentaryDuty { get; set; }
        public decimal? Vatamount { get; set; }
        public decimal? TotalProdQty { get; set; }
        public decimal? TotalProdPrice { get; set; }
        public decimal? UsedInProductionQty { get; set; }
        public decimal? PriceWithoutVatForUsedInProduction { get; set; }
        public decimal? ClosingProdQty { get; set; }
        public decimal? ClosingTotalPrice { get; set; }
        public int MeasurementUnitId { get; set; }
        public string MeasurementUnitName { get; set; } = null!;
        public string? TransactionNote { get; set; }
        public string? Remarks { get; set; }
    }
}
