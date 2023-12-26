using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class VKullanilanMalzemelerY
{
    public int KulId { get; set; }

    public DateTime? RecordDate { get; set; }

    public int? SikayetId { get; set; }

    public int? LogId { get; set; }

    public int? ProdId { get; set; }

    public int? ProdOptId { get; set; }

    public string? ProdName { get; set; }

    public string? ProdPictureUrl { get; set; }

    public double? ProdFiyat { get; set; }

    public int? ProdAdet { get; set; }

    public string GarantiText { get; set; } = null!;

    public int? KulGarantiIsActive { get; set; }

    public string? ProdBarcodeCode { get; set; }

    public int? UserId { get; set; }

    public string? UserName { get; set; }
}
