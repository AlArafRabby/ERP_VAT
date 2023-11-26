using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class SaleView
    {
        public long? Serial { get; set; }
        public int SalesId { get; set; }
        public string InvoiceNo { get; set; } = null!;
        public DateTime SalesDate { get; set; }
        public DateTime? ExpectedDeliveryDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public int? OrganizationId { get; set; }
        public string? OrganizationName { get; set; }
    }
}
