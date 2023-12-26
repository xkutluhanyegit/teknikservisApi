using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class VBayiList
{
    public int UserId { get; set; }

    public bool? Aktif { get; set; }

    public int? UserIsActive { get; set; }

    public string? UserName { get; set; }

    public string? AnaBayi { get; set; }

    public string? FaturaAdSoyad { get; set; }

    public string? UserTel1 { get; set; }

    public string? IlIlce { get; set; }

    public string? CariKodu { get; set; }

    public string? SevkKodu { get; set; }

    public string? IfsCariKodu { get; set; }

    public string? IfsSevkAdresi { get; set; }
}
