using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class SalesPriceAdjustment
    {
        public SalesPriceAdjustment()
        {
            SalesPriceAdjustmentDetails = new HashSet<SalesPriceAdjustmentDetail>();
        }

        public int SalesPriceAdjustmentId { get; set; }
        public int AdjustmentTypeId { get; set; }
        public int OrganizationId { get; set; }
        public int? OrgBranchId { get; set; }
        public int SalesId { get; set; }
        public string? InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string? ClientNoteNo { get; set; }
        public DateTime? ClientNoteTime { get; set; }
        public string? ReasonOfChange { get; set; }
        public int? MushakGenerationId { get; set; }
        public long? ApiTransactionId { get; set; }
        public int? VehicleTypeId { get; set; }
        public string? VehicleName { get; set; }
        public string? VehicleRegNo { get; set; }
        public string? VehicleDriverName { get; set; }
        public string? VehicleDriverContactNo { get; set; }
        public bool IsNotePrinted { get; set; }
        public string? NoteNo { get; set; }
        public int? NotePrintedBy { get; set; }
        public DateTime? NotePrintedTime { get; set; }
        public string? AdjustmentRemarks { get; set; }
        public string? ReferenceKey { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual AdjustmentType AdjustmentType { get; set; } = null!;
        public virtual OrgBranch? OrgBranch { get; set; }
        public virtual Organization Organization { get; set; } = null!;
        public virtual Sale Sales { get; set; } = null!;
        public virtual ICollection<SalesPriceAdjustmentDetail> SalesPriceAdjustmentDetails { get; set; }
    }
}
