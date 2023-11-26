using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class TransectionType
    {
        public int TransectionTypeId { get; set; }
        public string Name { get; set; } = null!;
        public string NameInBangla { get; set; } = null!;
        public bool IsActive { get; set; }
    }
}
