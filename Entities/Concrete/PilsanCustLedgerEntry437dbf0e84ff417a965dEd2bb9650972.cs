using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class PilsanCustLedgerEntry437dbf0e84ff417a965dEd2bb9650972
{
    public byte[] Timestamp { get; set; } = null!;

    public int EntryNo { get; set; }

    public string CustomerNo { get; set; } = null!;

    public DateTime PostingDate { get; set; }

    public int DocumentType { get; set; }

    public string DocumentNo { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string CustomerName { get; set; } = null!;

    public string CurrencyCode { get; set; } = null!;

    public decimal SalesLcy { get; set; }

    public decimal ProfitLcy { get; set; }

    public decimal InvDiscountLcy { get; set; }

    public string SellToCustomerNo { get; set; } = null!;

    public string CustomerPostingGroup { get; set; } = null!;

    public string GlobalDimension1Code { get; set; } = null!;

    public string GlobalDimension2Code { get; set; } = null!;

    public string SalespersonCode { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string SourceCode { get; set; } = null!;

    public string OnHold { get; set; } = null!;

    public int AppliesToDocType { get; set; }

    public string AppliesToDocNo { get; set; } = null!;

    public byte Open { get; set; }

    public DateTime DueDate { get; set; }

    public DateTime PmtDiscountDate { get; set; }

    public decimal OriginalPmtDiscPossible { get; set; }

    public decimal PmtDiscGivenLcy { get; set; }

    public byte Positive { get; set; }

    public int ClosedByEntryNo { get; set; }

    public DateTime ClosedAtDate { get; set; }

    public decimal ClosedByAmount { get; set; }

    public string AppliesToId { get; set; } = null!;

    public string JournalBatchName { get; set; } = null!;

    public string ReasonCode { get; set; } = null!;

    public int BalAccountType { get; set; }

    public string BalAccountNo { get; set; } = null!;

    public int TransactionNo { get; set; }

    public decimal ClosedByAmountLcy { get; set; }

    public DateTime DocumentDate { get; set; }

    public string ExternalDocumentNo { get; set; } = null!;

    public byte CalculateInterest { get; set; }

    public byte ClosingInterestCalculated { get; set; }

    public string NoSeries { get; set; } = null!;

    public string ClosedByCurrencyCode { get; set; } = null!;

    public decimal ClosedByCurrencyAmount { get; set; }

    public decimal AdjustedCurrencyFactor { get; set; }

    public decimal OriginalCurrencyFactor { get; set; }

    public decimal RemainingPmtDiscPossible { get; set; }

    public DateTime PmtDiscToleranceDate { get; set; }

    public decimal MaxPaymentTolerance { get; set; }

    public int LastIssuedReminderLevel { get; set; }

    public decimal AcceptedPaymentTolerance { get; set; }

    public byte AcceptedPmtDiscTolerance { get; set; }

    public decimal PmtToleranceLcy { get; set; }

    public decimal AmountToApply { get; set; }

    public string IcPartnerCode { get; set; } = null!;

    public byte ApplyingEntry { get; set; }

    public byte Reversed { get; set; }

    public int ReversedByEntryNo { get; set; }

    public int ReversedEntryNo { get; set; }

    public byte Prepayment { get; set; }

    public string PaymentReference { get; set; } = null!;

    public string PaymentMethodCode { get; set; } = null!;

    public string AppliesToExtDocNo { get; set; } = null!;

    public string RecipientBankAccount { get; set; } = null!;

    public string MessageToRecipient { get; set; } = null!;

    public byte ExportedToPaymentFile { get; set; }

    public int DimensionSetId { get; set; }

    public string DirectDebitMandateId { get; set; } = null!;

    public int Cancel { get; set; }

    public Guid SystemId { get; set; }

    public DateTime SystemCreatedAt { get; set; }

    public Guid SystemCreatedBy { get; set; }

    public DateTime SystemModifiedAt { get; set; }

    public Guid SystemModifiedBy { get; set; }
}
