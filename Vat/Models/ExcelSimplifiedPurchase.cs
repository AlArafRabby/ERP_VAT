﻿using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class ExcelSimplifiedPurchase
    {
        public long ExcelSimplifiedPurchaseId { get; set; }
        public long ExcelDataUploadId { get; set; }
        public bool IsProcessed { get; set; }
        public string PurchaseId { get; set; } = null!;
        public DateTime? PurchaseDate { get; set; }
        public string? InvoiceNo { get; set; }
        public string? ChallanNo { get; set; }
        public DateTime? ChallanDate { get; set; }
        public string? BranchId { get; set; }
        public string? BranchName { get; set; }
        public string? BranchAddress { get; set; }
        public string? PurchaseType { get; set; }
        public string? VendorId { get; set; }
        public string? VendorName { get; set; }
        public string? VendorNid { get; set; }
        public string? VendorTin { get; set; }
        public string? VendorBin { get; set; }
        public string? VendorAddress { get; set; }
        public string? PurchaseDetailId { get; set; }
        public string ProductId { get; set; } = null!;
        public string ProductName { get; set; } = null!;
        public string? HsCode { get; set; }
        public string? ProductGroupName { get; set; }
        public string? ProductType { get; set; }
        public string? MeasurementUnitName { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal? DiscountPerItem { get; set; }
        public string? VatType { get; set; }
        public decimal VatPercent { get; set; }
        public decimal? SupplementaryDutyPercent { get; set; }
        public bool? IsVds { get; set; }
        public decimal? VdsAmount { get; set; }
        public bool? IsTds { get; set; }
        public decimal? TdsAmount { get; set; }
        public string? PaymentId { get; set; }
        public string? PaymentMethod { get; set; }
        public string? PaymentTransactionId { get; set; }
        public string? PaymentWalletNo { get; set; }
        public string? ChequeBankName { get; set; }
        public string? ChequeNo { get; set; }
        public DateTime? ChequeDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public decimal? PaymentAmount { get; set; }
        public bool? IsSuccessfullyProcessed { get; set; }
        public string? ProcessingMessage { get; set; }
        public bool? IsDuplicateEntry { get; set; }

        public virtual ExcelDataUpload ExcelDataUpload { get; set; } = null!;
    }
}
