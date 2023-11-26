using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class MushakReturnRefund
    {
        public int MushakReturnRefundId { get; set; }
        public int OrganizationId { get; set; }
        public int MushakYear { get; set; }
        public int MushakMonth { get; set; }
        public bool IsInterestedToGetRefund { get; set; }
        public decimal? InterestedToRefundVatamount { get; set; }
        public decimal? InterestedToRefundSdamount { get; set; }
        public decimal? ApprovedToRefundVatamount { get; set; }
        public decimal? ApprovedToRefundSdamount { get; set; }
        public decimal? RefundedVatamount { get; set; }
        public string? RefundedVatchequeNo { get; set; }
        public DateTime? RefundedVatchequeDate { get; set; }
        public decimal? RefundedSdamount { get; set; }
        public string? RefundedSdchequeNo { get; set; }
        public DateTime? RefundedSdchequeDate { get; set; }
        public string? ReferenceKey { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public long? ApiTransactionId { get; set; }

        public virtual Organization Organization { get; set; } = null!;
    }
}
