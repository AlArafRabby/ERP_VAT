using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class ProductTransactionBook
    {
        public ProductTransactionBook()
        {
            BillOfMaterials = new HashSet<BillOfMaterial>();
            BranchTransferSendDetails = new HashSet<BranchTransferSendDetail>();
            SalesDetails = new HashSet<SalesDetail>();
        }

        public long ProductTransactionBookId { get; set; }
        public int OrganizationId { get; set; }
        public int? OrgBranchId { get; set; }
        public int TransactionSlNo { get; set; }
        public int ProductId { get; set; }
        public decimal InitUnitPrice { get; set; }
        public decimal InitQty { get; set; }
        public int InitProductMeasurementUnitId { get; set; }
        public int? ProductOpeningBalanceId { get; set; }
        public int? PurchaseDetailId { get; set; }
        public int? DebitNoteDetailId { get; set; }
        public long? UsedInProductionId { get; set; }
        public long? ProductionReceiveId { get; set; }
        public int? SalesDetailId { get; set; }
        public int? CreditNoteDetailId { get; set; }
        public int? DamageDetailId { get; set; }
        public int? BranchTransferSendDetailId { get; set; }
        public int? BranchTransferReceiveDetailId { get; set; }
        public DateTime TransactionTime { get; set; }

        public virtual BranchTransferReceiveDetail? BranchTransferReceiveDetail { get; set; }
        public virtual BranchTransferSendDetail? BranchTransferSendDetail { get; set; }
        public virtual CreditNoteDetail? CreditNoteDetail { get; set; }
        public virtual DamageDetail? DamageDetail { get; set; }
        public virtual DebitNoteDetail? DebitNoteDetail { get; set; }
        public virtual MeasurementUnit InitProductMeasurementUnit { get; set; } = null!;
        public virtual OrgBranch? OrgBranch { get; set; }
        public virtual Organization Organization { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
        public virtual ProductOpeningBalance? ProductOpeningBalance { get; set; }
        public virtual ProductionReceive? ProductionReceive { get; set; }
        public virtual PurchaseDetail? PurchaseDetail { get; set; }
        public virtual SalesDetail? SalesDetail { get; set; }
        public virtual BillOfMaterial? UsedInProduction { get; set; }
        public virtual ICollection<BillOfMaterial> BillOfMaterials { get; set; }
        public virtual ICollection<BranchTransferSendDetail> BranchTransferSendDetails { get; set; }
        public virtual ICollection<SalesDetail> SalesDetails { get; set; }
    }
}
