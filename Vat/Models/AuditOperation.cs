using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class AuditOperation
    {
        public AuditOperation()
        {
            AuditLogs = new HashSet<AuditLog>();
        }

        public int AuditOperationId { get; set; }
        public string Name { get; set; } = null!;
        public string? Remarks { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<AuditLog> AuditLogs { get; set; }
    }
}
