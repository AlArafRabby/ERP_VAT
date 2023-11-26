using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class BranchTransferReceiveDetail
    {
        public BranchTransferReceiveDetail()
        {
            ProductTransactionBooks = new HashSet<ProductTransactionBook>();
        }

        public int BranchTransferReceiveDetailId { get; set; }
        public int BranchTransferSendDetailId { get; set; }
        public int BranchTransferReceiveId { get; set; }
        public int ProductId { get; set; }
        public string? ProductDescription { get; set; }
        public string? Hscode { get; set; }
        public string? ProductCode { get; set; }
        public string? PartNo { get; set; }
        public string? GoodsId { get; set; }
        public string? Skuno { get; set; }
        public string? Skuid { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public int MeasurementUnitId { get; set; }
        public string? ReferenceKey { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual BranchTransferReceive BranchTransferReceive { get; set; } = null!;
        public virtual BranchTransferSendDetail BranchTransferSendDetail { get; set; } = null!;
        public virtual MeasurementUnit MeasurementUnit { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
        public virtual ICollection<ProductTransactionBook> ProductTransactionBooks { get; set; }
    }
}
