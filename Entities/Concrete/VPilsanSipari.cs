using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class VPilsanSipari
{
    public int SiparisId { get; set; }

    public int SalesType { get; set; }

    public int DetailId { get; set; }

    public string CariKodu { get; set; } = null!;

    public string? SevkKodu { get; set; }

    public string? No { get; set; }

    public string? WebUserName { get; set; }

    public int? Miktar { get; set; }

    public int CustId { get; set; }

    public string CustNavNo { get; set; } = null!;

    public string CustShipToCode { get; set; } = null!;

    public string CustName { get; set; } = null!;

    public string CustTcNo { get; set; } = null!;

    public string CustTaxAreaCode { get; set; } = null!;

    public string CustTaxNo { get; set; } = null!;

    public string CustEmail { get; set; } = null!;

    public string? CustPhone { get; set; }

    public string CustCity { get; set; } = null!;

    public string CustCounty { get; set; } = null!;

    public string? CustAddress { get; set; }

    public string? CustAddress2 { get; set; }

    public string? CustBillToName { get; set; }

    public string? CustBillToPhone { get; set; }

    public string CustBillToCity { get; set; } = null!;

    public string CustBillToCounty { get; set; } = null!;

    public string? CustBillToAddress { get; set; }

    public string CustDeliverToName { get; set; } = null!;

    public string? CustDeliverToPhone { get; set; }

    public string CustDeliverToCity { get; set; } = null!;

    public string CustDeliverToCounty { get; set; } = null!;

    public string? CustDeliverToAddress { get; set; }

    public string? CustDeliverToAddress2 { get; set; }
}
