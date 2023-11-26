using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class MushakGenerationStage
    {
        public byte MushakGenerationStageId { get; set; }
        public string Name { get; set; } = null!;
        public string NameInBangla { get; set; } = null!;
    }
}
