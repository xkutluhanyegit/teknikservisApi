using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class VDbOrder
{
    public int SiparisId { get; set; }

    public DateTime? SiparisTarihi { get; set; }

    public string? OdemeYontemi { get; set; }

    public string? StateName { get; set; }

    public int? SikayetId { get; set; }

    public string? SiparisKargoTeslimatNo { get; set; }

    public int? SiparisUserId { get; set; }

    public string? StateColor { get; set; }

    public string? ShipName { get; set; }

    public string? SiparisKargoTipi { get; set; }

    public string? TakipUrl { get; set; }

    public int? SiparisDurumu { get; set; }

    public int? SiparisOdemeYontemi { get; set; }

    public string? SiparisPosName { get; set; }

    public string? SiparisBankName { get; set; }

    public string? FaturaAdsoyad { get; set; }

    public int? SiparisOlusturan { get; set; }

    public int? UserId { get; set; }

    public string? TeslimatIlIlce { get; set; }
}
