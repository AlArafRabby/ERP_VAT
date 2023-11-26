using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class MeasurementUnit
    {
        public MeasurementUnit()
        {
            BillOfMaterials = new HashSet<BillOfMaterial>();
            BranchTransferReceiveDetails = new HashSet<BranchTransferReceiveDetail>();
            BranchTransferSendDetails = new HashSet<BranchTransferSendDetail>();
            ContractualProductionProductDetails = new HashSet<ContractualProductionProductDetail>();
            ContractualProductionTransferRawMaterialDetails = new HashSet<ContractualProductionTransferRawMaterialDetail>();
            CreditNoteDetails = new HashSet<CreditNoteDetail>();
            DamageDetails = new HashSet<DamageDetail>();
            DebitNoteDetails = new HashSet<DebitNoteDetail>();
            PriceSetupProductCosts = new HashSet<PriceSetupProductCost>();
            PriceSetups = new HashSet<PriceSetup>();
            ProductOpeningBalances = new HashSet<ProductOpeningBalance>();
            ProductTransactionBooks = new HashSet<ProductTransactionBook>();
            ProductionReceives = new HashSet<ProductionReceive>();
            Products = new HashSet<Product>();
            PurchaseDetails = new HashSet<PurchaseDetail>();
            SalesDetails = new HashSet<SalesDetail>();
            SalesPriceAdjustmentDetails = new HashSet<SalesPriceAdjustmentDetail>();
        }

        public int MeasurementUnitId { get; set; }
        public string Name { get; set; } = null!;
        public int OrganizationId { get; set; }
        public bool IsActive { get; set; }
        public string? ReferenceKey { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public long? ApiTransactionId { get; set; }
        public long? ExcelDataUploadId { get; set; }

        public virtual ICollection<BillOfMaterial> BillOfMaterials { get; set; }
        public virtual ICollection<BranchTransferReceiveDetail> BranchTransferReceiveDetails { get; set; }
        public virtual ICollection<BranchTransferSendDetail> BranchTransferSendDetails { get; set; }
        public virtual ICollection<ContractualProductionProductDetail> ContractualProductionProductDetails { get; set; }
        public virtual ICollection<ContractualProductionTransferRawMaterialDetail> ContractualProductionTransferRawMaterialDetails { get; set; }
        public virtual ICollection<CreditNoteDetail> CreditNoteDetails { get; set; }
        public virtual ICollection<DamageDetail> DamageDetails { get; set; }
        public virtual ICollection<DebitNoteDetail> DebitNoteDetails { get; set; }
        public virtual ICollection<PriceSetupProductCost> PriceSetupProductCosts { get; set; }
        public virtual ICollection<PriceSetup> PriceSetups { get; set; }
        public virtual ICollection<ProductOpeningBalance> ProductOpeningBalances { get; set; }
        public virtual ICollection<ProductTransactionBook> ProductTransactionBooks { get; set; }
        public virtual ICollection<ProductionReceive> ProductionReceives { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; }
        public virtual ICollection<SalesDetail> SalesDetails { get; set; }
        public virtual ICollection<SalesPriceAdjustmentDetail> SalesPriceAdjustmentDetails { get; set; }
    }
}
