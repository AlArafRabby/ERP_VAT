using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class InputOutputCoEfficient
    {
        public int InputOutputCoEfficientId { get; set; }
        public int OrganizationId { get; set; }
        public int? PriceSetupId { get; set; }
        public bool IsSubmitted { get; set; }
        public DateTime? SubmissionDate { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public DateTime? EffectiveTo { get; set; }
        public bool IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
    }
}
