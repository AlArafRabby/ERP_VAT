using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class ExcelDataUpload
    {
        public ExcelDataUpload()
        {
            ExcelSimplifiedLocalPurchases = new HashSet<ExcelSimplifiedLocalPurchase>();
            ExcelSimplifiedPurchases = new HashSet<ExcelSimplifiedPurchase>();
            ExcelSimplifiedSalses = new HashSet<ExcelSimplifiedSalse>();
        }

        public long ExcelDataUploadId { get; set; }
        public int ExcelUploadedDataTypeId { get; set; }
        public DateTime? UploadTime { get; set; }
        public string? UploadedFileName { get; set; }
        public string? StoredFileName { get; set; }
        public string? StoredFilePath { get; set; }
        public int? OrganizationId { get; set; }
        public bool? IsProcessed { get; set; }
        public string? ProcessingMessage { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual ExcelUploadedDataType ExcelUploadedDataType { get; set; } = null!;
        public virtual ICollection<ExcelSimplifiedLocalPurchase> ExcelSimplifiedLocalPurchases { get; set; }
        public virtual ICollection<ExcelSimplifiedPurchase> ExcelSimplifiedPurchases { get; set; }
        public virtual ICollection<ExcelSimplifiedSalse> ExcelSimplifiedSalses { get; set; }
    }
}
