using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class DebitNote
    {
        public DebitNote()
        {
            DebitNoteDetails = new HashSet<DebitNoteDetail>();
        }

        public int DebitNoteId { get; set; }
        public int PurchaseId { get; set; }
        public string VoucherNo { get; set; } = null!;
        public string? DebitNoteChallanNo { get; set; }
        public string? ReasonOfReturn { get; set; }
        public DateTime ReturnDate { get; set; }
        public int? MushakGenerationId { get; set; }
        public string? ReferenceKey { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public long? ApiTransactionId { get; set; }
        public int? VehicleTypeId { get; set; }
        public string? VehicleName { get; set; }
        public string? VehicleRegNo { get; set; }
        public string? VehicleDriverName { get; set; }
        public string? VehicleDriverContactNo { get; set; }
        public bool IsDebitNoteChallanPrinted { get; set; }
        public DateTime? DebitNoteChallanPrintTime { get; set; }

        public virtual MushakGeneration? MushakGeneration { get; set; }
        public virtual Purchase Purchase { get; set; } = null!;
        public virtual ICollection<DebitNoteDetail> DebitNoteDetails { get; set; }
    }
}
