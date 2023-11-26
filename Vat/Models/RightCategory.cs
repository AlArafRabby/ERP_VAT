using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class RightCategory
    {
        public RightCategory()
        {
            Rights = new HashSet<Right>();
        }

        public int RightCategoryId { get; set; }
        public string RightCategoryName { get; set; } = null!;
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual ICollection<Right> Rights { get; set; }
    }
}
