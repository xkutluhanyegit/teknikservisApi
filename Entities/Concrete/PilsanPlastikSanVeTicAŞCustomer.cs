using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class PilsanPlastikSanVeTicAŞCustomer
{
    public DateTime Timestamp { get; set; }

    public string No { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string SearchName { get; set; } = null!;

    public string Name2 { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Address2 { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Contact { get; set; } = null!;

    public string PhoneNo { get; set; } = null!;

    public string TelexNo { get; set; } = null!;

    public string OurAccountNo { get; set; } = null!;

    public string TerritoryCode { get; set; } = null!;

    public string GlobalDimension1Code { get; set; } = null!;

    public string GlobalDimension2Code { get; set; } = null!;

    public string ChainName { get; set; } = null!;

    public decimal BudgetedAmount { get; set; }

    public decimal CreditLimitLcy { get; set; }

    public string CustomerPostingGroup { get; set; } = null!;

    public string CurrencyCode { get; set; } = null!;

    public string CustomerPriceGroup { get; set; } = null!;

    public string LanguageCode { get; set; } = null!;

    public int StatisticsGroup { get; set; }

    public string PaymentTermsCode { get; set; } = null!;

    public string FinChargeTermsCode { get; set; } = null!;

    public string SalespersonCode { get; set; } = null!;

    public string ShipmentMethodCode { get; set; } = null!;

    public string ShippingAgentCode { get; set; } = null!;

    public string PlaceOfExport { get; set; } = null!;

    public string InvoiceDiscCode { get; set; } = null!;

    public string CustomerDiscGroup { get; set; } = null!;

    public string CountryRegionCode { get; set; } = null!;

    public string CollectionMethod { get; set; } = null!;

    public decimal Amount { get; set; }

    public int Blocked { get; set; }

    public int InvoiceCopies { get; set; }

    public int LastStatementNo { get; set; }

    public byte PrintStatements { get; set; }

    public string BillToCustomerNo { get; set; } = null!;

    public int Priority { get; set; }

    public string PaymentMethodCode { get; set; } = null!;

    public DateTime LastDateModified { get; set; }

    public int ApplicationMethod { get; set; }

    public byte PricesIncludingVat { get; set; }

    public string LocationCode { get; set; } = null!;

    public string FaxNo { get; set; } = null!;

    public string TelexAnswerBack { get; set; } = null!;

    public string VatRegistrationNo { get; set; } = null!;

    public byte CombineShipments { get; set; }

    public string GenBusPostingGroup { get; set; } = null!;

    public byte[]? Picture { get; set; }

    public string PostCode { get; set; } = null!;

    public string County { get; set; } = null!;

    public string EMail { get; set; } = null!;

    public string HomePage { get; set; } = null!;

    public string ReminderTermsCode { get; set; } = null!;

    public string NoSeries { get; set; } = null!;

    public string TaxAreaCode { get; set; } = null!;

    public byte TaxLiable { get; set; }

    public string VatBusPostingGroup { get; set; } = null!;

    public int Reserve { get; set; }

    public byte BlockPaymentTolerance { get; set; }

    public string IcPartnerCode { get; set; } = null!;

    public decimal Prepayment { get; set; }

    public string PrimaryContactNo { get; set; } = null!;

    public string ResponsibilityCenter { get; set; } = null!;

    public int ShippingAdvice { get; set; }

    public string ShippingTime { get; set; } = null!;

    public string ShippingAgentServiceCode { get; set; } = null!;

    public string ServiceZoneCode { get; set; } = null!;

    public byte AllowLineDisc { get; set; }

    public string BaseCalendarCode { get; set; } = null!;

    public int CopySellToAddrToQteFrom { get; set; }

    public string PersonalIdentityNo { get; set; } = null!;

    public decimal ChequeRiskLimit { get; set; }

    public decimal PromNoteLimit { get; set; }

    public string TaxRegistrationNo { get; set; } = null!;

    public string VendorNo { get; set; } = null!;

    public int ExchNoteRiskControl { get; set; }

    public byte IncludeInErcInv { get; set; }

    public decimal Discount1 { get; set; }

    public decimal Discount2 { get; set; }

    public decimal Discount3 { get; set; }

    public decimal ServiceDiscountPerct { get; set; }

    public int InvoicingType { get; set; }

    public byte[]? BarcodeTemplate { get; set; }

    public string SegmentCode { get; set; } = null!;

    public byte SendShipmentViaMail { get; set; }

    public byte NewItem { get; set; }

    public DateTime AvgChequeDueDate { get; set; }

    public decimal TurnoverIncentive { get; set; }

    public int TypeOfCustomer { get; set; }

    public string EInvoiceTemplateId { get; set; } = null!;

    public int TypeOfMethod { get; set; }

    public string GibRegisteredTaxNo { get; set; } = null!;

    public string VendorNumber { get; set; } = null!;

    public string StoreCode { get; set; } = null!;

    public byte EInvoiceBarcodePrint { get; set; }

    public byte BankruptCompany { get; set; }

    public string EMail2 { get; set; } = null!;

    public byte UsesEArchieve { get; set; }

    public int EArchieveDeliveryMethod { get; set; }
}
