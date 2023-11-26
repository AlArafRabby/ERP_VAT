using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class Right
    {
        public Right()
        {
            RoleRights = new HashSet<RoleRight>();
        }

        public int RightId { get; set; }
        public string RightName { get; set; } = null!;
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int RightCategoryId { get; set; }

        public virtual RightCategory RightCategory { get; set; } = null!;
        public virtual ICollection<RoleRight> RoleRights { get; set; }
    }
}
