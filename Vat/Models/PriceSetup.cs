using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class PriceSetup
    {
        public PriceSetup()
        {
            PriceSetupProductCosts = new HashSet<PriceSetupProductCost>();
            ProductionReceives = new HashSet<ProductionReceive>();
        }

        public int PriceSetupId { get; set; }
        public int OrganizationId { get; set; }
        public int ProductId { get; set; }
        public int MeasurementUnitId { get; set; }
        public decimal? BaseTp { get; set; }
        public decimal? Mrp { get; set; }
        public decimal PurchaseUnitPrice { get; set; }
        public decimal SalesUnitPrice { get; set; }
        public decimal ProfitAmount { get; set; }
        public bool? IsMushakSubmitted { get; set; }
        public int? SubmissionSl { get; set; }
        public DateTime? MushakSubmissionDate { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public DateTime? EffectiveTo { get; set; }
        public bool IsActive { get; set; }
        public string? ReferenceKey { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public long? ApiTransactionId { get; set; }

        public virtual MeasurementUnit MeasurementUnit { get; set; } = null!;
        public virtual Organization Organization { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
        public virtual ICollection<PriceSetupProductCost> PriceSetupProductCosts { get; set; }
        public virtual ICollection<ProductionReceive> ProductionReceives { get; set; }
    }
}
