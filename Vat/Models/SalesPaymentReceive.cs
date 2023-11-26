using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class SalesPaymentReceive
    {
        public int SalesPaymentReceiveId { get; set; }
        public int SalesId { get; set; }
        public int ReceivedPaymentMethodId { get; set; }
        public int? BankId { get; set; }
        public string? BankAccountNo { get; set; }
        public string? WalletNo { get; set; }
        public string? DocumentNoOrTransId { get; set; }
        public DateTime? DocumentOrTransDate { get; set; }
        public decimal ReceiveAmount { get; set; }
        public DateTime ReceiveDate { get; set; }
        public string? ReferenceKey { get; set; }
        public string? PaymentRemarks { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public long? ApiTransactionId { get; set; }
        public long? ExcelDataUploadId { get; set; }

        public virtual Bank? Bank { get; set; }
        public virtual PaymentMethod ReceivedPaymentMethod { get; set; } = null!;
        public virtual Sale Sales { get; set; } = null!;
    }
}
