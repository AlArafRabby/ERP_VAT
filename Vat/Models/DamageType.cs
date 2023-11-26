using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class DamageType
    {
        public DamageType()
        {
            Damages = new HashSet<Damage>();
        }

        public int DamageTypeId { get; set; }
        public string Name { get; set; } = null!;
        public string? NameInBangla { get; set; }

        public virtual ICollection<Damage> Damages { get; set; }
    }
}
