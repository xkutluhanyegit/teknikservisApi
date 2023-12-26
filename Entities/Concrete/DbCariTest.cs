using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbCariTest
{
    public int Id { get; set; }

    public double? UserId { get; set; }

    public string? PCariKod { get; set; }

    public double? Aktif { get; set; }

    public string? CariKodu { get; set; }

    public string? SevkKodu { get; set; }

    public double? UserParentId { get; set; }

    public double? UserIsActive { get; set; }

    public string? UserMail { get; set; }

    public string? UserPass { get; set; }

    public string? UserName { get; set; }

    public string? UserLastLoginDate { get; set; }

    public double? UserType { get; set; }

    public string? UserVergiNo { get; set; }

    public string? UserKimlikNo { get; set; }

    public double? UserCentId { get; set; }

    public double? UserDistrictId { get; set; }

    public string? UserVergiDairesi { get; set; }

    public string? UserBirthDate { get; set; }

    public string? FaturaAdSoyad { get; set; }

    public string? FaturaTelNo { get; set; }

    public double? FaturaCentId { get; set; }

    public double? FaturaDistrictId { get; set; }

    public string? FaturaContent { get; set; }

    public string? UserGuid { get; set; }

    public string? UserPriceType { get; set; }

    public string? UserTegSoftConId { get; set; }
}
