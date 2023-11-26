using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class ExcelUploadedDataType
    {
        public ExcelUploadedDataType()
        {
            ExcelDataUploads = new HashSet<ExcelDataUpload>();
        }

        public int ExcelUploadedDataTypeId { get; set; }
        public string ExcelUploadedDataTypeName { get; set; } = null!;

        public virtual ICollection<ExcelDataUpload> ExcelDataUploads { get; set; }
    }
}
