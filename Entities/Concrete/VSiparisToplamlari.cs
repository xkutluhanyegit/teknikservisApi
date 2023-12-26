using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class VSiparisToplamlari
{
    public double? Toplam { get; set; }

    public double? Toplamx { get; set; }

    public decimal? SiparisKargoFiyati { get; set; }

    public double? SiparisIndirimOrani { get; set; }

    public int SiparisId { get; set; }

    public string? SiparisMail { get; set; }

    public int? SikayetId { get; set; }

    public string? SiparisKargoTipi { get; set; }

    public string? StateColor { get; set; }

    public string? SiparisFaturaAdSoyad { get; set; }

    public string? OdemeTipi { get; set; }

    public DateTime? SiparisTarihi { get; set; }

    public string? TakipUrl { get; set; }

    public string? SiparisKargoTeslimatNo { get; set; }

    public int? MusteriId { get; set; }

    public int? SiparisUserId { get; set; }

    public string? ShipName { get; set; }

    public string? UserName { get; set; }

    public string? FaturaAdsoyad { get; set; }

    public int? ServisId { get; set; }

    public int? AltBayiId { get; set; }

    public string? SiparisTeslimatAdSoyad { get; set; }

    public string? TeslimatIlIlce { get; set; }

    public string? FaturaIlIlce { get; set; }

    public int? SiparisOlusturan { get; set; }

    public int? UserId { get; set; }

    public int? SiparisDurumu { get; set; }

    public string? States { get; set; }
}
