using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class VSiparisler
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

    public string? SiparisKargoTeslimatNo { get; set; }

    public int? MusteriId { get; set; }

    public int? SiparisUserId { get; set; }

    public string? ShipName { get; set; }

    public string? UserName { get; set; }

    public string? FaturaAdsoyad { get; set; }

    public int? ServisId { get; set; }

    public int? AltBayiId { get; set; }

    public string? SiparisTeslimatAdSoyad { get; set; }

    public int? OdemeTipi { get; set; }

    public DateTime? SiparisTarihi { get; set; }

    public int? SiparisDurumu { get; set; }

    public int? SiparisFaturaIlce { get; set; }

    public int? SiparisFaturaSehir { get; set; }

    public int? SiparisTeslimatSehir { get; set; }

    public int? SiparisTeslimatIlce { get; set; }
}
