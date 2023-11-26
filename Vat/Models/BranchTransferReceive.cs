using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class BranchTransferReceive
    {
        public BranchTransferReceive()
        {
            BranchTransferReceiveDetails = new HashSet<BranchTransferReceiveDetail>();
        }

        public int BranchTransferReceiveId { get; set; }
        public int BranchTransferSendId { get; set; }
        public int OrganizationId { get; set; }
        public int OrgBranchSenderId { get; set; }
        public int OrgBranchReceiverId { get; set; }
        public int BranchTransferReceiveSlNo { get; set; }
        public string? InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string? TransferChallanNo { get; set; }
        public int NoOfIteams { get; set; }
        public string? ReceiverName { get; set; }
        public string? ReceiverContactNo { get; set; }
        public DateTime BranchTransferReceiveDate { get; set; }
        public int? VehicleTypeId { get; set; }
        public string? VehicleName { get; set; }
        public string? VehicleRegNo { get; set; }
        public string? VehicleDriverName { get; set; }
        public string? VehicleDriverContactNo { get; set; }
        public string? BranchTransferReceiveRemarks { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
        public bool IsComplete { get; set; }
        public bool IsPosted { get; set; }
        public int? PostedBy { get; set; }
        public DateTime? PostedTime { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string? ReferenceKey { get; set; }
        public long? ApiTransactionId { get; set; }
        public long? ExcelDataUploadId { get; set; }

        public virtual BranchTransferSend BranchTransferSend { get; set; } = null!;
        public virtual OrgBranch OrgBranchReceiver { get; set; } = null!;
        public virtual OrgBranch OrgBranchSender { get; set; } = null!;
        public virtual Organization Organization { get; set; } = null!;
        public virtual VehicleType? VehicleType { get; set; }
        public virtual ICollection<BranchTransferReceiveDetail> BranchTransferReceiveDetails { get; set; }
    }
}
