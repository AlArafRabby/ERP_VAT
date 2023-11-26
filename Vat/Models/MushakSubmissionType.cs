using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class MushakSubmissionType
    {
        public MushakSubmissionType()
        {
            MushakSubmissions = new HashSet<MushakSubmission>();
        }

        public byte MushakSubmissionTypeId { get; set; }
        public string SubmissionTypeName { get; set; } = null!;
        public string SubmissionTypeNameBn { get; set; } = null!;

        public virtual ICollection<MushakSubmission> MushakSubmissions { get; set; }
    }
}
