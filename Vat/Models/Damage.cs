﻿using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class Damage
    {
        public Damage()
        {
            DamageDetails = new HashSet<DamageDetail>();
        }

        public int DamageId { get; set; }
        public int OrganizationId { get; set; }
        public int DamageTypeId { get; set; }
        public int? SalesId { get; set; }
        public int? PurchaseId { get; set; }
        public string? VoucherNo { get; set; }
        public string? Description { get; set; }
        public DateTime PreparedOn { get; set; }
        public DateTime? NbrsubmissionDate { get; set; }
        public int? VatResponsiblePersonId { get; set; }
        public string? NbrverifierName { get; set; }
        public string? NbrverifierDesignation { get; set; }
        public DateTime? NbrverificationDate { get; set; }
        public bool? IsDismissedByNbr { get; set; }
        public bool? IsApprovedByNbr { get; set; }
        public bool IsActive { get; set; }
        public string? ReferenceKey { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public long? ApiTransactionId { get; set; }

        public virtual DamageType DamageType { get; set; } = null!;
        public virtual Organization Organization { get; set; } = null!;
        public virtual Purchase? Purchase { get; set; }
        public virtual Sale? Sales { get; set; }
        public virtual ICollection<DamageDetail> DamageDetails { get; set; }
    }
}
