using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class Dbiletisim
{
    public int IltId { get; set; }

    public int IltIsActive { get; set; }

    public string? Adsoyad { get; set; }

    public string? Email { get; set; }

    public string? Telefon { get; set; }

    public string? IltKonu { get; set; }

    public string? Mesaj { get; set; }

    public bool? MesajDurum { get; set; }

    public DateTime? Iltdate { get; set; }

    public int? UserId { get; set; }

    public string? UserlogIp { get; set; }

    public string? IltTur { get; set; }

    public string? MesajCevap { get; set; }
}
