using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class CustomerDeliveryAddress
    {
        public int CustomerDeliveryAddressId { get; set; }
        public int? OrganizationId { get; set; }
        public int CustomerId { get; set; }
        public string DeliveryAddress { get; set; } = null!;
        public string? DeliveryContactPerson { get; set; }
        public string? DeliveryContactPersonDesignation { get; set; }
        public string? DeliveryContactPersonMobile { get; set; }
        public string? DeliveryContactPersonEmailAddress { get; set; }
        public string? ReferenceKey { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public long? ApiTransactionId { get; set; }
        public long? ExcelDataUploadId { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual Organization? Organization { get; set; }
    }
}
