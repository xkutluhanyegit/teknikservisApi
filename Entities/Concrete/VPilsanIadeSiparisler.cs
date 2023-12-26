using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class VPilsanIadeSiparisler
{
    public int Id { get; set; }

    public int? DonemId { get; set; }

    public int? SikayetId { get; set; }

    public string? ProdNo { get; set; }

    public string? Aciklama { get; set; }

    public int? Miktar { get; set; }

    public double? BirimFiyat { get; set; }

    public bool? KulGarantiIsActive { get; set; }

    public int NavAktar { get; set; }

    public string? UserCariId { get; set; }

    public int? DonemUserId { get; set; }
}
