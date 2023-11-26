using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Vat.Models;

namespace Vat.Context
{
    public partial class iVatContext : DbContext
    {
        public iVatContext()
        {
        }

        public iVatContext(DbContextOptions<iVatContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Adjustment> Adjustments { get; set; } = null!;
        public virtual DbSet<AdjustmentType> AdjustmentTypes { get; set; } = null!;
        public virtual DbSet<ApiTransaction> ApiTransactions { get; set; } = null!;
        public virtual DbSet<ApiTransactionType> ApiTransactionTypes { get; set; } = null!;
        public virtual DbSet<AuditLog> AuditLogs { get; set; } = null!;
        public virtual DbSet<AuditOperation> AuditOperations { get; set; } = null!;
        public virtual DbSet<Bank> Banks { get; set; } = null!;
        public virtual DbSet<BillOfMaterial> BillOfMaterials { get; set; } = null!;
        public virtual DbSet<BranchTransferReceive> BranchTransferReceives { get; set; } = null!;
        public virtual DbSet<BranchTransferReceiveDetail> BranchTransferReceiveDetails { get; set; } = null!;
        public virtual DbSet<BranchTransferSend> BranchTransferSends { get; set; } = null!;
        public virtual DbSet<BranchTransferSendDetail> BranchTransferSendDetails { get; set; } = null!;
        public virtual DbSet<Brand> Brands { get; set; } = null!;
        public virtual DbSet<BusinessCategory> BusinessCategories { get; set; } = null!;
        public virtual DbSet<BusinessNature> BusinessNatures { get; set; } = null!;
        public virtual DbSet<Coagroup> Coagroups { get; set; } = null!;
        public virtual DbSet<Content> Contents { get; set; } = null!;
        public virtual DbSet<ContractType> ContractTypes { get; set; } = null!;
        public virtual DbSet<ContractualProduction> ContractualProductions { get; set; } = null!;
        public virtual DbSet<ContractualProductionProductDetail> ContractualProductionProductDetails { get; set; } = null!;
        public virtual DbSet<ContractualProductionTransferRawMaterial> ContractualProductionTransferRawMaterials { get; set; } = null!;
        public virtual DbSet<ContractualProductionTransferRawMaterialDetail> ContractualProductionTransferRawMaterialDetails { get; set; } = null!;
        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<CreditNote> CreditNotes { get; set; } = null!;
        public virtual DbSet<CreditNoteDetail> CreditNoteDetails { get; set; } = null!;
        public virtual DbSet<Currency> Currencies { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<CustomerDeliveryAddress> CustomerDeliveryAddresses { get; set; } = null!;
        public virtual DbSet<CustomsAndVatcommissionarate> CustomsAndVatcommissionarates { get; set; } = null!;
        public virtual DbSet<Damage> Damages { get; set; } = null!;
        public virtual DbSet<DamageDetail> DamageDetails { get; set; } = null!;
        public virtual DbSet<DamageType> DamageTypes { get; set; } = null!;
        public virtual DbSet<DebitNote> DebitNotes { get; set; } = null!;
        public virtual DbSet<DebitNoteDetail> DebitNoteDetails { get; set; } = null!;
        public virtual DbSet<DefaultPercent> DefaultPercents { get; set; } = null!;
        public virtual DbSet<DeliveryMethod> DeliveryMethods { get; set; } = null!;
        public virtual DbSet<District> Districts { get; set; } = null!;
        public virtual DbSet<DistrictOrCity> DistrictOrCities { get; set; } = null!;
        public virtual DbSet<DivisionOrState> DivisionOrStates { get; set; } = null!;
        public virtual DbSet<DocumentType> DocumentTypes { get; set; } = null!;
        public virtual DbSet<ExcelDataUpload> ExcelDataUploads { get; set; } = null!;
        public virtual DbSet<ExcelSimplifiedLocalPurchase> ExcelSimplifiedLocalPurchases { get; set; } = null!;
        public virtual DbSet<ExcelSimplifiedPurchase> ExcelSimplifiedPurchases { get; set; } = null!;
        public virtual DbSet<ExcelSimplifiedSalse> ExcelSimplifiedSalses { get; set; } = null!;
        public virtual DbSet<ExcelUploadedDataType> ExcelUploadedDataTypes { get; set; } = null!;
        public virtual DbSet<ExportType> ExportTypes { get; set; } = null!;
        public virtual DbSet<FinancialActivityNature> FinancialActivityNatures { get; set; } = null!;
        public virtual DbSet<InputOutputCoEfficient> InputOutputCoEfficients { get; set; } = null!;
        public virtual DbSet<MasterPurchase> MasterPurchases { get; set; } = null!;
        public virtual DbSet<MasterPurchaseDetail> MasterPurchaseDetails { get; set; } = null!;
        public virtual DbSet<MeasurementUnit> MeasurementUnits { get; set; } = null!;
        public virtual DbSet<MushakGeneration> MushakGenerations { get; set; } = null!;
        public virtual DbSet<MushakGenerationStage> MushakGenerationStages { get; set; } = null!;
        public virtual DbSet<MushakReturnPayment> MushakReturnPayments { get; set; } = null!;
        public virtual DbSet<MushakReturnPaymentForVd> MushakReturnPaymentForVds { get; set; } = null!;
        public virtual DbSet<MushakReturnPaymentType> MushakReturnPaymentTypes { get; set; } = null!;
        public virtual DbSet<MushakReturnRefund> MushakReturnRefunds { get; set; } = null!;
        public virtual DbSet<MushakSubmission> MushakSubmissions { get; set; } = null!;
        public virtual DbSet<MushakSubmissionType> MushakSubmissionTypes { get; set; } = null!;
        public virtual DbSet<NbrEconomicCode> NbrEconomicCodes { get; set; } = null!;
        public virtual DbSet<NbrEconomicCodeType> NbrEconomicCodeTypes { get; set; } = null!;
        public virtual DbSet<ObjectType> ObjectTypes { get; set; } = null!;
        public virtual DbSet<OldAccountCurrentBalance> OldAccountCurrentBalances { get; set; } = null!;
        public virtual DbSet<OrgBranch> OrgBranches { get; set; } = null!;
        public virtual DbSet<OrgBranchType> OrgBranchTypes { get; set; } = null!;
        public virtual DbSet<OrgStaticDataType> OrgStaticDataTypes { get; set; } = null!;
        public virtual DbSet<OrgStaticDatum> OrgStaticData { get; set; } = null!;
        public virtual DbSet<Organization> Organizations { get; set; } = null!;
        public virtual DbSet<OrganizationConfig> OrganizationConfigs { get; set; } = null!;
        public virtual DbSet<OrganizationConfigType> OrganizationConfigTypes { get; set; } = null!;
        public virtual DbSet<OrganizationConfigurationArea> OrganizationConfigurationAreas { get; set; } = null!;
        public virtual DbSet<OrganizationConfigurationBooleanType> OrganizationConfigurationBooleanTypes { get; set; } = null!;
        public virtual DbSet<OrganizationConfigurationDecimalType> OrganizationConfigurationDecimalTypes { get; set; } = null!;
        public virtual DbSet<OrganizationConfigurationIntType> OrganizationConfigurationIntTypes { get; set; } = null!;
        public virtual DbSet<OrganizationConfigurationStringType> OrganizationConfigurationStringTypes { get; set; } = null!;
        public virtual DbSet<OverHeadCost> OverHeadCosts { get; set; } = null!;
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; } = null!;
        public virtual DbSet<PaymentReason> PaymentReasons { get; set; } = null!;
        public virtual DbSet<PriceSetup> PriceSetups { get; set; } = null!;
        public virtual DbSet<PriceSetupProductCost> PriceSetupProductCosts { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductCategory> ProductCategories { get; set; } = null!;
        public virtual DbSet<ProductGroup> ProductGroups { get; set; } = null!;
        public virtual DbSet<ProductOpeningBalance> ProductOpeningBalances { get; set; } = null!;
        public virtual DbSet<ProductTransactionBook> ProductTransactionBooks { get; set; } = null!;
        public virtual DbSet<ProductType> ProductTypes { get; set; } = null!;
        public virtual DbSet<ProductVat> ProductVats { get; set; } = null!;
        public virtual DbSet<ProductVattype> ProductVattypes { get; set; } = null!;
        public virtual DbSet<ProductionReceive> ProductionReceives { get; set; } = null!;
        public virtual DbSet<Purchase> Purchases { get; set; } = null!;
        public virtual DbSet<PurchaseDetail> PurchaseDetails { get; set; } = null!;
        public virtual DbSet<PurchaseImportTariff> PurchaseImportTariffs { get; set; } = null!;
        public virtual DbSet<PurchaseImportTaxPayment> PurchaseImportTaxPayments { get; set; } = null!;
        public virtual DbSet<PurchaseImportTaxPaymentType> PurchaseImportTaxPaymentTypes { get; set; } = null!;
        public virtual DbSet<PurchasePayment> PurchasePayments { get; set; } = null!;
        public virtual DbSet<PurchaseReason> PurchaseReasons { get; set; } = null!;
        public virtual DbSet<PurchaseType> PurchaseTypes { get; set; } = null!;
        public virtual DbSet<ReportColPurchaseCalculationBook> ReportColPurchaseCalculationBooks { get; set; } = null!;
        public virtual DbSet<ReportColPurchaseReport> ReportColPurchaseReports { get; set; } = null!;
        public virtual DbSet<ReportColPurchaseSummeryReport> ReportColPurchaseSummeryReports { get; set; } = null!;
        public virtual DbSet<ReportColSalesReport> ReportColSalesReports { get; set; } = null!;
        public virtual DbSet<ReportColSalesSummeryReport> ReportColSalesSummeryReports { get; set; } = null!;
        public virtual DbSet<Right> Rights { get; set; } = null!;
        public virtual DbSet<RightCategory> RightCategories { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<RoleRight> RoleRights { get; set; } = null!;
        public virtual DbSet<Sale> Sales { get; set; } = null!;
        public virtual DbSet<SaleView> SaleViews { get; set; } = null!;
        public virtual DbSet<SalesDeliveryType> SalesDeliveryTypes { get; set; } = null!;
        public virtual DbSet<SalesDetail> SalesDetails { get; set; } = null!;
        public virtual DbSet<SalesPaymentReceive> SalesPaymentReceives { get; set; } = null!;
        public virtual DbSet<SalesPriceAdjustment> SalesPriceAdjustments { get; set; } = null!;
        public virtual DbSet<SalesPriceAdjustmentDetail> SalesPriceAdjustmentDetails { get; set; } = null!;
        public virtual DbSet<SalesType> SalesTypes { get; set; } = null!;
        public virtual DbSet<SupplimentaryDuty> SupplimentaryDuties { get; set; } = null!;
        public virtual DbSet<TransectionType> TransectionTypes { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserLoginHistory> UserLoginHistories { get; set; } = null!;
        public virtual DbSet<UserType> UserTypes { get; set; } = null!;
        public virtual DbSet<VehicleType> VehicleTypes { get; set; } = null!;
        public virtual DbSet<Vendor> Vendors { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=10.24.50.119;Initial Catalog=iVat;User ID=rabby.corp;Password=1234;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adjustment>(entity =>
            {
                entity.ToTable("Adjustment");

                entity.Property(e => e.Amount).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.HasOne(d => d.AdjustmentType)
                    .WithMany(p => p.Adjustments)
                    .HasForeignKey(d => d.AdjustmentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Adjustment_AdjustmentType");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.Adjustments)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Adjustment_Organizations");
            });

            modelBuilder.Entity<AdjustmentType>(entity =>
            {
                entity.ToTable("AdjustmentType");

                entity.Property(e => e.AdjustmentTypeId).ValueGeneratedNever();

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.NameInBangla).HasMaxLength(50);
            });

            modelBuilder.Entity<ApiTransaction>(entity =>
            {
                entity.ToTable("ApiTransaction");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.SecurityToken).HasMaxLength(100);

                entity.HasOne(d => d.ApiTransactionType)
                    .WithMany(p => p.ApiTransactions)
                    .HasForeignKey(d => d.ApiTransactionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApiTransaction_ApiTransactionType");
            });

            modelBuilder.Entity<ApiTransactionType>(entity =>
            {
                entity.ToTable("ApiTransactionType");

                entity.Property(e => e.ApiTransactionTypeId).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<AuditLog>(entity =>
            {
                entity.ToTable("AuditLog");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Descriptions).HasMaxLength(4000);

                entity.HasOne(d => d.AuditOperation)
                    .WithMany(p => p.AuditLogs)
                    .HasForeignKey(d => d.AuditOperationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AuditLog_AuditOperation");

                entity.HasOne(d => d.ObjectType)
                    .WithMany(p => p.AuditLogs)
                    .HasForeignKey(d => d.ObjectTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AuditLog_ObjectType");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.AuditLogs)
                    .HasForeignKey(d => d.OrganizationId)
                    .HasConstraintName("FK_AuditLog_Organizations");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AuditLogs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AuditLog_Users");
            });

            modelBuilder.Entity<AuditOperation>(entity =>
            {
                entity.ToTable("AuditOperation");

                entity.Property(e => e.AuditOperationId)
                    .ValueGeneratedNever()
                    .HasColumnName("AuditOperationID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(500);
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.ToTable("Bank");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NameInBangla).HasMaxLength(250);

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.Banks)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bank_Organizations");
            });

            modelBuilder.Entity<BillOfMaterial>(entity =>
            {
                entity.ToTable("BillOfMaterial");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.Property(e => e.UsedQuantity).HasColumnType("decimal(26, 8)");

                entity.HasOne(d => d.MeasurementUnit)
                    .WithMany(p => p.BillOfMaterials)
                    .HasForeignKey(d => d.MeasurementUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BillOfMaterial_MeasurementUnits");

                entity.HasOne(d => d.ProductTransactionBook)
                    .WithMany(p => p.BillOfMaterials)
                    .HasForeignKey(d => d.ProductTransactionBookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BillOfMaterial_ProductTransactionBook");

                entity.HasOne(d => d.ProductionReceive)
                    .WithMany(p => p.BillOfMaterials)
                    .HasForeignKey(d => d.ProductionReceiveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BillOfMaterial_ProductionReceive");

                entity.HasOne(d => d.RawMaterial)
                    .WithMany(p => p.BillOfMaterials)
                    .HasForeignKey(d => d.RawMaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BillOfMaterial_Products");
            });

            modelBuilder.Entity<BranchTransferReceive>(entity =>
            {
                entity.ToTable("BranchTransferReceive");

                entity.Property(e => e.BranchTransferReceiveDate).HasColumnType("datetime");

                entity.Property(e => e.BranchTransferReceiveRemarks).HasMaxLength(500);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.PostedTime).HasColumnType("datetime");

                entity.Property(e => e.ReceiverContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverName).HasMaxLength(200);

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.Property(e => e.TransferChallanNo).HasMaxLength(50);

                entity.Property(e => e.VehicleDriverContactNo).HasMaxLength(50);

                entity.Property(e => e.VehicleDriverName).HasMaxLength(100);

                entity.Property(e => e.VehicleName).HasMaxLength(100);

                entity.Property(e => e.VehicleRegNo).HasMaxLength(50);

                entity.HasOne(d => d.BranchTransferSend)
                    .WithMany(p => p.BranchTransferReceives)
                    .HasForeignKey(d => d.BranchTransferSendId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BranchTransferReceive_BranchTransferSend");

                entity.HasOne(d => d.OrgBranchReceiver)
                    .WithMany(p => p.BranchTransferReceiveOrgBranchReceivers)
                    .HasForeignKey(d => d.OrgBranchReceiverId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BranchTransferReceive_OrgBranch_Receiver_Receive");

                entity.HasOne(d => d.OrgBranchSender)
                    .WithMany(p => p.BranchTransferReceiveOrgBranchSenders)
                    .HasForeignKey(d => d.OrgBranchSenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BranchTransferReceive_OrgBranch_Sender_Receive");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.BranchTransferReceives)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BranchTransferReceive_Organizations");

                entity.HasOne(d => d.VehicleType)
                    .WithMany(p => p.BranchTransferReceives)
                    .HasForeignKey(d => d.VehicleTypeId)
                    .HasConstraintName("FK_BranchTransferReceive_VehicleType");
            });

            modelBuilder.Entity<BranchTransferReceiveDetail>(entity =>
            {
                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.GoodsId).HasMaxLength(50);

                entity.Property(e => e.Hscode)
                    .HasMaxLength(50)
                    .HasColumnName("HSCode");

                entity.Property(e => e.PartNo).HasMaxLength(100);

                entity.Property(e => e.ProductCode).HasMaxLength(50);

                entity.Property(e => e.ProductDescription).HasMaxLength(500);

                entity.Property(e => e.Quantity).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.Property(e => e.Skuid)
                    .HasMaxLength(50)
                    .HasColumnName("SKUId");

                entity.Property(e => e.Skuno)
                    .HasMaxLength(50)
                    .HasColumnName("SKUNo");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(26, 8)");

                entity.HasOne(d => d.BranchTransferReceive)
                    .WithMany(p => p.BranchTransferReceiveDetails)
                    .HasForeignKey(d => d.BranchTransferReceiveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BranchTransferReceiveDetails_BranchTransferReceive");

                entity.HasOne(d => d.BranchTransferSendDetail)
                    .WithMany(p => p.BranchTransferReceiveDetails)
                    .HasForeignKey(d => d.BranchTransferSendDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BranchTransferReceiveDetails_BranchTransferSendDetails");

                entity.HasOne(d => d.MeasurementUnit)
                    .WithMany(p => p.BranchTransferReceiveDetails)
                    .HasForeignKey(d => d.MeasurementUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BranchTransferReceiveDetails_MeasurementUnits");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.BranchTransferReceiveDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BranchTransferReceiveDetails_Products");
            });

            modelBuilder.Entity<BranchTransferSend>(entity =>
            {
                entity.ToTable("BranchTransferSend");

                entity.Property(e => e.BranchTransferSendDate).HasColumnType("datetime");

                entity.Property(e => e.BranchTransferSendRemarks).HasMaxLength(500);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.PostedTime).HasColumnType("datetime");

                entity.Property(e => e.ReceiverContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverName).HasMaxLength(200);

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.Property(e => e.ShippingAddress).HasMaxLength(200);

                entity.Property(e => e.TransferChallanNo).HasMaxLength(50);

                entity.Property(e => e.TransferChallanPrintedTime).HasColumnType("datetime");

                entity.Property(e => e.VehicleDriverContactNo).HasMaxLength(50);

                entity.Property(e => e.VehicleDriverName).HasMaxLength(100);

                entity.Property(e => e.VehicleName).HasMaxLength(100);

                entity.Property(e => e.VehicleRegNo).HasMaxLength(50);

                entity.HasOne(d => d.OrgBranchReceiver)
                    .WithMany(p => p.BranchTransferSendOrgBranchReceivers)
                    .HasForeignKey(d => d.OrgBranchReceiverId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BranchTransferSend_OrgBranch_Receiver_Send");

                entity.HasOne(d => d.OrgBranchSender)
                    .WithMany(p => p.BranchTransferSendOrgBranchSenders)
                    .HasForeignKey(d => d.OrgBranchSenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BranchTransferSend_OrgBranch_Sender_Send");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.BranchTransferSends)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BranchTransferSend_Organizations");

                entity.HasOne(d => d.VehicleType)
                    .WithMany(p => p.BranchTransferSends)
                    .HasForeignKey(d => d.VehicleTypeId)
                    .HasConstraintName("FK_BranchTransferSend_VehicleType");
            });

            modelBuilder.Entity<BranchTransferSendDetail>(entity =>
            {
                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.GoodsId).HasMaxLength(50);

                entity.Property(e => e.Hscode)
                    .HasMaxLength(50)
                    .HasColumnName("HSCode");

                entity.Property(e => e.PartNo).HasMaxLength(100);

                entity.Property(e => e.ProductCode).HasMaxLength(50);

                entity.Property(e => e.ProductDescription).HasMaxLength(500);

                entity.Property(e => e.ProductRemarks).HasMaxLength(500);

                entity.Property(e => e.Quantity).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.Property(e => e.Skuid)
                    .HasMaxLength(50)
                    .HasColumnName("SKUId");

                entity.Property(e => e.Skuno)
                    .HasMaxLength(50)
                    .HasColumnName("SKUNo");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(26, 8)");

                entity.HasOne(d => d.BranchTransferSend)
                    .WithMany(p => p.BranchTransferSendDetails)
                    .HasForeignKey(d => d.BranchTransferSendId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BranchTransferSendDetails_BranchTransferSend");

                entity.HasOne(d => d.MeasurementUnit)
                    .WithMany(p => p.BranchTransferSendDetails)
                    .HasForeignKey(d => d.MeasurementUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BranchTransferSendDetails_MeasurementUnits");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.BranchTransferSendDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BranchTransferSendDetails_Products");

                entity.HasOne(d => d.ProductTransactionBook)
                    .WithMany(p => p.BranchTransferSendDetails)
                    .HasForeignKey(d => d.ProductTransactionBookId)
                    .HasConstraintName("FK_BranchTransferSendDetails_ProductTransactionBook");
            });

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.ToTable("Brand");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NameInBangla).HasMaxLength(250);

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.Brands)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Brand_Organizations");
            });

            modelBuilder.Entity<BusinessCategory>(entity =>
            {
                entity.ToTable("BusinessCategory");

                entity.Property(e => e.BusinessCategoryId).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NameInBangla).HasMaxLength(250);
            });

            modelBuilder.Entity<BusinessNature>(entity =>
            {
                entity.ToTable("BusinessNature");

                entity.Property(e => e.BusinessNatureId).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NameInBangla).HasMaxLength(100);
            });

            modelBuilder.Entity<Coagroup>(entity =>
            {
                entity.ToTable("COAGroups", "acc");

                entity.Property(e => e.CoagroupId).HasColumnName("COAGroupId");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Node).HasMaxLength(50);
            });

            modelBuilder.Entity<Content>(entity =>
            {
                entity.ToTable("Content");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.FileUrl).HasMaxLength(500);

                entity.Property(e => e.MimeType).HasMaxLength(50);

                entity.Property(e => e.Node).HasMaxLength(500);

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.HasOne(d => d.DocumentType)
                    .WithMany(p => p.Contents)
                    .HasForeignKey(d => d.DocumentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Content_DocumentType");
            });

            modelBuilder.Entity<ContractType>(entity =>
            {
                entity.ToTable("ContractType");

                entity.Property(e => e.ContractTypeId).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<ContractualProduction>(entity =>
            {
                entity.ToTable("ContractualProduction");

                entity.Property(e => e.ChallanNo).HasMaxLength(50);

                entity.Property(e => e.ClosingDate).HasColumnType("datetime");

                entity.Property(e => e.ContractDate).HasColumnType("datetime");

                entity.Property(e => e.ContractNo).HasMaxLength(50);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.IssueDate).HasColumnType("datetime");

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.HasOne(d => d.ContractType)
                    .WithMany(p => p.ContractualProductions)
                    .HasForeignKey(d => d.ContractTypeId)
                    .HasConstraintName("FK_ContractualProduction_ContractType");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ContractualProductions)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_ContractualProduction_Customer");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.ContractualProductions)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_ContractualProduction_Vendor");
            });

            modelBuilder.Entity<ContractualProductionProductDetail>(entity =>
            {
                entity.HasKey(e => e.ContractualProductionProductDetailsId);

                entity.Property(e => e.Quantity).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.HasOne(d => d.ContractualProduction)
                    .WithMany(p => p.ContractualProductionProductDetails)
                    .HasForeignKey(d => d.ContractualProductionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractualProductionProductDetails_ContractualProduction");

                entity.HasOne(d => d.MeasurementUnit)
                    .WithMany(p => p.ContractualProductionProductDetails)
                    .HasForeignKey(d => d.MeasurementUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractualProductionProductDetails_MeasurementUnits");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ContractualProductionProductDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractualProductionProductDetails_Products");
            });

            modelBuilder.Entity<ContractualProductionTransferRawMaterial>(entity =>
            {
                entity.ToTable("ContractualProductionTransferRawMaterial");

                entity.Property(e => e.ChallanIssueDate).HasColumnType("datetime");

                entity.Property(e => e.ChallanNo).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Location).HasMaxLength(50);

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.Property(e => e.TransfereDate).HasColumnType("datetime");

                entity.Property(e => e.VehicleDriverContactNo).HasMaxLength(50);

                entity.Property(e => e.VehicleDriverName).HasMaxLength(100);

                entity.Property(e => e.VehicleName).HasMaxLength(100);

                entity.Property(e => e.VehicleRegNo).HasMaxLength(50);

                entity.HasOne(d => d.ContractualProduction)
                    .WithMany(p => p.ContractualProductionTransferRawMaterials)
                    .HasForeignKey(d => d.ContractualProductionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractualProductionTransferRawMaterial_ContractualProduction");

                entity.HasOne(d => d.VehicleType)
                    .WithMany(p => p.ContractualProductionTransferRawMaterials)
                    .HasForeignKey(d => d.VehicleTypeId)
                    .HasConstraintName("FK_ContractualProductionTransferRawMaterial_VehicleType");
            });

            modelBuilder.Entity<ContractualProductionTransferRawMaterialDetail>(entity =>
            {
                entity.HasKey(e => e.ContractualProductionTransferRawMaterialDetailsId);

                entity.Property(e => e.Quantity).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.HasOne(d => d.ContractualProductionTransferRawMaterial)
                    .WithMany(p => p.ContractualProductionTransferRawMaterialDetails)
                    .HasForeignKey(d => d.ContractualProductionTransferRawMaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractualProductionTransferRawMaterialDetails_ContractualProductionTransferRawMaterial");

                entity.HasOne(d => d.MeasurementUnit)
                    .WithMany(p => p.ContractualProductionTransferRawMaterialDetails)
                    .HasForeignKey(d => d.MeasurementUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractualProductionTransferRawMaterialDetails_MeasurementUnits");

                entity.HasOne(d => d.RawMaterial)
                    .WithMany(p => p.ContractualProductionTransferRawMaterialDetails)
                    .HasForeignKey(d => d.RawMaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractualProductionTransferRawMaterialDetails_Products");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country");

                entity.Property(e => e.CountryId).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<CreditNote>(entity =>
            {
                entity.ToTable("CreditNote");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.CreditNoteChallanNo).HasMaxLength(50);

                entity.Property(e => e.CreditNoteChallanPrintTime).HasColumnType("datetime");

                entity.Property(e => e.ReasonOfReturn).HasMaxLength(500);

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.Property(e => e.ReturnDate).HasColumnType("datetime");

                entity.Property(e => e.VehicleDriverContactNo).HasMaxLength(50);

                entity.Property(e => e.VehicleDriverName).HasMaxLength(100);

                entity.Property(e => e.VehicleName).HasMaxLength(100);

                entity.Property(e => e.VehicleRegNo).HasMaxLength(50);

                entity.Property(e => e.VoucherNo).HasMaxLength(50);

                entity.HasOne(d => d.MushakGeneration)
                    .WithMany(p => p.CreditNotes)
                    .HasForeignKey(d => d.MushakGenerationId)
                    .HasConstraintName("FK_CreditNote_MushakGeneration");

                entity.HasOne(d => d.Sales)
                    .WithMany(p => p.CreditNotes)
                    .HasForeignKey(d => d.SalesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CreditNote_Sales");

                entity.HasOne(d => d.VehicleType)
                    .WithMany(p => p.CreditNotes)
                    .HasForeignKey(d => d.VehicleTypeId)
                    .HasConstraintName("FK_CreditNote_VehicleType");
            });

            modelBuilder.Entity<CreditNoteDetail>(entity =>
            {
                entity.ToTable("CreditNoteDetail");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.ReasonOfReturn).HasMaxLength(500);

                entity.Property(e => e.ReasonOfReturnInDetail).HasMaxLength(500);

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.Property(e => e.ReturnQuantity).HasColumnType("decimal(26, 8)");

                entity.HasOne(d => d.CreditNote)
                    .WithMany(p => p.CreditNoteDetails)
                    .HasForeignKey(d => d.CreditNoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CreditNoteDetail_CreditNote");

                entity.HasOne(d => d.MeasurementUnit)
                    .WithMany(p => p.CreditNoteDetails)
                    .HasForeignKey(d => d.MeasurementUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CreditNoteDetail_MeasurementUnits");

                entity.HasOne(d => d.SalesDetail)
                    .WithMany(p => p.CreditNoteDetails)
                    .HasForeignKey(d => d.SalesDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CreditNoteDetail_SalesDetails");
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.ToTable("Currency");

                entity.Property(e => e.CurrencyId).ValueGeneratedNever();

                entity.Property(e => e.CurrencyCode).HasMaxLength(50);

                entity.Property(e => e.CurrencyName).HasMaxLength(250);

                entity.Property(e => e.CurrencySymbol).HasMaxLength(10);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.AccountCode).HasMaxLength(100);

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.BankAccountNo).HasMaxLength(50);

                entity.Property(e => e.BankBranchAddress).HasMaxLength(200);

                entity.Property(e => e.BankBranchName).HasMaxLength(100);

                entity.Property(e => e.BankRoutingCode).HasMaxLength(50);

                entity.Property(e => e.Bin)
                    .HasMaxLength(50)
                    .HasColumnName("BIN");

                entity.Property(e => e.BusinessCategoryDescription).HasMaxLength(500);

                entity.Property(e => e.ContactPerson).HasMaxLength(100);

                entity.Property(e => e.ContactPersonDesignation).HasMaxLength(100);

                entity.Property(e => e.ContactPersonEmailAddress).HasMaxLength(100);

                entity.Property(e => e.ContactPersonMobile).HasMaxLength(20);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.CustomsAndVatcommissionarateId).HasColumnName("CustomsAndVATCommissionarateId");

                entity.Property(e => e.DeliveryAddress).HasMaxLength(500);

                entity.Property(e => e.DeliveryContactPerson).HasMaxLength(100);

                entity.Property(e => e.DeliveryContactPersonDesignation).HasMaxLength(100);

                entity.Property(e => e.DeliveryContactPersonEmailAddress).HasMaxLength(100);

                entity.Property(e => e.DeliveryContactPersonMobile).HasMaxLength(20);

                entity.Property(e => e.EmailAddress).HasMaxLength(100);

                entity.Property(e => e.IsTds).HasColumnName("IsTDS");

                entity.Property(e => e.IsVds).HasColumnName("IsVDS");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Nidno)
                    .HasMaxLength(50)
                    .HasColumnName("NIDNo");

                entity.Property(e => e.PhoneNo).HasMaxLength(20);

                entity.Property(e => e.PostCode).HasMaxLength(20);

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.Property(e => e.RegistrationNumberUnderActNinetyFour).HasMaxLength(50);

                entity.Property(e => e.ServiceVatCode).HasMaxLength(50);

                entity.Property(e => e.Tdsrate)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("TDSRate");

                entity.Property(e => e.Tinno)
                    .HasMaxLength(50)
                    .HasColumnName("TINNo");

                entity.Property(e => e.Vdsrate)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("VDSRate");

                entity.HasOne(d => d.BankBranchCountry)
                    .WithMany(p => p.CustomerBankBranchCountries)
                    .HasForeignKey(d => d.BankBranchCountryId)
                    .HasConstraintName("FK_Customer_Country_BankBranch");

                entity.HasOne(d => d.BankBranchDistrictOrCity)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.BankBranchDistrictOrCityId)
                    .HasConstraintName("FK_Customer_DistrictOrCity");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.BankId)
                    .HasConstraintName("FK_Customer_Bank");

                entity.HasOne(d => d.BusinessCategory)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.BusinessCategoryId)
                    .HasConstraintName("FK_Customer_BusinessCategory");

                entity.HasOne(d => d.BusinessNature)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.BusinessNatureId)
                    .HasConstraintName("FK_Customer_BusinessNature");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CustomerCountries)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Customer_Country");

                entity.HasOne(d => d.CustomsAndVatcommissionarate)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.CustomsAndVatcommissionarateId)
                    .HasConstraintName("FK_Customer_CustomsAndVATCommissionarate");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.OrganizationId)
                    .HasConstraintName("FK_Customer_Organizations");
            });

