using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class ReportColSalesReport
    {
        public int SlNo { get; set; }
        public int SalesId { get; set; }
        public string? InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string? VatChallanNo { get; set; }
        public DateTime? VatChallanPrintedTime { get; set; }
        public int OrganizationId { get; set; }
        public string OrganizationName { get; set; } = null!;
        public string? OrganizationBin { get; set; }
        public string OrganizationAddress { get; set; } = null!;
        public int? OrgBranchId { get; set; }
        public string? BranchName { get; set; }
        public string? BranchAddress { get; set; }
        public int? CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerBinOrNid { get; set; }
        public string? CustomerAddress { get; set; }
        public string? ShippingAddress { get; set; }
        public int SalesSlNo { get; set; }
        public int NoOfIteams { get; set; }
        public decimal TotalPriceWithoutVat { get; set; }
        public decimal DiscountOnTotalPrice { get; set; }
        public decimal TotalDiscountOnIndividualProduct { get; set; }
        public decimal TotalVat { get; set; }
        public decimal TotalSupplimentaryDuty { get; set; }
        public bool IsVds { get; set; }
        public string IsVdsStatus { get; set; } = null!;
        public decimal? VdsAmount { get; set; }
        public DateTime? VdsDate { get; set; }
        public bool? IsTds { get; set; }
        public string IsTdsStatus { get; set; } = null!;
        public decimal? TdsAmount { get; set; }
        public decimal? ReceivableAmount { get; set; }
        public decimal? PaymentReceiveAmount { get; set; }
        public decimal? PaymentDueAmount { get; set; }
        public DateTime SalesDate { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? VehicleTypeId { get; set; }
        public string? VehicleTypeName { get; set; }
        public string? VehicleName { get; set; }
        public string? VehicleRegNo { get; set; }
        public string? VehicleDriverName { get; set; }
        public string? VehicleDriverContactNo { get; set; }
        public string? SalesRemarks { get; set; }
        public string? Remarks { get; set; }
    }
}
