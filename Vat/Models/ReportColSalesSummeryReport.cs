﻿using System;
using System.Collections.Generic;

namespace Vat.Models
{
    public partial class ReportColSalesSummeryReport
    {
        public long? SlNo { get; set; }
        public int OrganizationId { get; set; }
        public string OrganizationName { get; set; } = null!;
        public string? OrganizationBin { get; set; }
        public string OrganizationAddress { get; set; } = null!;
        public int? OrgBranchId { get; set; }
        public string? BranchName { get; set; }
        public string? BranchAddress { get; set; }
        public int? CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerBinOrNid { get; set; }
        public string? CustomerAddress { get; set; }
        public string? ShippingAddress { get; set; }
        public decimal? TotalPriceWithoutVat { get; set; }
        public decimal? DiscountOnTotalPrice { get; set; }
        public decimal? TotalDiscountOnIndividualProduct { get; set; }
        public decimal? TotalVat { get; set; }
        public decimal? TotalSupplimentaryDuty { get; set; }
        public decimal? VdsAmount { get; set; }
        public decimal? TdsAmount { get; set; }
        public decimal? ReceivableAmount { get; set; }
        public decimal? PaymentReceiveAmount { get; set; }
        public decimal? PaymentDueAmount { get; set; }
    }
}
