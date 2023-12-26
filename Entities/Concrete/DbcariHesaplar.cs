using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbcariHesaplar
{
    public int Id { get; set; }

    public string? CariNo { get; set; }

    public DateTime? Tarih { get; set; }

    public string? BelgeTuru { get; set; }

    public string? DokumanNo { get; set; }

    public string? Aciklama { get; set; }

    public double? Borc { get; set; }

    public double? Alacak { get; set; }

    public double? Kalan { get; set; }

    public double? RiskLimit { get; set; }

    public DateTime? EklenmeTarihi { get; set; }

    public bool? TGuncel { get; set; }
}
