using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class ApiTransactionType
    {
        public ApiTransactionType()
        {
            ApiTransactions = new HashSet<ApiTransaction>();
        }

        public int ApiTransactionTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<ApiTransaction> ApiTransactions { get; set; }
    }
}