            modelBuilder.Entity<CustomerDeliveryAddress>(entity =>
            {
                entity.ToTable("CustomerDeliveryAddress");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.DeliveryAddress).HasMaxLength(500);

                entity.Property(e => e.DeliveryContactPerson).HasMaxLength(100);

                entity.Property(e => e.DeliveryContactPersonDesignation).HasMaxLength(100);

                entity.Property(e => e.DeliveryContactPersonEmailAddress).HasMaxLength(100);

                entity.Property(e => e.DeliveryContactPersonMobile).HasMaxLength(20);

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerDeliveryAddresses)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerDeliveryAddress_Customer");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.CustomerDeliveryAddresses)
                    .HasForeignKey(d => d.OrganizationId)
                    .HasConstraintName("FK_CustomerDeliveryAddress_Organizations");
            });

            modelBuilder.Entity<CustomsAndVatcommissionarate>(entity =>
            {
                entity.ToTable("CustomsAndVATCommissionarate");

                entity.Property(e => e.CustomsAndVatcommissionarateId)
                    .ValueGeneratedNever()
                    .HasColumnName("CustomsAndVATCommissionarateId");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NameInBangla).HasMaxLength(250);

                entity.Property(e => e.OperationalCode).HasMaxLength(10);

                entity.Property(e => e.OperationalCode1stDigit).HasMaxLength(2);

                entity.Property(e => e.OperationalCode2ndDigit).HasMaxLength(2);

                entity.Property(e => e.OperationalCode3rdDigit).HasMaxLength(2);

                entity.Property(e => e.OperationalCode4thDigit).HasMaxLength(2);
            });

            modelBuilder.Entity<Damage>(entity =>
            {
                entity.ToTable("Damage");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.IsApprovedByNbr).HasColumnName("IsApprovedByNBR");

                entity.Property(e => e.IsDismissedByNbr).HasColumnName("IsDismissedByNBR");

                entity.Property(e => e.NbrsubmissionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("NBRSubmissionDate");

                entity.Property(e => e.NbrverificationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("NBRVerificationDate");

                entity.Property(e => e.NbrverifierDesignation)
                    .HasMaxLength(200)
                    .HasColumnName("NBRVerifierDesignation");

                entity.Property(e => e.NbrverifierName)
                    .HasMaxLength(200)
                    .HasColumnName("NBRVerifierName");

                entity.Property(e => e.PreparedOn).HasColumnType("datetime");

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.Property(e => e.VoucherNo).HasMaxLength(50);

                entity.HasOne(d => d.DamageType)
                    .WithMany(p => p.Damages)
                    .HasForeignKey(d => d.DamageTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Damage_DamageType");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.Damages)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Damage_Organizations");

                entity.HasOne(d => d.Purchase)
                    .WithMany(p => p.Damages)
                    .HasForeignKey(d => d.PurchaseId)
                    .HasConstraintName("FK_Damage_Purchase");

                entity.HasOne(d => d.Sales)
                    .WithMany(p => p.Damages)
                    .HasForeignKey(d => d.SalesId)
                    .HasConstraintName("FK_Damage_Sales");
            });

            modelBuilder.Entity<DamageDetail>(entity =>
            {
                entity.ToTable("DamageDetail");

                entity.Property(e => e.ApprovedNewUnitPrice).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.ApprovedUsableQty).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.DamageDescription).HasMaxLength(200);

                entity.Property(e => e.DamageQty).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.SuggestedNewUnitPrice).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.UsablePercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UsableQty).HasColumnType("decimal(26, 8)");

                entity.HasOne(d => d.Damage)
                    .WithMany(p => p.DamageDetails)
                    .HasForeignKey(d => d.DamageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DamageDetail_Damage");

                entity.HasOne(d => d.MeasurementUnit)
                    .WithMany(p => p.DamageDetails)
                    .HasForeignKey(d => d.MeasurementUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DamageDetail_MeasurementUnits");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DamageDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DamageDetail_Products");

                entity.HasOne(d => d.PurchaseDetail)
                    .WithMany(p => p.DamageDetails)
                    .HasForeignKey(d => d.PurchaseDetailId)
                    .HasConstraintName("FK_DamageDetail_PurchaseDetails");

                entity.HasOne(d => d.SalesDetail)
                    .WithMany(p => p.DamageDetails)
                    .HasForeignKey(d => d.SalesDetailId)
                    .HasConstraintName("FK_DamageDetail_SalesDetails");
            });

            modelBuilder.Entity<DamageType>(entity =>
            {
                entity.ToTable("DamageType");

                entity.Property(e => e.DamageTypeId).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.NameInBangla).HasMaxLength(50);
            });

            modelBuilder.Entity<DebitNote>(entity =>
            {
                entity.ToTable("DebitNote");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.DebitNoteChallanNo).HasMaxLength(50);

                entity.Property(e => e.DebitNoteChallanPrintTime).HasColumnType("datetime");

                entity.Property(e => e.ReasonOfReturn).HasMaxLength(500);

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.Property(e => e.ReturnDate).HasColumnType("datetime");

                entity.Property(e => e.VehicleDriverContactNo).HasMaxLength(50);

                entity.Property(e => e.VehicleDriverName).HasMaxLength(100);

                entity.Property(e => e.VehicleName).HasMaxLength(100);

                entity.Property(e => e.VehicleRegNo).HasMaxLength(50);

                entity.Property(e => e.VoucherNo).HasMaxLength(50);

                entity.HasOne(d => d.MushakGeneration)
                    .WithMany(p => p.DebitNotes)
                    .HasForeignKey(d => d.MushakGenerationId)
                    .HasConstraintName("FK_DebitNote_MushakGeneration");

                entity.HasOne(d => d.Purchase)
                    .WithMany(p => p.DebitNotes)
                    .HasForeignKey(d => d.PurchaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DebitNote_Purchase");
            });

            modelBuilder.Entity<DebitNoteDetail>(entity =>
            {
                entity.ToTable("DebitNoteDetail");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.ReasonOfReturn).HasMaxLength(500);

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.Property(e => e.ReturnQuantity).HasColumnType("decimal(26, 8)");

                entity.HasOne(d => d.DebitNote)
                    .WithMany(p => p.DebitNoteDetails)
                    .HasForeignKey(d => d.DebitNoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DebitNoteDetail_DebitNote");

                entity.HasOne(d => d.MeasurementUnit)
                    .WithMany(p => p.DebitNoteDetails)
                    .HasForeignKey(d => d.MeasurementUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DebitNoteDetail_MeasurementUnits");

                entity.HasOne(d => d.PurchaseDetail)
                    .WithMany(p => p.DebitNoteDetails)
                    .HasForeignKey(d => d.PurchaseDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DebitNoteDetail_PurchaseDetails");
            });

            modelBuilder.Entity<DefaultPercent>(entity =>
            {
                entity.ToTable("DefaultPercent");

                entity.Property(e => e.DefaultPercentFor).HasMaxLength(256);

                entity.Property(e => e.DefaultPercentValue).HasColumnType("decimal(8, 2)");
            });

            modelBuilder.Entity<DeliveryMethod>(entity =>
            {
                entity.ToTable("DeliveryMethod");

                entity.Property(e => e.DeliveryMethodId).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.ToTable("District");

                entity.Property(e => e.DistrictId).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NameInBangla).HasMaxLength(200);
            });

            modelBuilder.Entity<DistrictOrCity>(entity =>
            {
                entity.ToTable("DistrictOrCity");

                entity.HasIndex(e => new { e.OrganizationId, e.DivisionOrStateId, e.DistrictOrCityName }, "Uk_DistrictOrCity_DistrictOrCityName")
                    .IsUnique();

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.DistrictOrCityName).HasMaxLength(250);

                entity.Property(e => e.DistrictOrCityShortName).HasMaxLength(20);

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.HasOne(d => d.DivisionOrState)
                    .WithMany(p => p.DistrictOrCities)
                    .HasForeignKey(d => d.DivisionOrStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DistrictOrCity_DivisionOrState");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.DistrictOrCities)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DistrictOrCity_Organizations");
            });

            modelBuilder.Entity<DivisionOrState>(entity =>
            {
                entity.ToTable("DivisionOrState");

                entity.HasIndex(e => new { e.OrganizationId, e.CountryId, e.DivisionOrStateName }, "UK_DivisionOrState_DivisionOrStateName")
                    .IsUnique();

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.DivisionOrStateName).HasMaxLength(250);

                entity.Property(e => e.DivisionOrStateShortName).HasMaxLength(20);

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.DivisionOrStates)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DivisionOrState_Country");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.DivisionOrStates)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DivisionOrState_Organizations");
            });

            modelBuilder.Entity<DocumentType>(entity =>
            {
                entity.ToTable("DocumentType");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.DocumentTypes)
                    .HasForeignKey(d => d.OrganizationId)
                    .HasConstraintName("FK_DocumentType_Organizations");
            });

            modelBuilder.Entity<ExcelDataUpload>(entity =>
            {
                entity.ToTable("ExcelDataUpload");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.ProcessingMessage).HasMaxLength(1000);

                entity.Property(e => e.StoredFileName).HasMaxLength(500);

                entity.Property(e => e.StoredFilePath).HasMaxLength(1000);

                entity.Property(e => e.UploadTime).HasColumnType("datetime");

                entity.Property(e => e.UploadedFileName).HasMaxLength(500);

                entity.HasOne(d => d.ExcelUploadedDataType)
                    .WithMany(p => p.ExcelDataUploads)
                    .HasForeignKey(d => d.ExcelUploadedDataTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExcelDataUpload_ExcelUploadedDataType");
            });

            modelBuilder.Entity<ExcelSimplifiedLocalPurchase>(entity =>
            {
                entity.ToTable("ExcelSimplifiedLocalPurchase");

                entity.Property(e => e.BranchAddress).HasMaxLength(500);

                entity.Property(e => e.BranchId).HasMaxLength(100);

                entity.Property(e => e.BranchName).HasMaxLength(250);

                entity.Property(e => e.ChallanDate).HasColumnType("datetime");

                entity.Property(e => e.ChallanNo).HasMaxLength(50);

                entity.Property(e => e.ChequeBankName).HasMaxLength(250);

                entity.Property(e => e.ChequeDate).HasColumnType("datetime");

                entity.Property(e => e.ChequeNo).HasMaxLength(50);

                entity.Property(e => e.DiscountPerItem).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.HsCode).HasMaxLength(50);

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.MeasurementUnitName).HasMaxLength(50);

                entity.Property(e => e.PaymentAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentId).HasMaxLength(100);

                entity.Property(e => e.PaymentMethod).HasMaxLength(50);

                entity.Property(e => e.PaymentTransactionId).HasMaxLength(50);

                entity.Property(e => e.PaymentWalletNo).HasMaxLength(20);

                entity.Property(e => e.ProcessingMessage).HasMaxLength(2000);

                entity.Property(e => e.ProductGroupName).HasMaxLength(200);

                entity.Property(e => e.ProductId).HasMaxLength(100);

                entity.Property(e => e.ProductName).HasMaxLength(200);

                entity.Property(e => e.ProductType).HasMaxLength(200);

                entity.Property(e => e.PurchaseDate).HasColumnType("datetime");

                entity.Property(e => e.PurchaseDetailId).HasMaxLength(100);

                entity.Property(e => e.PurchaseId).HasMaxLength(100);

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SupplementaryDutyPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TdsAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VatPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VatType).HasMaxLength(500);

                entity.Property(e => e.VdsAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VendorAddress).HasMaxLength(500);

                entity.Property(e => e.VendorBin).HasMaxLength(50);

                entity.Property(e => e.VendorEmail).HasMaxLength(100);

                entity.Property(e => e.VendorId).HasMaxLength(100);

                entity.Property(e => e.VendorMobile).HasMaxLength(20);

                entity.Property(e => e.VendorName).HasMaxLength(200);

                entity.Property(e => e.VendorNid).HasMaxLength(50);

                entity.Property(e => e.VendorTin).HasMaxLength(50);

                entity.HasOne(d => d.ExcelDataUpload)
                    .WithMany(p => p.ExcelSimplifiedLocalPurchases)
                    .HasForeignKey(d => d.ExcelDataUploadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExcelSimplifiedLocalPurchase_ExcelDataUpload");
            });

            modelBuilder.Entity<ExcelSimplifiedPurchase>(entity =>
            {
                entity.ToTable("ExcelSimplifiedPurchase");

                entity.Property(e => e.BranchAddress).HasMaxLength(500);

                entity.Property(e => e.BranchId).HasMaxLength(100);

                entity.Property(e => e.BranchName).HasMaxLength(250);

                entity.Property(e => e.ChallanDate).HasColumnType("datetime");

                entity.Property(e => e.ChallanNo).HasMaxLength(50);

                entity.Property(e => e.ChequeBankName).HasMaxLength(250);

                entity.Property(e => e.ChequeDate).HasColumnType("datetime");

                entity.Property(e => e.ChequeNo).HasMaxLength(50);

                entity.Property(e => e.DiscountPerItem).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.HsCode).HasMaxLength(50);

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.MeasurementUnitName).HasMaxLength(50);

                entity.Property(e => e.PaymentAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentId).HasMaxLength(100);

                entity.Property(e => e.PaymentMethod).HasMaxLength(50);

                entity.Property(e => e.PaymentTransactionId).HasMaxLength(50);

                entity.Property(e => e.PaymentWalletNo).HasMaxLength(20);

                entity.Property(e => e.ProcessingMessage).HasMaxLength(2000);

                entity.Property(e => e.ProductGroupName).HasMaxLength(200);

                entity.Property(e => e.ProductId).HasMaxLength(100);

                entity.Property(e => e.ProductName).HasMaxLength(200);

                entity.Property(e => e.ProductType).HasMaxLength(200);

                entity.Property(e => e.PurchaseDate).HasColumnType("datetime");

                entity.Property(e => e.PurchaseDetailId).HasMaxLength(100);

                entity.Property(e => e.PurchaseId).HasMaxLength(100);

                entity.Property(e => e.PurchaseType).HasMaxLength(50);

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SupplementaryDutyPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TdsAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VatPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VatType).HasMaxLength(500);

                entity.Property(e => e.VdsAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VendorAddress).HasMaxLength(500);

                entity.Property(e => e.VendorBin).HasMaxLength(50);

                entity.Property(e => e.VendorId).HasMaxLength(100);

                entity.Property(e => e.VendorName).HasMaxLength(200);

                entity.Property(e => e.VendorNid).HasMaxLength(50);

                entity.Property(e => e.VendorTin).HasMaxLength(50);

                entity.HasOne(d => d.ExcelDataUpload)
                    .WithMany(p => p.ExcelSimplifiedPurchases)
                    .HasForeignKey(d => d.ExcelDataUploadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExcelSimplifiedPurchase_ExcelDataUpload");
            });

            modelBuilder.Entity<ExcelSimplifiedSalse>(entity =>
            {
                entity.ToTable("ExcelSimplifiedSalse");

                entity.Property(e => e.BankDepositDate).HasColumnType("datetime");

                entity.Property(e => e.BranchAddress).HasMaxLength(500);

                entity.Property(e => e.BranchId).HasMaxLength(100);

                entity.Property(e => e.BranchName).HasMaxLength(250);

                entity.Property(e => e.ChequeBankName).HasMaxLength(250);

                entity.Property(e => e.ChequeDate).HasColumnType("datetime");

                entity.Property(e => e.ChequeNo).HasMaxLength(50);

                entity.Property(e => e.CustomerAddress).HasMaxLength(500);

                entity.Property(e => e.CustomerBin).HasMaxLength(50);

                entity.Property(e => e.CustomerEmail).HasMaxLength(100);

                entity.Property(e => e.CustomerId).HasMaxLength(100);

                entity.Property(e => e.CustomerMobile).HasMaxLength(20);

                entity.Property(e => e.CustomerName).HasMaxLength(200);

                entity.Property(e => e.CustomerNid).HasMaxLength(50);

                entity.Property(e => e.CustomerTin).HasMaxLength(50);

                entity.Property(e => e.DeliveryAddress).HasMaxLength(500);

                entity.Property(e => e.DeliveryMethod).HasMaxLength(100);

                entity.Property(e => e.DiscountPerItem).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ExportType).HasMaxLength(50);

                entity.Property(e => e.HsCode).HasMaxLength(50);

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.MeasurementUnitName).HasMaxLength(50);

                entity.Property(e => e.MoneyReceiptNumber).HasMaxLength(50);

                entity.Property(e => e.PaymentReceiveAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaymentReceiveDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentReceiveId).HasMaxLength(100);

                entity.Property(e => e.PaymentReceiveMethod).HasMaxLength(50);

                entity.Property(e => e.PaymentTransactionId).HasMaxLength(50);

                entity.Property(e => e.PaymentWalletNo).HasMaxLength(20);

                entity.Property(e => e.ProcessingMessage).HasMaxLength(2000);

                entity.Property(e => e.ProductGroupName).HasMaxLength(200);

                entity.Property(e => e.ProductId).HasMaxLength(100);

                entity.Property(e => e.ProductName).HasMaxLength(200);

                entity.Property(e => e.ProductType).HasMaxLength(200);

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReceiverMobile).HasMaxLength(20);

                entity.Property(e => e.ReceiverName).HasMaxLength(100);

                entity.Property(e => e.SalesDate).HasColumnType("datetime");

                entity.Property(e => e.SalesDetailId).HasMaxLength(100);

                entity.Property(e => e.SalesId).HasMaxLength(100);

                entity.Property(e => e.SalesType).HasMaxLength(50);

                entity.Property(e => e.SupplementaryDutyPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TdsAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VatPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VatType).HasMaxLength(500);

                entity.Property(e => e.VdsAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VehicleDriverMobile).HasMaxLength(20);

                entity.Property(e => e.VehicleDriverName).HasMaxLength(100);

                entity.Property(e => e.VehicleRegistrationNo).HasMaxLength(50);

                entity.Property(e => e.VehicleTypeName).HasMaxLength(100);

                entity.HasOne(d => d.ExcelDataUpload)
                    .WithMany(p => p.ExcelSimplifiedSalses)
                    .HasForeignKey(d => d.ExcelDataUploadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExcelSimplifiedSalse_ExcelDataUpload");
            });

            modelBuilder.Entity<ExcelUploadedDataType>(entity =>
            {
                entity.ToTable("ExcelUploadedDataType");

                entity.Property(e => e.ExcelUploadedDataTypeId).ValueGeneratedNever();

                entity.Property(e => e.ExcelUploadedDataTypeName)
                    .HasMaxLength(250)
                    .HasColumnName("ExcelUPloadedDataTypeName");
            });

            modelBuilder.Entity<ExportType>(entity =>
            {
                entity.ToTable("ExportType");

                entity.Property(e => e.ExportTypeId).ValueGeneratedNever();

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.ExportTypeName).HasMaxLength(50);

                entity.Property(e => e.ExportTypeNameInBangla).HasMaxLength(50);
            });

            modelBuilder.Entity<FinancialActivityNature>(entity =>
            {
                entity.ToTable("FinancialActivityNature");

                entity.Property(e => e.FinancialActivityNatureId).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NameInBangla).HasMaxLength(100);
            });

            modelBuilder.Entity<InputOutputCoEfficient>(entity =>
            {
                entity.ToTable("InputOutputCoEfficient");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.EffectiveFrom).HasColumnType("datetime");

                entity.Property(e => e.EffectiveTo).HasColumnType("datetime");

                entity.Property(e => e.SubmissionDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MasterPurchase>(entity =>
            {
                entity.ToTable("MasterPurchase");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CustomerContactNo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Customername)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MasterPurchaseDetail>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Purchase)
                    .WithMany(p => p.MasterPurchaseDetails)
                    .HasForeignKey(d => d.PurchaseId)
                    .HasConstraintName("FK_MasterPurchaseDetails_MasterPurchase");
            });

            modelBuilder.Entity<MeasurementUnit>(entity =>
            {
                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);
            });

            modelBuilder.Entity<MushakGeneration>(entity =>
            {
                entity.ToTable("MushakGeneration");

                entity.Property(e => e.GenerateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.MushakGenerations)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MushakGeneration_Organizations");
            });

            modelBuilder.Entity<MushakGenerationStage>(entity =>
            {
                entity.ToTable("MushakGenerationStage");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NameInBangla).HasMaxLength(100);
            });

            modelBuilder.Entity<MushakReturnPayment>(entity =>
            {
                entity.ToTable("MushakReturnPayment");

                entity.Property(e => e.BankBranchName).HasMaxLength(250);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.CustomsAndVatcommissionarateId).HasColumnName("CustomsAndVATCommissionarateId");

                entity.Property(e => e.EconomicCode10thDisit).HasMaxLength(2);

                entity.Property(e => e.EconomicCode11thDisit).HasMaxLength(2);

                entity.Property(e => e.EconomicCode12thDisit).HasMaxLength(2);

                entity.Property(e => e.EconomicCode13thDisit).HasMaxLength(2);

                entity.Property(e => e.EconomicCode1stDisit).HasMaxLength(2);

                entity.Property(e => e.EconomicCode2ndDisit).HasMaxLength(2);

                entity.Property(e => e.EconomicCode3rdDisit).HasMaxLength(2);

                entity.Property(e => e.EconomicCode4thDisit).HasMaxLength(2);

                entity.Property(e => e.EconomicCode5thDisit).HasMaxLength(2);

                entity.Property(e => e.EconomicCode6thDisit).HasMaxLength(2);

                entity.Property(e => e.EconomicCode7thDisit).HasMaxLength(2);

                entity.Property(e => e.EconomicCode8thDisit).HasMaxLength(2);

                entity.Property(e => e.EconomicCode9thDisit).HasMaxLength(2);

                entity.Property(e => e.PaidAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.Property(e => e.SubimissionDate).HasColumnType("datetime");

                entity.Property(e => e.SubmissionEntryDate).HasColumnType("datetime");

                entity.Property(e => e.TreasuryChallanNo).HasMaxLength(50);

                entity.HasOne(d => d.BankBranchCountry)
                    .WithMany(p => p.MushakReturnPayments)
                    .HasForeignKey(d => d.BankBranchCountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MushakReturnPayment_Country");

                entity.HasOne(d => d.BankBranchDistrictOrCity)
                    .WithMany(p => p.MushakReturnPayments)
                    .HasForeignKey(d => d.BankBranchDistrictOrCityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MushakReturnPayment_DistrictOrCity");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.MushakReturnPayments)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MushakReturnPayment_Bank");

                entity.HasOne(d => d.CustomsAndVatcommissionarate)
                    .WithMany(p => p.MushakReturnPayments)
                    .HasForeignKey(d => d.CustomsAndVatcommissionarateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MushakReturnPayment_CustomsAndVATCommissionarate");

                entity.HasOne(d => d.MushakReturnPaymentType)
                    .WithMany(p => p.MushakReturnPayments)
                    .HasForeignKey(d => d.MushakReturnPaymentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MushakReturnPayment_MushakReturnPaymentType");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.MushakReturnPayments)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MushakReturnPayment_Organizations");
            });

            modelBuilder.Entity<MushakReturnPaymentForVd>(entity =>
            {
                entity.HasKey(e => e.MushakReturnPaymentForVdsId);

                entity.Property(e => e.VdsPaidAmount).HasColumnType("decimal(26, 8)");

                entity.HasOne(d => d.MushakReturnPayment)
                    .WithMany(p => p.MushakReturnPaymentForVds)
                    .HasForeignKey(d => d.MushakReturnPaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MushakReturnPaymentForVds_MushakReturnPayment");

                entity.HasOne(d => d.Purchase)
                    .WithMany(p => p.MushakReturnPaymentForVds)
                    .HasForeignKey(d => d.PurchaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MushakReturnPaymentForVds_Purchase");
            });

            modelBuilder.Entity<MushakReturnPaymentType>(entity =>
            {
                entity.ToTable("MushakReturnPaymentType");

                entity.Property(e => e.MushakReturnPaymentTypeId).ValueGeneratedNever();

                entity.Property(e => e.EffectiveFrom)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EffectiveTo).HasColumnType("datetime");

                entity.Property(e => e.NoteNo).HasMaxLength(20);

                entity.Property(e => e.SubFormId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubFormName).HasMaxLength(200);

                entity.Property(e => e.TypeName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TypeNameBn).HasMaxLength(200);

                entity.HasOne(d => d.NbrEconomicCode)
                    .WithMany(p => p.MushakReturnPaymentTypes)
                    .HasForeignKey(d => d.NbrEconomicCodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MushakReturnPaymentType_NbrEconomicCode");
            });

            modelBuilder.Entity<MushakReturnRefund>(entity =>
            {
                entity.ToTable("MushakReturnRefund");

                entity.HasIndex(e => new { e.OrganizationId, e.MushakYear, e.MushakMonth }, "UK_MushakReturnRefund_Organization_Month")
                    .IsUnique();

                entity.Property(e => e.ApprovedToRefundSdamount)
                    .HasColumnType("decimal(26, 8)")
                    .HasColumnName("ApprovedToRefundSDAmount");

                entity.Property(e => e.ApprovedToRefundVatamount)
                    .HasColumnType("decimal(26, 8)")
                    .HasColumnName("ApprovedToRefundVATAmount");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.InterestedToRefundSdamount)
                    .HasColumnType("decimal(26, 8)")
                    .HasColumnName("InterestedToRefundSDAmount");

                entity.Property(e => e.InterestedToRefundVatamount)
                    .HasColumnType("decimal(26, 8)")
                    .HasColumnName("InterestedToRefundVATAmount");

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.Property(e => e.RefundedSdamount)
                    .HasColumnType("decimal(26, 8)")
                    .HasColumnName("RefundedSDAmount");

                entity.Property(e => e.RefundedSdchequeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("RefundedSDChequeDate");

                entity.Property(e => e.RefundedSdchequeNo)
                    .HasMaxLength(50)
                    .HasColumnName("RefundedSDChequeNo");

                entity.Property(e => e.RefundedVatamount)
                    .HasColumnType("decimal(26, 8)")
                    .HasColumnName("RefundedVATAmount");

                entity.Property(e => e.RefundedVatchequeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("RefundedVATChequeDate");

                entity.Property(e => e.RefundedVatchequeNo)
                    .HasMaxLength(50)
                    .HasColumnName("RefundedVATChequeNo");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.MushakReturnRefunds)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MushakReturnRefund_Organizations");
            });

            modelBuilder.Entity<MushakSubmission>(entity =>
            {
                entity.ToTable("MushakSubmission");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.GenerateDate).HasColumnType("datetime");

                entity.Property(e => e.SubmissionDate).HasColumnType("datetime");

                entity.HasOne(d => d.MushakSubmissionType)
                    .WithMany(p => p.MushakSubmissions)
                    .HasForeignKey(d => d.MushakSubmissionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MushakSubmission_MushakSubmissionType");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.MushakSubmissions)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MushakSubmission_Organizations");
            });

            modelBuilder.Entity<MushakSubmissionType>(entity =>
            {
                entity.ToTable("MushakSubmissionType");

                entity.Property(e => e.SubmissionTypeName).HasMaxLength(200);

                entity.Property(e => e.SubmissionTypeNameBn).HasMaxLength(200);
            });

            modelBuilder.Entity<NbrEconomicCode>(entity =>
            {
                entity.ToTable("NbrEconomicCode");

                entity.Property(e => e.NbrEconomicCodeId).ValueGeneratedNever();

                entity.Property(e => e.Code10thDisit).HasMaxLength(2);

                entity.Property(e => e.Code11thDisit).HasMaxLength(2);

                entity.Property(e => e.Code12thDisit).HasMaxLength(2);

                entity.Property(e => e.Code13thDisit).HasMaxLength(2);

                entity.Property(e => e.Code1stDisit).HasMaxLength(2);

                entity.Property(e => e.Code2ndDisit).HasMaxLength(2);

                entity.Property(e => e.Code3rdDisit).HasMaxLength(2);

                entity.Property(e => e.Code4thDisit).HasMaxLength(2);

                entity.Property(e => e.Code5thDisit).HasMaxLength(2);

                entity.Property(e => e.Code6thDisit).HasMaxLength(2);

                entity.Property(e => e.Code7thDisit).HasMaxLength(2);

                entity.Property(e => e.Code8thDisit).HasMaxLength(2);

                entity.Property(e => e.Code9thDisit).HasMaxLength(2);

                entity.Property(e => e.EconomicCode).HasMaxLength(200);

                entity.Property(e => e.EconomicTitle).HasMaxLength(200);

                entity.Property(e => e.EffectiveFrom)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EffectiveTo).HasColumnType("datetime");

                entity.HasOne(d => d.NbrEconomicCodeType)
                    .WithMany(p => p.NbrEconomicCodes)
                    .HasForeignKey(d => d.NbrEconomicCodeTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NbrEconomicCode_NbrEconomicCodeType");
            });

            modelBuilder.Entity<NbrEconomicCodeType>(entity =>
            {
                entity.ToTable("NbrEconomicCodeType");

                entity.Property(e => e.NbrEconomicCodeTypeId).ValueGeneratedNever();

                entity.Property(e => e.CodeTypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<ObjectType>(entity =>
            {
                entity.ToTable("ObjectType");

                entity.Property(e => e.ObjectTypeId).ValueGeneratedNever();

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<OldAccountCurrentBalance>(entity =>
            {
                entity.ToTable("OldAccountCurrentBalance");

                entity.HasIndex(e => new { e.OrganizationId, e.MushakYear, e.MushakMonth }, "UK_OldAccountCurrentBalance_Organization_Month")
                    .IsUnique();

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.Property(e => e.RemainingSdbalance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("RemainingSDBalance");

                entity.Property(e => e.RemainingVatbalance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("RemainingVATBalance");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.OldAccountCurrentBalances)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OldAccountCurrentBalance_Organizations");
            });

            modelBuilder.Entity<OrgBranch>(entity =>
            {
                entity.ToTable("OrgBranch");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.BusinessCategoryDescription).HasMaxLength(500);

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.CustomsAndVatcommissionarateId).HasColumnName("CustomsAndVATCommissionarateId");

                entity.Property(e => e.EmailAddress).HasMaxLength(100);

                entity.Property(e => e.Mobile).HasMaxLength(20);

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.Property(e => e.VatResponsiblePersonDesignation).HasMaxLength(50);

                entity.Property(e => e.VatResponsiblePersonEmailAddress).HasMaxLength(100);

                entity.Property(e => e.VatResponsiblePersonMobileNo).HasMaxLength(100);

                entity.Property(e => e.VatResponsiblePersonName).HasMaxLength(100);

                entity.Property(e => e.VatResponsiblePersonSignUrl).HasMaxLength(500);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.OrgBranches)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrgBranch_Country");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.OrgBranches)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_OrgBranch_District");

                entity.HasOne(d => d.OrgBranchType)
                    .WithMany(p => p.OrgBranches)
                    .HasForeignKey(d => d.OrgBranchTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrgBranch_OrgBranchType");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.OrgBranches)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrgBranch_Organizations");
            });

            modelBuilder.Entity<OrgBranchType>(entity =>
            {
                entity.ToTable("OrgBranchType");

                entity.Property(e => e.OrgBranchTypeId).ValueGeneratedNever();

                entity.Property(e => e.BranchTypeName).HasMaxLength(200);

                entity.Property(e => e.BranchTypeNameBangla).HasMaxLength(200);
            });

            modelBuilder.Entity<OrgStaticDataType>(entity =>
            {
                entity.ToTable("OrgStaticDataType");

                entity.Property(e => e.OrgStaticDataTypeId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<OrgStaticDatum>(entity =>
            {
                entity.HasKey(e => e.OrgStaticDataId);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.EffectiveFrom).HasColumnType("datetime");

                entity.Property(e => e.EffectiveTo).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.HasOne(d => d.OrgStaticDataType)
                    .WithMany(p => p.OrgStaticData)
                    .HasForeignKey(d => d.OrgStaticDataTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrgStaticData_OrgStaticDataType");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.OrgStaticData)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrgStaticData_Organizations");
            });

            modelBuilder.Entity<Organization>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.Bin)
                    .HasMaxLength(50)
                    .HasColumnName("BIN");

                entity.Property(e => e.BusinessCategoryDescription).HasMaxLength(500);

                entity.Property(e => e.CertificateNo).HasMaxLength(50);

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.CustomsAndVatcommissionarateId).HasColumnName("CustomsAndVATCommissionarateId");

                entity.Property(e => e.EmailAddress).HasMaxLength(100);

                entity.Property(e => e.InvoiceNameBan).HasMaxLength(50);

                entity.Property(e => e.InvoiceNameEng).HasMaxLength(50);

                entity.Property(e => e.Mobile).HasMaxLength(20);

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.ServiceChargePercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VatResponsiblePersonDesignation).HasMaxLength(50);

                entity.Property(e => e.VatResponsiblePersonEmailAddress).HasMaxLength(100);

                entity.Property(e => e.VatResponsiblePersonMobileNo).HasMaxLength(100);

                entity.Property(e => e.VatResponsiblePersonName).HasMaxLength(100);

                entity.Property(e => e.VatResponsiblePersonSignUrl).HasMaxLength(500);

                entity.Property(e => e.VatregNo)
                    .HasMaxLength(50)
                    .HasColumnName("VATRegNo");

                entity.HasOne(d => d.BusinessCategory)
                    .WithMany(p => p.Organizations)
                    .HasForeignKey(d => d.BusinessCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Organizations_BusinessCategory");

                entity.HasOne(d => d.BusinessNature)
                    .WithMany(p => p.Organizations)
                    .HasForeignKey(d => d.BusinessNatureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Organizations_BusinessNature");

                entity.HasOne(d => d.CustomsAndVatcommissionarate)
                    .WithMany(p => p.Organizations)
                    .HasForeignKey(d => d.CustomsAndVatcommissionarateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Organizations_CustomsAndVATCommissionarate");

                entity.HasOne(d => d.FinancialActivityNature)
                    .WithMany(p => p.Organizations)
                    .HasForeignKey(d => d.FinancialActivityNatureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Organizations_FinancialActivityNature");
            });

            modelBuilder.Entity<OrganizationConfig>(entity =>
            {
                entity.ToTable("OrganizationConfig");

                entity.Property(e => e.ConfigValue).HasMaxLength(500);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.EffectiveFrom).HasColumnType("datetime");

                entity.Property(e => e.EffectiveTo).HasColumnType("datetime");

                entity.HasOne(d => d.OrganizationConfigType)
                    .WithMany(p => p.OrganizationConfigs)
                    .HasForeignKey(d => d.OrganizationConfigTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrganizationConfig_OrganizationConfigType");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.OrganizationConfigs)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrganizationConfig_Organizations");
            });

            modelBuilder.Entity<OrganizationConfigType>(entity =>
            {
                entity.ToTable("OrganizationConfigType");

                entity.Property(e => e.OrganizationConfigTypeId).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<OrganizationConfigurationArea>(entity =>
            {
                entity.ToTable("OrganizationConfigurationArea");

                entity.Property(e => e.OrganizationConfigurationAreaId).ValueGeneratedNever();

                entity.Property(e => e.OrganizationConfigurationAreaName).HasMaxLength(100);
            });

            modelBuilder.Entity<OrganizationConfigurationBooleanType>(entity =>
            {
                entity.ToTable("OrganizationConfigurationBooleanType");

                entity.Property(e => e.OrganizationConfigurationBooleanTypeId).ValueGeneratedNever();

                entity.Property(e => e.OrganizationConfigurationBooleanTypeName).HasMaxLength(250);

                entity.HasOne(d => d.OrganizationConfigurationArea)
                    .WithMany(p => p.OrganizationConfigurationBooleanTypes)
                    .HasForeignKey(d => d.OrganizationConfigurationAreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrganizationConfigurationBooleanType_OrganizationConfigurationArea");
            });

            modelBuilder.Entity<OrganizationConfigurationDecimalType>(entity =>
            {
                entity.ToTable("OrganizationConfigurationDecimalType");

                entity.Property(e => e.OrganizationConfigurationDecimalTypeId).ValueGeneratedNever();

                entity.Property(e => e.DefaultValue).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.OrganizationConfigurationDecimalTypeName).HasMaxLength(250);

                entity.HasOne(d => d.OrganizationConfigurationArea)
                    .WithMany(p => p.OrganizationConfigurationDecimalTypes)
                    .HasForeignKey(d => d.OrganizationConfigurationAreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrganizationConfigurationDecimalType_OrganizationConfigurationArea");
            });

            modelBuilder.Entity<OrganizationConfigurationIntType>(entity =>
            {
                entity.ToTable("OrganizationConfigurationIntType");

                entity.Property(e => e.OrganizationConfigurationIntTypeId).ValueGeneratedNever();

                entity.Property(e => e.OrganizationConfigurationIntTypeName).HasMaxLength(250);

                entity.HasOne(d => d.OrganizationConfigurationArea)
                    .WithMany(p => p.OrganizationConfigurationIntTypes)
                    .HasForeignKey(d => d.OrganizationConfigurationAreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrganizationConfigurationIntType_OrganizationConfigurationArea");
            });

            modelBuilder.Entity<OrganizationConfigurationStringType>(entity =>
            {
                entity.ToTable("OrganizationConfigurationStringType");

                entity.Property(e => e.OrganizationConfigurationStringTypeId).ValueGeneratedNever();

                entity.Property(e => e.DefaultValue).HasMaxLength(250);

                entity.Property(e => e.OrganizationConfigurationStringTypeName).HasMaxLength(250);

                entity.HasOne(d => d.OrganizationConfigurationArea)
                    .WithMany(p => p.OrganizationConfigurationStringTypes)
                    .HasForeignKey(d => d.OrganizationConfigurationAreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrganizationConfigurationStringType_OrganizationConfigurationArea");
            });

            modelBuilder.Entity<OverHeadCost>(entity =>
            {
                entity.ToTable("OverHeadCost");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.HasOne(d => d.ApiTransaction)
                    .WithMany(p => p.OverHeadCosts)
                    .HasForeignKey(d => d.ApiTransactionId)
                    .HasConstraintName("FK_OverHeadCost_ApiTransaction");
            });

            modelBuilder.Entity<PaymentMethod>(entity =>
            {
                entity.ToTable("PaymentMethod");

                entity.Property(e => e.PaymentMethodId).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<PaymentReason>(entity =>
            {
                entity.ToTable("PaymentReason");

                entity.Property(e => e.PaymentReasonId).ValueGeneratedNever();

                entity.Property(e => e.ReasonName).HasMaxLength(200);
            });

            modelBuilder.Entity<PriceSetup>(entity =>
            {
                entity.ToTable("PriceSetup");

                entity.Property(e => e.BaseTp)
                    .HasColumnType("decimal(26, 8)")
                    .HasColumnName("BaseTP");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.EffectiveFrom).HasColumnType("datetime");

                entity.Property(e => e.EffectiveTo).HasColumnType("datetime");

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(26, 8)")
                    .HasColumnName("MRP");

                entity.Property(e => e.MushakSubmissionDate).HasColumnType("datetime");

                entity.Property(e => e.ProfitAmount).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.PurchaseUnitPrice).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.Property(e => e.SalesUnitPrice).HasColumnType("decimal(26, 8)");

                entity.HasOne(d => d.MeasurementUnit)
                    .WithMany(p => p.PriceSetups)
                    .HasForeignKey(d => d.MeasurementUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PriceSetup_MeasurementUnits");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.PriceSetups)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PriceSetup_Organizations");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.PriceSetups)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PriceSetup_Products");
            });

            modelBuilder.Entity<PriceSetupProductCost>(entity =>
            {
                entity.ToTable("PriceSetupProductCost");

                entity.Property(e => e.Cost).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.Property(e => e.RequiredQty).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.WastagePercentage).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.MeasurementUnit)
                    .WithMany(p => p.PriceSetupProductCosts)
                    .HasForeignKey(d => d.MeasurementUnitId)
                    .HasConstraintName("FK_PriceSetupProductCost_MeasurementUnits");

                entity.HasOne(d => d.OverHeadCost)
                    .WithMany(p => p.PriceSetupProductCosts)
                    .HasForeignKey(d => d.OverHeadCostId)
                    .HasConstraintName("FK_PriceSetupProductCost_OverHeadCost");

                entity.HasOne(d => d.PriceSetup)
                    .WithMany(p => p.PriceSetupProductCosts)
                    .HasForeignKey(d => d.PriceSetupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PriceSetupProductCost_PriceSetup");

                entity.HasOne(d => d.RawMaterial)
                    .WithMany(p => p.PriceSetupProductCosts)
                    .HasForeignKey(d => d.RawMaterialId)
                    .HasConstraintName("FK_PriceSetupProductCost_Products");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Color).HasMaxLength(100);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.DeviceModel).HasMaxLength(50);

                entity.Property(e => e.EffectiveFrom).HasColumnType("datetime");

                entity.Property(e => e.EffectiveTo).HasColumnType("datetime");

                entity.Property(e => e.Hscode)
                    .HasMaxLength(50)
                    .HasColumnName("HSCode");

                entity.Property(e => e.ModelNo).HasMaxLength(50);

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.PartCode).HasMaxLength(100);

                entity.Property(e => e.PartNo).HasMaxLength(100);

                entity.Property(e => e.ProductNumber).HasMaxLength(50);

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.Property(e => e.Size).HasMaxLength(100);

                entity.Property(e => e.Specification).HasMaxLength(100);

                entity.Property(e => e.TotalQuantity).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.Variant).HasMaxLength(100);

                entity.Property(e => e.Weight).HasMaxLength(100);

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_Products_Brand");

                entity.HasOne(d => d.MeasurementUnit)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.MeasurementUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Products_MeasurementUnits");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Products_Organizations");

                entity.HasOne(d => d.ProductCategory)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductCategoryId)
                    .HasConstraintName("FK_Products_ProductCategory");

                entity.HasOne(d => d.ProductGroup)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Products_ProductGroups");

                entity.HasOne(d => d.ProductType)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Products_ProductType");
            });

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.ToTable("ProductCategory");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.ProductCategories)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductCategory_Organizations");
            });

            modelBuilder.Entity<ProductGroup>(entity =>
            {
                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Node).HasMaxLength(50);

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.ProductGroups)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductGroups_Organizations");
            });

            modelBuilder.Entity<ProductOpeningBalance>(entity =>
            {
                entity.ToTable("ProductOpeningBalance");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Quantity).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.Property(e => e.ReferenceNo).HasMaxLength(100);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(26, 8)");

                entity.HasOne(d => d.MeasurementUnit)
                    .WithMany(p => p.ProductOpeningBalances)
                    .HasForeignKey(d => d.MeasurementUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductOpeningBalance_MeasurementUnits");

                entity.HasOne(d => d.OrgBranch)
                    .WithMany(p => p.ProductOpeningBalances)
                    .HasForeignKey(d => d.OrgBranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductOpeningBalance_OrgBranch");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.ProductOpeningBalances)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductOpeningBalance_Organizations");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductOpeningBalances)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductOpeningBalance_Products");
            });

            modelBuilder.Entity<ProductTransactionBook>(entity =>
            {
                entity.ToTable("ProductTransactionBook");

                entity.Property(e => e.InitQty).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.InitUnitPrice).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.TransactionTime).HasColumnType("datetime");

                entity.HasOne(d => d.BranchTransferReceiveDetail)
                    .WithMany(p => p.ProductTransactionBooks)
                    .HasForeignKey(d => d.BranchTransferReceiveDetailId)
                    .HasConstraintName("FK_ProductTransactionBook_BranchTransferReceiveDetails");

                entity.HasOne(d => d.BranchTransferSendDetail)
                    .WithMany(p => p.ProductTransactionBooks)
                    .HasForeignKey(d => d.BranchTransferSendDetailId)
                    .HasConstraintName("FK_ProductTransactionBook_BranchTransferSendDetails");

                entity.HasOne(d => d.CreditNoteDetail)
                    .WithMany(p => p.ProductTransactionBooks)
                    .HasForeignKey(d => d.CreditNoteDetailId)
                    .HasConstraintName("FK_ProductTransactionBook_CreditNoteDetail");

                entity.HasOne(d => d.DamageDetail)
                    .WithMany(p => p.ProductTransactionBooks)
                    .HasForeignKey(d => d.DamageDetailId)
                    .HasConstraintName("FK_ProductTransactionBook_DamageDetail");

                entity.HasOne(d => d.DebitNoteDetail)
                    .WithMany(p => p.ProductTransactionBooks)
                    .HasForeignKey(d => d.DebitNoteDetailId)
                    .HasConstraintName("FK_ProductTransactionBook_DebitNoteDetail");

                entity.HasOne(d => d.InitProductMeasurementUnit)
                    .WithMany(p => p.ProductTransactionBooks)
                    .HasForeignKey(d => d.InitProductMeasurementUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductTransactionBook_MeasurementUnits");

                entity.HasOne(d => d.OrgBranch)
                    .WithMany(p => p.ProductTransactionBooks)
                    .HasForeignKey(d => d.OrgBranchId)
                    .HasConstraintName("FK_ProductTransactionBook_OrgBranch");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.ProductTransactionBooks)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductTransactionBook_Organizations");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductTransactionBooks)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductTransactionBook_Products");

                entity.HasOne(d => d.ProductOpeningBalance)
                    .WithMany(p => p.ProductTransactionBooks)
                    .HasForeignKey(d => d.ProductOpeningBalanceId)
                    .HasConstraintName("FK_ProductTransactionBook_ProductOpeningBalance");

                entity.HasOne(d => d.ProductionReceive)
                    .WithMany(p => p.ProductTransactionBooks)
                    .HasForeignKey(d => d.ProductionReceiveId)
                    .HasConstraintName("FK_ProductTransactionBook_ProductionReceive");

                entity.HasOne(d => d.PurchaseDetail)
                    .WithMany(p => p.ProductTransactionBooks)
                    .HasForeignKey(d => d.PurchaseDetailId)
                    .HasConstraintName("FK_ProductTransactionBook_PurchaseDetails");

                entity.HasOne(d => d.SalesDetail)
                    .WithMany(p => p.ProductTransactionBooks)
                    .HasForeignKey(d => d.SalesDetailId)
                    .HasConstraintName("FK_ProductTransactionBook_SalesDetails");

                entity.HasOne(d => d.UsedInProduction)
                    .WithMany(p => p.ProductTransactionBooks)
                    .HasForeignKey(d => d.UsedInProductionId)
                    .HasConstraintName("FK_ProductTransactionBook_BillOfMaterial");
            });

            modelBuilder.Entity<ProductType>(entity =>
            {
                entity.ToTable("ProductType");

                entity.Property(e => e.ProductTypeId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.ShortName).HasMaxLength(10);
            });

            modelBuilder.Entity<ProductVat>(entity =>
            {
                entity.ToTable("ProductVATs");

                entity.Property(e => e.ProductVatid).HasColumnName("ProductVATId");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.EffectiveFrom).HasColumnType("datetime");

                entity.Property(e => e.EffectiveTo).HasColumnType("datetime");

                entity.Property(e => e.ProductDefaultVatPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductVattypeId).HasColumnName("ProductVATTypeId");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductVats)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductVATs_Products");

                entity.HasOne(d => d.ProductVattype)
                    .WithMany(p => p.ProductVats)
                    .HasForeignKey(d => d.ProductVattypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductVATs_ProductVATTypes");
            });

            modelBuilder.Entity<ProductVattype>(entity =>
            {
                entity.ToTable("ProductVATTypes");

                entity.Property(e => e.ProductVattypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("ProductVATTypeId");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.DefaultVatPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EffectiveFrom).HasColumnType("datetime");

                entity.Property(e => e.EffectiveTo).HasColumnType("datetime");

                entity.Property(e => e.ExportNote).HasMaxLength(50);

                entity.Property(e => e.ExportNoteInBn).HasMaxLength(50);

                entity.Property(e => e.ImportNote).HasMaxLength(50);

                entity.Property(e => e.ImportNoteInBn).HasMaxLength(50);

                entity.Property(e => e.IsRequireVds).HasColumnName("IsRequireVDS");

                entity.Property(e => e.IsVatapplicable).HasColumnName("IsVATApplicable");

                entity.Property(e => e.LocalPurchaseNote).HasMaxLength(50);

                entity.Property(e => e.LocalPurchaseNoteInBn).HasMaxLength(50);

                entity.Property(e => e.LocalSaleNote).HasMaxLength(50);

                entity.Property(e => e.LocalSaleNoteInBn).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.NameInBangla).HasMaxLength(500);
            });

            modelBuilder.Entity<ProductionReceive>(entity =>
            {
                entity.ToTable("ProductionReceive");

                entity.Property(e => e.BatchNo).HasMaxLength(50);

                entity.Property(e => e.ContractualProductionChallanNo).HasMaxLength(50);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.MaterialCost).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.PriceSetupId).HasDefaultValueSql("((2))");

                entity.Property(e => e.ReceiveQuantity).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.ReceiveTime).HasColumnType("datetime");

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.HasOne(d => d.ContractualProduction)
                    .WithMany(p => p.ProductionReceives)
                    .HasForeignKey(d => d.ContractualProductionId)
                    .HasConstraintName("FK_ProductionReceive_ContractualProduction");

                entity.HasOne(d => d.MeasurementUnit)
                    .WithMany(p => p.ProductionReceives)
                    .HasForeignKey(d => d.MeasurementUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductionReceive_MeasurementUnits");

                entity.HasOne(d => d.OrgBranch)
                    .WithMany(p => p.ProductionReceives)
                    .HasForeignKey(d => d.OrgBranchId)
                    .HasConstraintName("FK_ProductionReceive_OrgBranch");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.ProductionReceives)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductionReceive_Organizations");

                entity.HasOne(d => d.PriceSetup)
                    .WithMany(p => p.ProductionReceives)
                    .HasForeignKey(d => d.PriceSetupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductionReceive_PriceSetup");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductionReceives)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductionReceive_Products");
            });

            modelBuilder.Entity<Purchase>(entity =>
            {
                entity.ToTable("Purchase");

                entity.Property(e => e.AdvanceTaxPaidAmount).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.AtpbankBranchName)
                    .HasMaxLength(250)
                    .HasColumnName("ATPBankBranchName");

                entity.Property(e => e.AtpbankId)
                    .HasColumnName("ATPBankId")
                    .HasComment("");

                entity.Property(e => e.AtpchallanNo)
                    .HasMaxLength(20)
                    .HasColumnName("ATPChallanNo");

                entity.Property(e => e.Atpdate)
                    .HasColumnType("datetime")
                    .HasColumnName("ATPDate")
                    .HasComment("");

                entity.Property(e => e.AtpnbrEconomicCodeId)
                    .HasColumnName("ATPNbrEconomicCodeId")
                    .HasComment("");

                entity.Property(e => e.BillOfEntry).HasMaxLength(50);

                entity.Property(e => e.BillOfEntryDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.CustomsAndVatcommissionarateId).HasColumnName("CustomsAndVATCommissionarateId");

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.DiscountOnTotalPrice).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.DueAmount)
                    .HasColumnType("decimal(28, 8)")
                    .HasComputedColumnSql("(CONVERT([decimal](21,2),case when [PurchaseTypeId]=(2) then [TotalPriceWithoutVat]-[DiscountOnTotalPrice] else ((([TotalPriceWithoutVat]+[TotalVAT])+[TotalSupplementaryDuty])-[DiscountOnTotalPrice])-[TotalDiscountOnIndividualProduct] end)-[PaidAmount])", false);

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.ExpectedDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.IsVdsamountPaid).HasColumnName("IsVDSAmountPaid");

                entity.Property(e => e.IsVdscertificatePrinted).HasColumnName("IsVDSCertificatePrinted");

                entity.Property(e => e.LcDate).HasColumnType("datetime");

                entity.Property(e => e.LcNo).HasMaxLength(50);

                entity.Property(e => e.LcaNumber).HasMaxLength(50);

                entity.Property(e => e.LcafNumber).HasMaxLength(50);

                entity.Property(e => e.PaidAmount).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.PayableAmount)
                    .HasColumnType("decimal(21, 2)")
                    .HasComputedColumnSql("(CONVERT([decimal](21,2),case when [PurchaseTypeId]=(2) then [TotalPriceWithoutVat]-[DiscountOnTotalPrice] else ((([TotalPriceWithoutVat]+[TotalVAT])+[TotalSupplementaryDuty])-[DiscountOnTotalPrice])-[TotalDiscountOnIndividualProduct] end))", false);

                entity.Property(e => e.PoNumber).HasMaxLength(50);

                entity.Property(e => e.PurchaseDate).HasColumnType("datetime");

                entity.Property(e => e.PurchaseRemarks).HasMaxLength(500);

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.Property(e => e.TermsOfLc).HasMaxLength(500);

                entity.Property(e => e.TotalAdvanceIncomeTax).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.TotalAdvanceTax).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.TotalCustomDuty).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.TotalDiscountOnIndividualProduct).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.TotalImportDuty).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.TotalPriceWithoutVat).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.TotalRegulatoryDuty).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.TotalSupplementaryDuty).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.TotalVat)
                    .HasColumnType("decimal(26, 8)")
                    .HasColumnName("TotalVAT");

                entity.Property(e => e.VatChallanIssueDate).HasColumnType("datetime");

                entity.Property(e => e.VatChallanNo).HasMaxLength(50);

                entity.Property(e => e.Vdsamount)
                    .HasColumnType("decimal(26, 8)")
                    .HasColumnName("VDSAmount");

                entity.Property(e => e.VdscertificateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("VDSCertificateDate");

                entity.Property(e => e.VdscertificateNo)
                    .HasMaxLength(50)
                    .HasColumnName("VDSCertificateNo");

                entity.Property(e => e.Vdsdate)
                    .HasColumnType("datetime")
                    .HasColumnName("VDSDate");

                entity.Property(e => e.Vdsnote)
                    .HasMaxLength(500)
                    .HasColumnName("VDSNote");

                entity.Property(e => e.VdspaymentBookTransferNo)
                    .HasMaxLength(50)
                    .HasColumnName("VDSPaymentBookTransferNo");

                entity.Property(e => e.VendorInvoiceNo).HasMaxLength(50);

                entity.Property(e => e.VoucherNo).HasMaxLength(50);

                entity.HasOne(d => d.Atpbank)
                    .WithMany(p => p.Purchases)
                    .HasForeignKey(d => d.AtpbankId)
                    .HasConstraintName("FK_Purchase_Bank");

                entity.HasOne(d => d.AtpnbrEconomicCode)
                    .WithMany(p => p.Purchases)
                    .HasForeignKey(d => d.AtpnbrEconomicCodeId)
                    .HasConstraintName("FK_Purchase_NbrEconomicCodeATPNbrEconomicCodeId");

                entity.HasOne(d => d.CustomsAndVatcommissionarate)
                    .WithMany(p => p.Purchases)
                    .HasForeignKey(d => d.CustomsAndVatcommissionarateId)
                    .HasConstraintName("FK_Purchase_CustomsAndVATCommissionarate");

                entity.HasOne(d => d.OrgBranch)
                    .WithMany(p => p.Purchases)
                    .HasForeignKey(d => d.OrgBranchId)
                    .HasConstraintName("FK_Purchase_OrgBranch");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.PurchaseOrganizations)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Purchase_Organizations");

                entity.HasOne(d => d.PurchaseReason)
                    .WithMany(p => p.Purchases)
                    .HasForeignKey(d => d.PurchaseReasonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Purchase_PurchaseReason");

                entity.HasOne(d => d.PurchaseType)
                    .WithMany(p => p.Purchases)
                    .HasForeignKey(d => d.PurchaseTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Purchase_PurchaseTypes");

                entity.HasOne(d => d.TransferBranch)
                    .WithMany(p => p.PurchaseTransferBranches)
                    .HasForeignKey(d => d.TransferBranchId)
                    .HasConstraintName("FK_Purchase_Organizations_TransferBranch");

                entity.HasOne(d => d.TransferSales)
                    .WithMany(p => p.Purchases)
                    .HasForeignKey(d => d.TransferSalesId)
                    .HasConstraintName("FK_Purchase_Sales_Transfer");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.Purchases)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_Purchase_Vendor");
            });

            modelBuilder.Entity<PurchaseDetail>(entity =>
            {
                entity.Property(e => e.AdvanceIncomeTaxPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AdvanceTaxPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.CustomDutyPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DiscountPerItem).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.GoodsId).HasMaxLength(50);

                entity.Property(e => e.Hscode)
                    .HasMaxLength(50)
                    .HasColumnName("HSCode");

                entity.Property(e => e.ImportDutyPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PartNo).HasMaxLength(100);

                entity.Property(e => e.ProductCode).HasMaxLength(50);

                entity.Property(e => e.ProductDescription).HasMaxLength(500);

                entity.Property(e => e.ProductVattypeId).HasColumnName("ProductVATTypeId");

                entity.Property(e => e.Quantity).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.Property(e => e.RegulatoryDutyPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Skuid)
                    .HasMaxLength(50)
                    .HasColumnName("SKUId");

                entity.Property(e => e.Skuno)
                    .HasMaxLength(50)
                    .HasColumnName("SKUNo");

                entity.Property(e => e.SupplementaryDutyPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.Vatpercent)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VATPercent");

                entity.HasOne(d => d.MeasurementUnit)
                    .WithMany(p => p.PurchaseDetails)
                    .HasForeignKey(d => d.MeasurementUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseDetails_MeasurementUnits");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.PurchaseDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseDetails_Products");

                entity.HasOne(d => d.ProductVattype)
                    .WithMany(p => p.PurchaseDetails)
                    .HasForeignKey(d => d.ProductVattypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseDetails_ProductVATTypes");

                entity.HasOne(d => d.Purchase)
                    .WithMany(p => p.PurchaseDetails)
                    .HasForeignKey(d => d.PurchaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseDetails_Purchase");
            });

            modelBuilder.Entity<PurchaseImportTariff>(entity =>
            {
                entity.ToTable("PurchaseImportTariff");

                entity.HasIndex(e => e.HsCode, "IX_PurchaseImportTariff_HsCode");

                entity.Property(e => e.PurchaseImportTariffId).ValueGeneratedNever();

                entity.Property(e => e.AitPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AtPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CdPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EffectiveFrom).HasColumnType("datetime");

                entity.Property(e => e.EffectiveTo).HasColumnType("datetime");

                entity.Property(e => e.HsCode).HasMaxLength(20);

                entity.Property(e => e.IdPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ItemDescription).HasMaxLength(255);

                entity.Property(e => e.RdPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SdPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TtiPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VatPercent).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<PurchaseImportTaxPayment>(entity =>
            {
                entity.ToTable("PurchaseImportTaxPayment");

                entity.Property(e => e.PitpAccCode).HasMaxLength(50);

                entity.Property(e => e.PitpBankBranchName).HasMaxLength(250);

                entity.Property(e => e.PitpDocOrChallanDate).HasColumnType("datetime");

                entity.Property(e => e.PitpDocOrChallanNo).HasMaxLength(50);

                entity.Property(e => e.PitpPaidAmount).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.PitpPaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PitpPaymentRemarks).HasMaxLength(250);

                entity.HasOne(d => d.PitpBankBranchDistrict)
                    .WithMany(p => p.PurchaseImportTaxPayments)
                    .HasForeignKey(d => d.PitpBankBranchDistrictId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseImportTaxPayment_District");

                entity.HasOne(d => d.PitpBank)
                    .WithMany(p => p.PurchaseImportTaxPayments)
                    .HasForeignKey(d => d.PitpBankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseImportTaxPayment_Bank");

                entity.HasOne(d => d.PitpVatCommissionarate)
                    .WithMany(p => p.PurchaseImportTaxPayments)
                    .HasForeignKey(d => d.PitpVatCommissionarateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseImportTaxPayment_CustomsAndVATCommissionarate");

                entity.HasOne(d => d.Purchase)
                    .WithMany(p => p.PurchaseImportTaxPayments)
                    .HasForeignKey(d => d.PurchaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseImportTaxPayment_Purchase");

                entity.HasOne(d => d.PurchaseImportTaxPaymentType)
                    .WithMany(p => p.PurchaseImportTaxPayments)
                    .HasForeignKey(d => d.PurchaseImportTaxPaymentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseImportTaxPayment_PurchaseImportTaxPaymentType");
            });

            modelBuilder.Entity<PurchaseImportTaxPaymentType>(entity =>
            {
                entity.ToTable("PurchaseImportTaxPaymentType");

                entity.Property(e => e.PurchaseImportTaxPaymentTypeId).ValueGeneratedNever();

                entity.Property(e => e.PaymentTypeName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTypeShortName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PurchasePayment>(entity =>
            {
                entity.ToTable("PurchasePayment");

                entity.Property(e => e.BankAccountNo).HasMaxLength(50);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.DocumentNoOrTransId).HasMaxLength(50);

                entity.Property(e => e.DocumentOrTransDate).HasColumnType("datetime");

                entity.Property(e => e.PaidAmount).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentRemarks).HasMaxLength(500);

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.Property(e => e.WalletNo).HasMaxLength(20);

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.PurchasePayments)
                    .HasForeignKey(d => d.BankId)
                    .HasConstraintName("FK_PurchasePayment_Bank");

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.PurchasePayments)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchasePayment_PaymentMethod");

                entity.HasOne(d => d.Purchase)
                    .WithMany(p => p.PurchasePayments)
                    .HasForeignKey(d => d.PurchaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchasePayment_Purchase");
            });

            modelBuilder.Entity<PurchaseReason>(entity =>
            {
                entity.ToTable("PurchaseReason");

                entity.Property(e => e.PurchaseReasonId).ValueGeneratedNever();

                entity.Property(e => e.Reason).HasMaxLength(50);
            });

            modelBuilder.Entity<PurchaseType>(entity =>
            {
                entity.Property(e => e.PurchaseTypeId).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<ReportColPurchaseCalculationBook>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ReportColPurchaseCalculationBook", "reoport_column");

                entity.Property(e => e.ClosingProdQty).HasColumnType("decimal(33, 8)");

                entity.Property(e => e.ClosingTotalPrice).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.InitPriceWithoutVat).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.InitialQty).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.MeasurementUnitName).HasMaxLength(50);

                entity.Property(e => e.OperationTime).HasColumnType("datetime");

                entity.Property(e => e.OperationType).HasMaxLength(100);

                entity.Property(e => e.OperationTypeBn).HasMaxLength(100);

                entity.Property(e => e.OrganizationAddress).HasMaxLength(500);

                entity.Property(e => e.OrganizationBin).HasMaxLength(50);

                entity.Property(e => e.OrganizationBranchAddress).HasMaxLength(500);

                entity.Property(e => e.OrganizationBranchName).HasMaxLength(250);

                entity.Property(e => e.OrganizationName).HasMaxLength(250);

                entity.Property(e => e.PriceWithoutVat).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PriceWithoutVatForUsedInProduction).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.ProductDescription).HasMaxLength(250);

                entity.Property(e => e.ProductName).HasMaxLength(200);

                entity.Property(e => e.PurchaseDate).HasColumnType("datetime");

                entity.Property(e => e.PurchaseQty).HasColumnType("decimal(28, 8)");

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.SupplimentaryDuty).HasColumnType("decimal(20, 2)");

                entity.Property(e => e.TotalProdPrice).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.TotalProdQty).HasColumnType("decimal(29, 8)");

                entity.Property(e => e.TransactionNote).HasMaxLength(200);

                entity.Property(e => e.UsedInProductionQty).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.VatChallanOrBillOfEntry).HasMaxLength(50);

                entity.Property(e => e.VatChallanOrBillOfEntryDate).HasColumnType("datetime");

                entity.Property(e => e.Vatamount)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("VATAmount");

                entity.Property(e => e.VendorAddress).HasMaxLength(500);

                entity.Property(e => e.VendorBinOrNid).HasMaxLength(50);

                entity.Property(e => e.VendorInvoiceNo).HasMaxLength(50);

                entity.Property(e => e.VendorName).HasMaxLength(200);
            });

            modelBuilder.Entity<ReportColPurchaseReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ReportColPurchaseReport", "reoport_column");

                entity.Property(e => e.BillOfEntry).HasMaxLength(50);

                entity.Property(e => e.BillOfEntryDate).HasColumnType("datetime");

                entity.Property(e => e.BranchAddress).HasMaxLength(200);

                entity.Property(e => e.BranchName).HasMaxLength(250);

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.DiscountOnTotalPrice).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.DueAmount).HasColumnType("decimal(28, 8)");

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.IsTdsStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IsVdsCertificatePrintedStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IsVdsStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.LcDate).HasColumnType("datetime");

                entity.Property(e => e.LcNo).HasMaxLength(50);

                entity.Property(e => e.LcaNumber).HasMaxLength(50);

                entity.Property(e => e.LcafNumber).HasMaxLength(50);

                entity.Property(e => e.OrganizationAddress).HasMaxLength(200);

                entity.Property(e => e.OrganizationBin).HasMaxLength(50);

                entity.Property(e => e.OrganizationName).HasMaxLength(250);

                entity.Property(e => e.PaidAmount).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.PayableAmount).HasColumnType("decimal(21, 2)");

                entity.Property(e => e.PoNumber).HasMaxLength(50);

                entity.Property(e => e.PurchaseDate).HasColumnType("datetime");

                entity.Property(e => e.PurchaseReasonName).HasMaxLength(50);

                entity.Property(e => e.PurchaseRemarks).HasMaxLength(500);

                entity.Property(e => e.PurchaseTypeName).HasMaxLength(50);

                entity.Property(e => e.ReceiveAddress).HasMaxLength(200);

                entity.Property(e => e.SlNo).ValueGeneratedOnAdd();

                entity.Property(e => e.TdsAmount).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.TotalAdvanceIncomeTax).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.TotalAdvanceTax).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.TotalCustomDuty).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.TotalDiscountOnIndividualProduct).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.TotalImportDuty).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.TotalPriceWithoutVat).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.TotalRegulatoryDuty).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.TotalSupplementaryDuty).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.TotalVat).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.VatChallanIssueDate).HasColumnType("datetime");

                entity.Property(e => e.VatChallanNo).HasMaxLength(50);

                entity.Property(e => e.VdsAmount).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.VdsCertificateDate).HasColumnType("datetime");

                entity.Property(e => e.VdsCertificateNo).HasMaxLength(50);

                entity.Property(e => e.VdsDate).HasColumnType("datetime");

                entity.Property(e => e.VdsNote).HasMaxLength(500);

                entity.Property(e => e.VdsPaymentBookTransferNo).HasMaxLength(50);

                entity.Property(e => e.VendorAddress).HasMaxLength(500);

                entity.Property(e => e.VendorBinOrNid).HasMaxLength(50);

                entity.Property(e => e.VendorInvoiceNo).HasMaxLength(50);

                entity.Property(e => e.VendorName).HasMaxLength(200);

                entity.Property(e => e.VoucherNo).HasMaxLength(50);
            });

            modelBuilder.Entity<ReportColPurchaseSummeryReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ReportColPurchaseSummeryReport", "reoport_column");

                entity.Property(e => e.BranchAddress).HasMaxLength(200);

                entity.Property(e => e.BranchName).HasMaxLength(250);

                entity.Property(e => e.DiscountOnTotalPrice).HasColumnType("decimal(38, 8)");

                entity.Property(e => e.DueAmount).HasColumnType("decimal(38, 8)");

                entity.Property(e => e.OrganizationAddress).HasMaxLength(200);

                entity.Property(e => e.OrganizationBin).HasMaxLength(50);

                entity.Property(e => e.OrganizationName).HasMaxLength(250);

                entity.Property(e => e.PaidAmount).HasColumnType("decimal(38, 8)");

                entity.Property(e => e.PayableAmount).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.PurchaseTypeName).HasMaxLength(50);

                entity.Property(e => e.ReceiveAddress).HasMaxLength(200);

                entity.Property(e => e.TdsAmount).HasColumnType("decimal(38, 8)");

                entity.Property(e => e.TotalAdvanceIncomeTax).HasColumnType("decimal(38, 8)");

                entity.Property(e => e.TotalAdvanceTax).HasColumnType("decimal(38, 8)");

                entity.Property(e => e.TotalCustomDuty).HasColumnType("decimal(38, 8)");

                entity.Property(e => e.TotalDiscountOnIndividualProduct).HasColumnType("decimal(38, 8)");

                entity.Property(e => e.TotalImportDuty).HasColumnType("decimal(38, 8)");

                entity.Property(e => e.TotalPriceWithoutVat).HasColumnType("decimal(38, 8)");

                entity.Property(e => e.TotalRegulatoryDuty).HasColumnType("decimal(38, 8)");

                entity.Property(e => e.TotalSupplementaryDuty).HasColumnType("decimal(38, 8)");

                entity.Property(e => e.TotalVat).HasColumnType("decimal(38, 8)");

                entity.Property(e => e.VdsAmount).HasColumnType("decimal(38, 8)");

                entity.Property(e => e.VendorAddress).HasMaxLength(500);

                entity.Property(e => e.VendorBinOrNid).HasMaxLength(50);

                entity.Property(e => e.VendorName).HasMaxLength(200);
            });

            modelBuilder.Entity<ReportColSalesReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ReportColSalesReport", "reoport_column");

                entity.Property(e => e.BranchAddress).HasMaxLength(200);

                entity.Property(e => e.BranchName).HasMaxLength(250);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerAddress).HasMaxLength(500);

                entity.Property(e => e.CustomerBinOrNid).HasMaxLength(50);

                entity.Property(e => e.CustomerName).HasMaxLength(200);

                entity.Property(e => e.DiscountOnTotalPrice).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.IsTdsStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IsVdsStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OrganizationAddress).HasMaxLength(200);

                entity.Property(e => e.OrganizationBin).HasMaxLength(50);

                entity.Property(e => e.OrganizationName).HasMaxLength(250);

                entity.Property(e => e.PaymentDueAmount).HasColumnType("decimal(21, 2)");

                entity.Property(e => e.PaymentReceiveAmount).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.ReceivableAmount).HasColumnType("decimal(21, 2)");

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.SalesDate).HasColumnType("datetime");

                entity.Property(e => e.SalesRemarks).HasMaxLength(500);

                entity.Property(e => e.ShippingAddress).HasMaxLength(200);

                entity.Property(e => e.TdsAmount).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.TotalDiscountOnIndividualProduct).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.TotalPriceWithoutVat).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.TotalSupplimentaryDuty).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.TotalVat).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.VatChallanNo).HasMaxLength(50);

                entity.Property(e => e.VatChallanPrintedTime).HasColumnType("datetime");

                entity.Property(e => e.VdsAmount).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.VdsDate).HasColumnType("datetime");

                entity.Property(e => e.VehicleDriverContactNo).HasMaxLength(50);

                entity.Property(e => e.VehicleDriverName).HasMaxLength(100);

                entity.Property(e => e.VehicleName).HasMaxLength(100);

                entity.Property(e => e.VehicleRegNo).HasMaxLength(50);

                entity.Property(e => e.VehicleTypeName).HasMaxLength(100);
            });

            modelBuilder.Entity<ReportColSalesSummeryReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ReportColSalesSummeryReport", "reoport_column");

                entity.Property(e => e.BranchAddress).HasMaxLength(200);

                entity.Property(e => e.BranchName).HasMaxLength(250);

                entity.Property(e => e.CustomerAddress).HasMaxLength(500);

                entity.Property(e => e.CustomerBinOrNid).HasMaxLength(50);

                entity.Property(e => e.CustomerName).HasMaxLength(200);

                entity.Property(e => e.DiscountOnTotalPrice).HasColumnType("decimal(38, 8)");

                entity.Property(e => e.OrganizationAddress).HasMaxLength(200);

                entity.Property(e => e.OrganizationBin).HasMaxLength(50);

                entity.Property(e => e.OrganizationName).HasMaxLength(250);

                entity.Property(e => e.PaymentDueAmount).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.PaymentReceiveAmount).HasColumnType("decimal(38, 8)");

                entity.Property(e => e.ReceivableAmount).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.ShippingAddress).HasMaxLength(200);

                entity.Property(e => e.TdsAmount).HasColumnType("decimal(38, 8)");

                entity.Property(e => e.TotalDiscountOnIndividualProduct).HasColumnType("decimal(38, 8)");

                entity.Property(e => e.TotalPriceWithoutVat).HasColumnType("decimal(38, 8)");

                entity.Property(e => e.TotalSupplimentaryDuty).HasColumnType("decimal(38, 8)");

                entity.Property(e => e.TotalVat).HasColumnType("decimal(38, 8)");

                entity.Property(e => e.VdsAmount).HasColumnType("decimal(38, 8)");
            });

            modelBuilder.Entity<Right>(entity =>
            {
                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(128);

                entity.Property(e => e.RightCategoryId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RightName).HasMaxLength(64);

                entity.HasOne(d => d.RightCategory)
                    .WithMany(p => p.Rights)
                    .HasForeignKey(d => d.RightCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rights_RightCategory");
            });

            modelBuilder.Entity<RightCategory>(entity =>
            {
                entity.ToTable("RightCategory");

                entity.Property(e => e.RightCategoryId).ValueGeneratedNever();

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.RightCategoryName).HasMaxLength(100);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.RoleName).HasMaxLength(64);

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.Roles)
                    .HasForeignKey(d => d.OrganizationId)
                    .HasConstraintName("FK_Roles_Organizations");
            });

            modelBuilder.Entity<RoleRight>(entity =>
            {
                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.HasOne(d => d.Right)
                    .WithMany(p => p.RoleRights)
                    .HasForeignKey(d => d.RightId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RoleRights_Rights");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleRights)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo_RoleFeatures_dbo_Roles_RoleId");
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.HasKey(e => e.SalesId);

                entity.Property(e => e.BillOfEntry).HasMaxLength(50);

                entity.Property(e => e.BillOfEntryDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerPoNumber).HasMaxLength(50);

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.DiscountOnTotalPrice).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.ExpectedDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.IsVdscertificateReceived).HasColumnName("IsVDSCertificateReceived");

                entity.Property(e => e.LcDate).HasColumnType("datetime");

                entity.Property(e => e.LcNo).HasMaxLength(50);

                entity.Property(e => e.PaymentDueAmount)
                    .HasColumnType("decimal(21, 2)")
                    .HasComputedColumnSql("(CONVERT([decimal](21,2),((((([TotalPriceWithoutVat]+[TotalVAT])+[TotalSupplimentaryDuty])-[VDSAmount])-[DiscountOnTotalPrice])-[TotalDiscountOnIndividualProduct])-[PaymentReceiveAmount]))", false);

                entity.Property(e => e.PaymentReceiveAmount).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.ReceivableAmount)
                    .HasColumnType("decimal(21, 2)")
                    .HasComputedColumnSql("(CONVERT([decimal](21,2),(((([TotalPriceWithoutVat]+[TotalVAT])+[TotalSupplimentaryDuty])-[VDSAmount])-[DiscountOnTotalPrice])-[TotalDiscountOnIndividualProduct]))", false);

                entity.Property(e => e.ReceiverContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverName).HasMaxLength(200);

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.Property(e => e.SalesDate).HasColumnType("datetime");

                entity.Property(e => e.SalesDeliveryTypeId).HasDefaultValueSql("((1))");

                entity.Property(e => e.SalesRemarks).HasMaxLength(500);

                entity.Property(e => e.ShippingAddress).HasMaxLength(200);

                entity.Property(e => e.TaxInvoicePrintedTime).HasColumnType("datetime");

                entity.Property(e => e.TermsOfLc).HasMaxLength(500);

                entity.Property(e => e.TotalDiscountOnIndividualProduct).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.TotalPriceWithoutVat).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.TotalSupplimentaryDuty).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.TotalVat)
                    .HasColumnType("decimal(26, 8)")
                    .HasColumnName("TotalVAT");

                entity.Property(e => e.TransferChallanNo).HasMaxLength(50);

                entity.Property(e => e.TransferChallanPrintedTime).HasColumnType("datetime");

                entity.Property(e => e.VatChallanNo).HasMaxLength(50);

                entity.Property(e => e.Vdsamount)
                    .HasColumnType("decimal(26, 8)")
                    .HasColumnName("VDSAmount");

                entity.Property(e => e.VdscertificateIssueTime)
                    .HasColumnType("datetime")
                    .HasColumnName("VDSCertificateIssueTime");

                entity.Property(e => e.VdscertificateNo)
                    .HasMaxLength(50)
                    .HasColumnName("VDSCertificateNo");

                entity.Property(e => e.Vdsdate)
                    .HasColumnType("datetime")
                    .HasColumnName("VDSDate");

                entity.Property(e => e.Vdsnote)
                    .HasMaxLength(500)
                    .HasColumnName("VDSNote");

                entity.Property(e => e.VdspaymentBankBranchName)
                    .HasMaxLength(100)
                    .HasColumnName("VDSPaymentBankBranchName");

                entity.Property(e => e.VdspaymentBankId).HasColumnName("VDSPaymentBankId");

                entity.Property(e => e.VdspaymentBookTransferNo)
                    .HasMaxLength(50)
                    .HasColumnName("VDSPaymentBookTransferNo");

                entity.Property(e => e.VdspaymentChallanNo)
                    .HasMaxLength(20)
                    .HasColumnName("VDSPaymentChallanNo");

                entity.Property(e => e.VdspaymentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("VDSPaymentDate");

                entity.Property(e => e.VdspaymentEconomicCode)
                    .HasMaxLength(20)
                    .HasColumnName("VDSPaymentEconomicCode");

                entity.Property(e => e.VehicleDriverContactNo).HasMaxLength(50);

                entity.Property(e => e.VehicleDriverName).HasMaxLength(100);

                entity.Property(e => e.VehicleName).HasMaxLength(100);

                entity.Property(e => e.VehicleRegNo).HasMaxLength(50);

                entity.Property(e => e.WorkOrderNo).HasMaxLength(50);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Sales_Customer");

                entity.HasOne(d => d.DeliveryMethod)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.DeliveryMethodId)
                    .HasConstraintName("FK_Sales_DeliveryMethod");

                entity.HasOne(d => d.ExportType)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.ExportTypeId)
                    .HasConstraintName("FK_Sales_ExportType");

                entity.HasOne(d => d.OrgBranch)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.OrgBranchId)
                    .HasConstraintName("FK_Sales_OrgBranch");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.SaleOrganizations)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sales_Organizations");

                entity.HasOne(d => d.OtherBranchOrganization)
                    .WithMany(p => p.SaleOtherBranchOrganizations)
                    .HasForeignKey(d => d.OtherBranchOrganizationId)
                    .HasConstraintName("FK_Sales_OtherBranchOrganization");

                entity.HasOne(d => d.SalesDeliveryType)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.SalesDeliveryTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sales_SalesDeliveryType");

                entity.HasOne(d => d.SalesType)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.SalesTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sales_SalesType");

                entity.HasOne(d => d.VdspaymentBank)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.VdspaymentBankId)
                    .HasConstraintName("FK_Sales_Bank");

                entity.HasOne(d => d.VehicleType)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.VehicleTypeId)
                    .HasConstraintName("FK_Sales_VehicleType");
            });

            modelBuilder.Entity<SaleView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SaleView");

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.ExpectedDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.OrganizationName).HasMaxLength(250);

                entity.Property(e => e.SalesDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SalesDeliveryType>(entity =>
            {
                entity.ToTable("SalesDeliveryType");

                entity.Property(e => e.SalesDeliveryTypeId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<SalesDetail>(entity =>
            {
                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.DiscountPerItem).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.GoodsId).HasMaxLength(50);

                entity.Property(e => e.Hscode)
                    .HasMaxLength(50)
                    .HasColumnName("HSCode");

                entity.Property(e => e.PartNo).HasMaxLength(100);

                entity.Property(e => e.ProductCode).HasMaxLength(50);

                entity.Property(e => e.ProductDescription).HasMaxLength(500);

                entity.Property(e => e.ProductVattypeId).HasColumnName("ProductVATTypeId");

                entity.Property(e => e.Quantity).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.Property(e => e.ServiceChargePercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Skuid)
                    .HasMaxLength(50)
                    .HasColumnName("SKUId");

                entity.Property(e => e.Skuno)
                    .HasMaxLength(50)
                    .HasColumnName("SKUNo");

                entity.Property(e => e.SupplementaryDutyPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.Vatpercent)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VATPercent");

                entity.HasOne(d => d.MeasurementUnit)
                    .WithMany(p => p.SalesDetails)
                    .HasForeignKey(d => d.MeasurementUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesDetails_MeasurementUnits");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.SalesDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesDetails_Products");

                entity.HasOne(d => d.ProductTransactionBook)
                    .WithMany(p => p.SalesDetails)
                    .HasForeignKey(d => d.ProductTransactionBookId)
                    .HasConstraintName("FK_SalesDetails_ProductTransactionBook");

                entity.HasOne(d => d.ProductVattype)
                    .WithMany(p => p.SalesDetails)
                    .HasForeignKey(d => d.ProductVattypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesDetails_ProductVATTypes");

                entity.HasOne(d => d.Sales)
                    .WithMany(p => p.SalesDetails)
                    .HasForeignKey(d => d.SalesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesDetails_Sales");
            });

            modelBuilder.Entity<SalesPaymentReceive>(entity =>
            {
                entity.ToTable("SalesPaymentReceive");

                entity.Property(e => e.BankAccountNo).HasMaxLength(50);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.DocumentNoOrTransId).HasMaxLength(50);

                entity.Property(e => e.DocumentOrTransDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentRemarks).HasMaxLength(500);

                entity.Property(e => e.ReceiveAmount).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.ReceiveDate).HasColumnType("datetime");

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.Property(e => e.WalletNo).HasMaxLength(20);

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.SalesPaymentReceives)
                    .HasForeignKey(d => d.BankId)
                    .HasConstraintName("FK_SalesPaymentReceive_Bank");

                entity.HasOne(d => d.ReceivedPaymentMethod)
                    .WithMany(p => p.SalesPaymentReceives)
                    .HasForeignKey(d => d.ReceivedPaymentMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesPaymentReceive_PaymentMethod");

                entity.HasOne(d => d.Sales)
                    .WithMany(p => p.SalesPaymentReceives)
                    .HasForeignKey(d => d.SalesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesPaymentReceive_Sales");
            });

            modelBuilder.Entity<SalesPriceAdjustment>(entity =>
            {
                entity.ToTable("SalesPriceAdjustment");

                entity.Property(e => e.AdjustmentRemarks).HasMaxLength(1000);

                entity.Property(e => e.ClientNoteNo).HasMaxLength(50);

                entity.Property(e => e.ClientNoteTime).HasColumnType("datetime");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.NoteNo).HasMaxLength(50);

                entity.Property(e => e.NotePrintedTime).HasColumnType("datetime");

                entity.Property(e => e.ReasonOfChange).HasMaxLength(500);

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.Property(e => e.VehicleDriverContactNo).HasMaxLength(50);

                entity.Property(e => e.VehicleDriverName).HasMaxLength(100);

                entity.Property(e => e.VehicleName).HasMaxLength(100);

                entity.Property(e => e.VehicleRegNo).HasMaxLength(50);

                entity.HasOne(d => d.AdjustmentType)
                    .WithMany(p => p.SalesPriceAdjustments)
                    .HasForeignKey(d => d.AdjustmentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesPriceAdjustment_AdjustmentType");

                entity.HasOne(d => d.OrgBranch)
                    .WithMany(p => p.SalesPriceAdjustments)
                    .HasForeignKey(d => d.OrgBranchId)
                    .HasConstraintName("FK_SalesPriceAdjustment_OrgBranch");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.SalesPriceAdjustments)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesPriceAdjustment_Organizations");

                entity.HasOne(d => d.Sales)
                    .WithMany(p => p.SalesPriceAdjustments)
                    .HasForeignKey(d => d.SalesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesPriceAdjustment_Sales");
            });

            modelBuilder.Entity<SalesPriceAdjustmentDetail>(entity =>
            {
                entity.ToTable("SalesPriceAdjustmentDetail");

                entity.Property(e => e.ChangeAmountPerItem).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.QuantityToChange).HasColumnType("decimal(26, 8)");

                entity.Property(e => e.ReasonOfChange).HasMaxLength(500);

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.HasOne(d => d.MeasurementUnit)
                    .WithMany(p => p.SalesPriceAdjustmentDetails)
                    .HasForeignKey(d => d.MeasurementUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesPriceAdjustmentDetail_MeasurementUnits");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.SalesPriceAdjustmentDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesPriceAdjustmentDetail_Products");

                entity.HasOne(d => d.SalesDetail)
                    .WithMany(p => p.SalesPriceAdjustmentDetails)
                    .HasForeignKey(d => d.SalesDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesPriceAdjustmentDetail_SalesDetails");

                entity.HasOne(d => d.SalesPriceAdjustment)
                    .WithMany(p => p.SalesPriceAdjustmentDetails)
                    .HasForeignKey(d => d.SalesPriceAdjustmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesPriceAdjustmentDetail_SalesPriceAdjustment");
            });

            modelBuilder.Entity<SalesType>(entity =>
            {
                entity.ToTable("SalesType");

                entity.Property(e => e.SalesTypeId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.SalesTypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<SupplimentaryDuty>(entity =>
            {
                entity.ToTable("SupplimentaryDuty");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.EffectiveFrom).HasColumnType("datetime");

                entity.Property(e => e.EffectiveTo).HasColumnType("datetime");

                entity.Property(e => e.SdPercent).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.SupplimentaryDuties)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupplimentaryDuty_Organizations");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.SupplimentaryDuties)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupplimentaryDuty_Products");
            });

            modelBuilder.Entity<TransectionType>(entity =>
            {
                entity.Property(e => e.TransectionTypeId).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.NameInBangla).HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.UserName, "UK_Users_UserName")
                    .IsUnique();

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Designation).HasMaxLength(50);

                entity.Property(e => e.EmailAddress).HasMaxLength(100);

                entity.Property(e => e.EmployeeId).HasMaxLength(50);

                entity.Property(e => e.EmployeePin).HasMaxLength(50);

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.FullName).HasMaxLength(200);

                entity.Property(e => e.InActivationReason).HasMaxLength(200);

                entity.Property(e => e.InActivationTime).HasColumnType("datetime");

                entity.Property(e => e.LastLockReason).HasMaxLength(500);

                entity.Property(e => e.LastLockTime).HasColumnType("datetime");

                entity.Property(e => e.LastLoginTime).HasColumnType("datetime");

                entity.Property(e => e.LastUnlockTime).HasColumnType("datetime");

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.NidNo).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(200);

                entity.Property(e => e.TinNo).HasMaxLength(50);

                entity.Property(e => e.UserImageUrl).HasMaxLength(500);

                entity.Property(e => e.UserName).HasMaxLength(64);

                entity.Property(e => e.UserSignUrl).HasMaxLength(500);

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.OrganizationId)
                    .HasConstraintName("FK_Users_Organizations");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo_UserProfiles_dbo_Roles_RoleId");

                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UserTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_UserTypes");
            });

            modelBuilder.Entity<UserLoginHistory>(entity =>
            {
                entity.ToTable("UserLoginHistory");

                entity.Property(e => e.LoginTime).HasColumnType("datetime");

                entity.Property(e => e.ReasonOfFail).HasMaxLength(200);

                entity.Property(e => e.UserClientDetailInformation).HasMaxLength(2000);

                entity.Property(e => e.UserCookie).HasMaxLength(2000);

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.UserLoginHistories)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserLoginHistory_Organizations");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserLoginHistories)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserLoginHistory_Users");
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.Property(e => e.UserTypeId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.UserTypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<VehicleType>(entity =>
            {
                entity.ToTable("VehicleType");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.Property(e => e.VehicleTypeName).HasMaxLength(100);

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.VehicleTypes)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VehicleType_Organizations");
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.ToTable("Vendor");

                entity.Property(e => e.AccountCode).HasMaxLength(100);

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.BankAccountNo).HasMaxLength(50);

                entity.Property(e => e.BankBranchAddress).HasMaxLength(200);

                entity.Property(e => e.BankBranchName).HasMaxLength(100);

                entity.Property(e => e.BankRoutingCode).HasMaxLength(50);

                entity.Property(e => e.BinNo).HasMaxLength(50);

                entity.Property(e => e.BusinessCategoryDescription).HasMaxLength(500);

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPerson).HasMaxLength(100);

                entity.Property(e => e.ContactPersonDesignation).HasMaxLength(100);

                entity.Property(e => e.ContactPersonEmailAddress).HasMaxLength(100);

                entity.Property(e => e.ContactPersonMobile).HasMaxLength(20);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.CustomsAndVatcommissionarateId).HasColumnName("CustomsAndVATCommissionarateId");

                entity.Property(e => e.EmailAddress).HasMaxLength(100);

                entity.Property(e => e.IsTds).HasColumnName("IsTDS");

                entity.Property(e => e.IsVds).HasColumnName("IsVDS");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.NationalIdNo).HasMaxLength(50);

                entity.Property(e => e.PostCode).HasMaxLength(20);

                entity.Property(e => e.ReferenceKey).HasMaxLength(100);

                entity.Property(e => e.RegistrationNumberUnderActNinetyFour).HasMaxLength(50);

                entity.Property(e => e.ServiceVatCode).HasMaxLength(50);

                entity.Property(e => e.Tdsrate)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("TDSRate");

                entity.Property(e => e.Tinno)
                    .HasMaxLength(50)
                    .HasColumnName("TINNo");

                entity.Property(e => e.Vdsrate)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("VDSRate");

                entity.HasOne(d => d.BankBranchCountry)
                    .WithMany(p => p.VendorBankBranchCountries)
                    .HasForeignKey(d => d.BankBranchCountryId)
                    .HasConstraintName("FK_Vendor_Country_BankBranch");

                entity.HasOne(d => d.BankBranchDistrictOrCity)
                    .WithMany(p => p.VendorBankBranchDistrictOrCities)
                    .HasForeignKey(d => d.BankBranchDistrictOrCityId)
                    .HasConstraintName("FK_Vendor_DistrictOrCity_BankBranch");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.Vendors)
                    .HasForeignKey(d => d.BankId)
                    .HasConstraintName("FK_Vendor_Bank");

                entity.HasOne(d => d.BusinessCategory)
                    .WithMany(p => p.Vendors)
                    .HasForeignKey(d => d.BusinessCategoryId)
                    .HasConstraintName("FK_Vendor_BusinessCategory");

                entity.HasOne(d => d.BusinessNature)
                    .WithMany(p => p.Vendors)
                    .HasForeignKey(d => d.BusinessNatureId)
                    .HasConstraintName("FK_Vendor_BusinessNature");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.VendorCountries)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Vendor_Country");

                entity.HasOne(d => d.CustomsAndVatcommissionarate)
                    .WithMany(p => p.Vendors)
                    .HasForeignKey(d => d.CustomsAndVatcommissionarateId)
                    .HasConstraintName("FK_Vendor_CustomsAndVATCommissionarate");

                entity.HasOne(d => d.DistrictOrCity)
                    .WithMany(p => p.VendorDistrictOrCities)
                    .HasForeignKey(d => d.DistrictOrCityId)
                    .HasConstraintName("FK_Vendor_DistrictOrCity");

                entity.HasOne(d => d.DivisionOrState)
                    .WithMany(p => p.Vendors)
                    .HasForeignKey(d => d.DivisionOrStateId)
                    .HasConstraintName("FK_Vendor_DivisionOrState");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.Vendors)
                    .HasForeignKey(d => d.OrganizationId)
                    .HasConstraintName("FK_Vendor_Organizations");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
