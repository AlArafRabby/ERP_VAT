using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class ContractType
    {
        public ContractType()
        {
            ContractualProductions = new HashSet<ContractualProduction>();
        }

        public int ContractTypeId { get; set; }
        public string Name { get; set; } = null!;
        public bool IsActive { get; set; }

        public virtual ICollection<ContractualProduction> ContractualProductions { get; set; }
    }
}
