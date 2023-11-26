using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class DocumentType
    {
        public DocumentType()
        {
            Contents = new HashSet<Content>();
        }

        public int DocumentTypeId { get; set; }
        public int? OrganizationId { get; set; }
        public string Name { get; set; } = null!;
        public bool IsActive { get; set; }
        public string? ReferenceKey { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }

        public virtual Organization? Organization { get; set; }
        public virtual ICollection<Content> Contents { get; set; }
    }
}
