using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class VKullanilanMalzemeler
{
    public int KulId { get; set; }

    public int? LogId { get; set; }

    public int? ProdAdet { get; set; }

    public int? KulGarantiIsActive { get; set; }

    public string? ProdPictureUrl { get; set; }

    public string? ProdName { get; set; }

    public string? ProdBarcodeCode { get; set; }

    public double? ProdFiyat { get; set; }

    public double? ToplamFiyat { get; set; }

    public DateTime? RecordDate { get; set; }

    public int? SikayetId { get; set; }

    public int? UserId { get; set; }

    public string? Ekleyen { get; set; }

    public int? ProdId { get; set; }
}
