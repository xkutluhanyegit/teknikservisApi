using System;
using System.Collections.Generic;
using Core.Entities;

namespace Entities.Concrete;

public partial class DbMusteriler:IEntity
{
    public int MusteriId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DeletedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? Aktif { get; set; }

    public string? CariKodu { get; set; }

    public string? SevkKodu { get; set; }

    public string? MusteriAdsoyad { get; set; }

    public string? MusteriKimlikno { get; set; }

    public string? MusteriVergidairesi { get; set; }

    public string? MusteriVergino { get; set; }

    public string? MusteriEmail { get; set; }

    public string? MusteriTelefon { get; set; }

    public int? MusteriIl { get; set; }

    public int? MusteriIlce { get; set; }

    public string? MusteriAdres { get; set; }

    public string? FaturaAdsoyad { get; set; }

    public string? FaturaTelefon { get; set; }

    public int? FaturaIl { get; set; }

    public int? FaturaIlce { get; set; }

    public string? FaturaAdres { get; set; }

    public string? TeslimatAdsoyad { get; set; }

    public string? TeslimatTelefon { get; set; }

    public int? TeslimatIl { get; set; }

    public int? TeslimatIlce { get; set; }

    public string? TeslimatAdres { get; set; }

    public string? IfsCariKodu { get; set; }
}
