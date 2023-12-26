using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbSikayetTipleri
{
    public int ArizaId { get; set; }

    public string? ArizaKategoriId { get; set; }

    public string? ArizaUrun { get; set; }

    public string? ArizaKodu { get; set; }

    public string? ArizaAdi { get; set; }

    public string? ArizaDescription { get; set; }

    public int? ArizaVideo { get; set; }

    public string? ArizaPdf { get; set; }

    public string? ArizaSss { get; set; }
}
