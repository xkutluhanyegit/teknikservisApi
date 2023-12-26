using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbKullanilanMalzemeler
{
    public int KulId { get; set; }

    public DateTime? RecordDate { get; set; }

    public int? SikayetId { get; set; }

    public int? LogId { get; set; }

    public int? ProdId { get; set; }

    public int? ProdOptId { get; set; }

    public string? ProdBarcodeCode { get; set; }

    public int? ProdAdet { get; set; }

    public double? ProdFiyat { get; set; }

    public int? KulGarantiIsActive { get; set; }

    public int? UserId { get; set; }

    public string? No { get; set; }
}
