using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class Sale
    {
        public Sale()
        {
            CreditNotes = new HashSet<CreditNote>();
            Damages = new HashSet<Damage>();
            Purchases = new HashSet<Purchase>();
            SalesDetails = new HashSet<SalesDetail>();
            SalesPaymentReceives = new HashSet<SalesPaymentReceive>();
            SalesPriceAdjustments = new HashSet<SalesPriceAdjustment>();
        }

        public int SalesId { get; set; }
        public string? InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string? VatChallanNo { get; set; }
        public int OrganizationId { get; set; }
        public int? OrgBranchId { get; set; }
        public int SalesSlNo { get; set; }
        public int NoOfIteams { get; set; }
        public decimal TotalPriceWithoutVat { get; set; }
        public decimal DiscountOnTotalPrice { get; set; }
        public decimal TotalDiscountOnIndividualProduct { get; set; }
        public decimal TotalVat { get; set; }
        public decimal TotalSupplimentaryDuty { get; set; }
        public bool IsVatDeductedInSource { get; set; }
        public DateTime? Vdsdate { get; set; }
        public decimal? Vdsamount { get; set; }
        public bool? IsVdscertificateReceived { get; set; }
        public string? VdscertificateNo { get; set; }
        public DateTime? VdscertificateIssueTime { get; set; }
        public int? VdspaymentBankId { get; set; }
        public string? VdspaymentBankBranchName { get; set; }
        public DateTime? VdspaymentDate { get; set; }
        public string? VdspaymentChallanNo { get; set; }
        public string? VdspaymentEconomicCode { get; set; }
        public string? VdspaymentBookTransferNo { get; set; }
        public string? Vdsnote { get; set; }
        public decimal? ReceivableAmount { get; set; }
        public decimal? PaymentReceiveAmount { get; set; }
        public decimal? PaymentDueAmount { get; set; }
        public int? CustomerId { get; set; }
        public string? ReceiverName { get; set; }
        public string? ReceiverContactNo { get; set; }
        public string? ShippingAddress { get; set; }
        public int? ShippingCountryId { get; set; }
        public int SalesTypeId { get; set; }
        public int SalesDeliveryTypeId { get; set; }
        public string? WorkOrderNo { get; set; }
        public DateTime SalesDate { get; set; }
        public DateTime? ExpectedDeliveryDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public int? DeliveryMethodId { get; set; }
        public int? ExportTypeId { get; set; }
        public string? LcNo { get; set; }
        public DateTime? LcDate { get; set; }
        public string? BillOfEntry { get; set; }
        public DateTime? BillOfEntryDate { get; set; }
        public DateTime? DueDate { get; set; }
        public string? TermsOfLc { get; set; }
        public string? CustomerPoNumber { get; set; }
        public bool IsComplete { get; set; }
        public bool IsTaxInvoicePrined { get; set; }
        public DateTime? TaxInvoicePrintedTime { get; set; }
        public int? MushakGenerationId { get; set; }
        public int? OtherBranchOrganizationId { get; set; }
        public string? TransferChallanNo { get; set; }
        public DateTime? TransferChallanPrintedTime { get; set; }
        public string? ReferenceKey { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public long? ApiTransactionId { get; set; }
        public int? VehicleTypeId { get; set; }
        public string? VehicleName { get; set; }
        public string? VehicleRegNo { get; set; }
        public string? VehicleDriverName { get; set; }
        public string? VehicleDriverContactNo { get; set; }
        public string? SalesRemarks { get; set; }
        public long? ExcelDataUploadId { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual DeliveryMethod? DeliveryMethod { get; set; }
        public virtual ExportType? ExportType { get; set; }
        public virtual OrgBranch? OrgBranch { get; set; }
        public virtual Organization Organization { get; set; } = null!;
        public virtual Organization? OtherBranchOrganization { get; set; }
        public virtual SalesDeliveryType SalesDeliveryType { get; set; } = null!;
        public virtual SalesType SalesType { get; set; } = null!;
        public virtual Bank? VdspaymentBank { get; set; }
        public virtual VehicleType? VehicleType { get; set; }
        public virtual ICollection<CreditNote> CreditNotes { get; set; }
        public virtual ICollection<Damage> Damages { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
        public virtual ICollection<SalesDetail> SalesDetails { get; set; }
        public virtual ICollection<SalesPaymentReceive> SalesPaymentReceives { get; set; }
        public virtual ICollection<SalesPriceAdjustment> SalesPriceAdjustments { get; set; }
    }
}
