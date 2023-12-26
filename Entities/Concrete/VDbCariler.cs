using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class VDbCariler
{
    public int UserId { get; set; }

    public string? UserCariId { get; set; }

    public string? SevkKodu { get; set; }

    public string? UserMail { get; set; }

    public string? UserName { get; set; }

    public string? UserVergiNo { get; set; }

    public string? UserKimlikNo { get; set; }

    public string? UserVergiDairesi { get; set; }

    public string? FaturaAdSoyad { get; set; }

    public string? FaturaTelNo { get; set; }

    public int? FaturaCentId { get; set; }

    public int? FaturaDistrictId { get; set; }

    public string? FaturaContent { get; set; }

    public string? UserCustId { get; set; }

    public int? UserIsActive { get; set; }

    public byte? IsAdmin { get; set; }
}
