using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class Product
    {
        public Product()
        {
            BillOfMaterials = new HashSet<BillOfMaterial>();
            BranchTransferReceiveDetails = new HashSet<BranchTransferReceiveDetail>();
            BranchTransferSendDetails = new HashSet<BranchTransferSendDetail>();
            ContractualProductionProductDetails = new HashSet<ContractualProductionProductDetail>();
            ContractualProductionTransferRawMaterialDetails = new HashSet<ContractualProductionTransferRawMaterialDetail>();
            DamageDetails = new HashSet<DamageDetail>();
            PriceSetupProductCosts = new HashSet<PriceSetupProductCost>();
            PriceSetups = new HashSet<PriceSetup>();
            ProductOpeningBalances = new HashSet<ProductOpeningBalance>();
            ProductTransactionBooks = new HashSet<ProductTransactionBook>();
            ProductVats = new HashSet<ProductVat>();
            ProductionReceives = new HashSet<ProductionReceive>();
            PurchaseDetails = new HashSet<PurchaseDetail>();
            SalesDetails = new HashSet<SalesDetail>();
            SalesPriceAdjustmentDetails = new HashSet<SalesPriceAdjustmentDetail>();
            SupplimentaryDuties = new HashSet<SupplimentaryDuty>();
        }

        public int ProductId { get; set; }
        public string Name { get; set; } = null!;
        public int? BrandId { get; set; }
        public string? ProductNumber { get; set; }
        public string? ModelNo { get; set; }
        public string? DeviceModel { get; set; }
        public string? Code { get; set; }
        public string? PartNo { get; set; }
        public string? PartCode { get; set; }
        public string? Variant { get; set; }
        public string? Color { get; set; }
        public string? Size { get; set; }
        public string? Weight { get; set; }
        public string? Specification { get; set; }
        public string? Hscode { get; set; }
        public int? ProductCategoryId { get; set; }
        public int ProductGroupId { get; set; }
        public int ProductTypeId { get; set; }
        public int OrganizationId { get; set; }
        public decimal TotalQuantity { get; set; }
        public int MeasurementUnitId { get; set; }
        public string? Description { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public DateTime? EffectiveTo { get; set; }
        public string? ReferenceKey { get; set; }
        public DateTime? ModifyDate { get; set; }
        public bool IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public long? ApiTransactionId { get; set; }
        public bool IsNonRebateable { get; set; }
        public long? ExcelDataUploadId { get; set; }

        public virtual Brand? Brand { get; set; }
        public virtual MeasurementUnit MeasurementUnit { get; set; } = null!;
        public virtual Organization Organization { get; set; } = null!;
        public virtual ProductCategory? ProductCategory { get; set; }
        public virtual ProductGroup ProductGroup { get; set; } = null!;
        public virtual ProductType ProductType { get; set; } = null!;
        public virtual ICollection<BillOfMaterial> BillOfMaterials { get; set; }
        public virtual ICollection<BranchTransferReceiveDetail> BranchTransferReceiveDetails { get; set; }
        public virtual ICollection<BranchTransferSendDetail> BranchTransferSendDetails { get; set; }
        public virtual ICollection<ContractualProductionProductDetail> ContractualProductionProductDetails { get; set; }
        public virtual ICollection<ContractualProductionTransferRawMaterialDetail> ContractualProductionTransferRawMaterialDetails { get; set; }
        public virtual ICollection<DamageDetail> DamageDetails { get; set; }
        public virtual ICollection<PriceSetupProductCost> PriceSetupProductCosts { get; set; }
        public virtual ICollection<PriceSetup> PriceSetups { get; set; }
        public virtual ICollection<ProductOpeningBalance> ProductOpeningBalances { get; set; }
        public virtual ICollection<ProductTransactionBook> ProductTransactionBooks { get; set; }
        public virtual ICollection<ProductVat> ProductVats { get; set; }
        public virtual ICollection<ProductionReceive> ProductionReceives { get; set; }
        public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; }
        public virtual ICollection<SalesDetail> SalesDetails { get; set; }
        public virtual ICollection<SalesPriceAdjustmentDetail> SalesPriceAdjustmentDetails { get; set; }
        public virtual ICollection<SupplimentaryDuty> SupplimentaryDuties { get; set; }
    }
}
