﻿using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class PurchasePayment
    {
        public int PurchasePaymentId { get; set; }
        public int PurchaseId { get; set; }
        public int PaymentMethodId { get; set; }
        public int? BankId { get; set; }
        public string? BankAccountNo { get; set; }
        public string? WalletNo { get; set; }
        public string? DocumentNoOrTransId { get; set; }
        public DateTime? DocumentOrTransDate { get; set; }
        public decimal PaidAmount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string? ReferenceKey { get; set; }
        public string? PaymentRemarks { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public long? ApiTransactionId { get; set; }
        public long? ExcelDataUploadId { get; set; }

        public virtual Bank? Bank { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; } = null!;
        public virtual Purchase Purchase { get; set; } = null!;
    }
}
