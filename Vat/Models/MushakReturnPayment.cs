using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class MushakReturnPayment
    {
        public MushakReturnPayment()
        {
            MushakReturnPaymentForVds = new HashSet<MushakReturnPaymentForVd>();
        }

        public int MushakReturnPaymentId { get; set; }
        public int OrganizationId { get; set; }
        public int CustomsAndVatcommissionarateId { get; set; }
        public int MushakYear { get; set; }
        public int MushakMonth { get; set; }
        public int MushakReturnPaymentTypeId { get; set; }
        public decimal PaidAmount { get; set; }
        public DateTime PaymentDate { get; set; }
        public int BankId { get; set; }
        public string BankBranchName { get; set; } = null!;
        public int BankBranchCountryId { get; set; }
        public int BankBranchDistrictOrCityId { get; set; }
        public string EconomicCode1stDisit { get; set; } = null!;
        public string EconomicCode2ndDisit { get; set; } = null!;
        public string EconomicCode3rdDisit { get; set; } = null!;
        public string EconomicCode4thDisit { get; set; } = null!;
        public string EconomicCode5thDisit { get; set; } = null!;
        public string EconomicCode6thDisit { get; set; } = null!;
        public string EconomicCode7thDisit { get; set; } = null!;
        public string EconomicCode8thDisit { get; set; } = null!;
        public string EconomicCode9thDisit { get; set; } = null!;
        public string EconomicCode10thDisit { get; set; } = null!;
        public string EconomicCode11thDisit { get; set; } = null!;
        public string EconomicCode12thDisit { get; set; } = null!;
        public string EconomicCode13thDisit { get; set; } = null!;
        public bool IsSubmitted { get; set; }
        public string? TreasuryChallanNo { get; set; }
        public DateTime? SubimissionDate { get; set; }
        public int? SubmissionEntryBy { get; set; }
        public DateTime? SubmissionEntryDate { get; set; }
        public string? ReferenceKey { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public long? ApiTransactionId { get; set; }

        public virtual Bank Bank { get; set; } = null!;
        public virtual Country BankBranchCountry { get; set; } = null!;
        public virtual DistrictOrCity BankBranchDistrictOrCity { get; set; } = null!;
        public virtual CustomsAndVatcommissionarate CustomsAndVatcommissionarate { get; set; } = null!;
        public virtual MushakReturnPaymentType MushakReturnPaymentType { get; set; } = null!;
        public virtual Organization Organization { get; set; } = null!;
        public virtual ICollection<MushakReturnPaymentForVd> MushakReturnPaymentForVds { get; set; }
    }
}
