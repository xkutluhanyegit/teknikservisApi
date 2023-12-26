using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbKullaniciTanimlari
{
    public int TanimId { get; set; }

    public string? TanimAdi { get; set; }

    public string? TanimAciklama { get; set; }

    public double? TanimIndirimOrani { get; set; }
}
