using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbUser
{
    public int UserId { get; set; }

    public string? UserCariId { get; set; }

    public string? SevkKodu { get; set; }

    public int? UserIsActive { get; set; }

    public bool MusTemsilciDurum { get; set; }

    public byte? IsAdmin { get; set; }

    public string? UserSayfalar { get; set; }

    public string? UserMail { get; set; }

    public string? UserPass { get; set; }

    public string? UserName { get; set; }

    public string? UserIp { get; set; }

    public string? UserLastLoginDate { get; set; }

    public int? UserType { get; set; }

    public string? UserVergiNo { get; set; }

    public string? UserKimlikNo { get; set; }

    public int? UserCentId { get; set; }

    public int? UserDistrictId { get; set; }

    public string? UserVergiDairesi { get; set; }

    public DateTime? UserBirthDate { get; set; }

    public string? FaturaAdSoyad { get; set; }

    public string? FaturaTelNo { get; set; }

    public int? FaturaCentId { get; set; }

    public int? FaturaDistrictId { get; set; }

    public string? FaturaContent { get; set; }

    public string? TeslimatAdSoyad { get; set; }

    public string? TeslimatTelNo { get; set; }

    public int? TeslimatCentId { get; set; }

    public int? TeslimatDistrictId { get; set; }

    public string? TeslimatContent { get; set; }

    public string? UserGuid { get; set; }

    public string? UserTel1 { get; set; }

    public string? UserTel2 { get; set; }

    public string? UserTel3 { get; set; }

    public string? UserTbeden { get; set; }

    public string? UserPbeden { get; set; }

    public bool? UserFirstLogin { get; set; }

    public int? UserTalimatIsActive { get; set; }

    public int? UserPriceType { get; set; }

    public string? UserCustId { get; set; }

    public int? UserVideoYetki { get; set; }

    public int? UserIcerikYetki { get; set; }

    public int? BankId { get; set; }

    public string? SubeKodu { get; set; }

    public string? SubeAdi { get; set; }

    public string? HesapNo { get; set; }

    public string? IbanNo { get; set; }

    public bool? BasitUsul { get; set; }

    public bool? MusteriSiparisIzin { get; set; }

    public bool? UserOnline { get; set; }

    public bool? UserSube { get; set; }

    public bool? UserTur { get; set; }

    public bool? Kisitlama { get; set; }

    public string? IfsCariKodu { get; set; }

    public string? IfsSevkAdresi { get; set; }
}
