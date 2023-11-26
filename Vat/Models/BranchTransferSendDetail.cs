using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class BranchTransferSendDetail
    {
        public BranchTransferSendDetail()
        {
            BranchTransferReceiveDetails = new HashSet<BranchTransferReceiveDetail>();
            ProductTransactionBooks = new HashSet<ProductTransactionBook>();
        }

        public int BranchTransferSendDetailId { get; set; }
        public int BranchTransferSendId { get; set; }
        public int ProductId { get; set; }
        public string? ProductDescription { get; set; }
        public string? Hscode { get; set; }
        public string? ProductCode { get; set; }
        public string? PartNo { get; set; }
        public string? GoodsId { get; set; }
        public string? Skuno { get; set; }
        public string? Skuid { get; set; }
        public long? ProductTransactionBookId { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public int MeasurementUnitId { get; set; }
        public string? ProductRemarks { get; set; }
        public string? ReferenceKey { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual BranchTransferSend BranchTransferSend { get; set; } = null!;
        public virtual MeasurementUnit MeasurementUnit { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
        public virtual ProductTransactionBook? ProductTransactionBook { get; set; }
        public virtual ICollection<BranchTransferReceiveDetail> BranchTransferReceiveDetails { get; set; }
        public virtual ICollection<ProductTransactionBook> ProductTransactionBooks { get; set; }
    }
}
