﻿using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class ExcelSimplifiedSalse
    {
        public long ExcelSimplifiedSalseId { get; set; }
        public long ExcelDataUploadId { get; set; }
        public bool IsProcessed { get; set; }
        public string SalesId { get; set; } = null!;
        public DateTime? SalesDate { get; set; }
        public string? InvoiceNo { get; set; }
        public string? BranchId { get; set; }
        public string? BranchName { get; set; }
        public string? BranchAddress { get; set; }
        public string? SalesType { get; set; }
        public string? ExportType { get; set; }
        public string? CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerNid { get; set; }
        public string? CustomerTin { get; set; }
        public string? CustomerBin { get; set; }
        public string? CustomerAddress { get; set; }
        public string? CustomerMobile { get; set; }
        public string? CustomerEmail { get; set; }
        public string? ReceiverName { get; set; }
        public string? ReceiverMobile { get; set; }
        public string? VehicleTypeName { get; set; }
        public string? DeliveryAddress { get; set; }
        public string? DeliveryMethod { get; set; }
        public string? VehicleRegistrationNo { get; set; }
        public string? VehicleDriverName { get; set; }
        public string? VehicleDriverMobile { get; set; }
        public string? SalesDetailId { get; set; }
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
        public string? PaymentReceiveId { get; set; }
        public string? PaymentReceiveMethod { get; set; }
        public string? PaymentTransactionId { get; set; }
        public string? PaymentWalletNo { get; set; }
        public string? ChequeBankName { get; set; }
        public string? ChequeNo { get; set; }
        public DateTime? ChequeDate { get; set; }
        public DateTime? PaymentReceiveDate { get; set; }
        public DateTime? BankDepositDate { get; set; }
        public string? MoneyReceiptNumber { get; set; }
        public decimal? PaymentReceiveAmount { get; set; }
        public bool? IsSuccessfullyProcessed { get; set; }
        public string? ProcessingMessage { get; set; }
        public bool? IsDuplicateEntry { get; set; }

        public virtual ExcelDataUpload ExcelDataUpload { get; set; } = null!;
    }
}
