using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class VwSiparisDurumAktarimi
{
    public int SiparisId { get; set; }

    public DateTime? SiparisTarihi { get; set; }

    public int? SiparisOdemeYontemi { get; set; }

    public string? SiparisGuncellemeTarihi { get; set; }

    public double? SiparisTutar { get; set; }

    public byte[]? RowVersion { get; set; }

    public int? DetailOrderId { get; set; }

    public int? DetailProdId { get; set; }

    public int? DetailProdCount { get; set; }

    public string? DetailProdBarcodeCode { get; set; }

    public decimal? DetailProdPrice { get; set; }

    public double? ProdBirim { get; set; }

    public int? ProdBirimDesc { get; set; }

    public string? LowDesc { get; set; }

    public string? ProdName { get; set; }

    public int DetailId { get; set; }
}
