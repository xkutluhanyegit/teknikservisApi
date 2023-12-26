using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class VSiparisMusteriler
{
    public string? CariKodu { get; set; }

    public string? SevkKodu { get; set; }

    public string? FaturaAdsoyad { get; set; }

    public string? FaturaTelefon { get; set; }

    public string? FaturaIl { get; set; }

    public string? FaturaIlce { get; set; }

    public string? FaturaAdres { get; set; }

    public string? TeslimatAdsoyad { get; set; }

    public string? TeslimatTelefon { get; set; }

    public string? TeslimatIl { get; set; }

    public string? TeslimatIlce { get; set; }

    public string? TeslimatAdres { get; set; }

    public int MusteriId { get; set; }

    public bool? IsDeleted { get; set; }

    public string? MusteriAdsoyad { get; set; }

    public bool? Aktif { get; set; }
}
