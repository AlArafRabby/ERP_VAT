﻿using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class Content
    {
        public long ContentId { get; set; }
        public int DocumentTypeId { get; set; }
        public int? OrganizationId { get; set; }
        public string FileUrl { get; set; } = null!;
        public string? MimeType { get; set; }
        public string? Node { get; set; }
        public int ObjectId { get; set; }
        public int ObjectPrimaryKey { get; set; }
        public bool IsActive { get; set; }
        public string? Remarks { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual DocumentType DocumentType { get; set; } = null!;
    }
}
