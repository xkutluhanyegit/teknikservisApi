using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class PilsanDetailedCustLedgEntry437dbf0e84ff417a965dEd2bb9650972
{
    public byte[] Timestamp { get; set; } = null!;

    public int EntryNo { get; set; }

    public int CustLedgerEntryNo { get; set; }

    public int EntryType { get; set; }

    public DateTime PostingDate { get; set; }

    public int DocumentType { get; set; }

    public string DocumentNo { get; set; } = null!;

    public decimal Amount { get; set; }

    public decimal AmountLcy { get; set; }

    public string CustomerNo { get; set; } = null!;

    public string CurrencyCode { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string SourceCode { get; set; } = null!;

    public int TransactionNo { get; set; }

    public string JournalBatchName { get; set; } = null!;

    public string ReasonCode { get; set; } = null!;

    public decimal DebitAmount { get; set; }

    public decimal CreditAmount { get; set; }

    public decimal DebitAmountLcy { get; set; }

    public decimal CreditAmountLcy { get; set; }

    public DateTime InitialEntryDueDate { get; set; }

    public string InitialEntryGlobalDim1 { get; set; } = null!;

    public string InitialEntryGlobalDim2 { get; set; } = null!;

    public string GenBusPostingGroup { get; set; } = null!;

    public string GenProdPostingGroup { get; set; } = null!;

    public byte UseTax { get; set; }

    public string VatBusPostingGroup { get; set; } = null!;

    public string VatProdPostingGroup { get; set; } = null!;

    public int InitialDocumentType { get; set; }

    public int AppliedCustLedgerEntryNo { get; set; }

    public byte Unapplied { get; set; }

    public int UnappliedByEntryNo { get; set; }

    public decimal RemainingPmtDiscPossible { get; set; }

    public decimal MaxPaymentTolerance { get; set; }

    public string TaxJurisdictionCode { get; set; } = null!;

    public int ApplicationNo { get; set; }

    public byte LedgerEntryAmount { get; set; }

    public int Cancel { get; set; }

    public Guid SystemId { get; set; }

    public DateTime SystemCreatedAt { get; set; }

    public Guid SystemCreatedBy { get; set; }

    public DateTime SystemModifiedAt { get; set; }

    public Guid SystemModifiedBy { get; set; }
}
