using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class VwPilsanTegsoft
{
    public int SikayetId { get; set; }

    public string? SikayetMusteriAdi { get; set; }

    public string? SikayetMusteriSoyAdi { get; set; }

    public string? SikayetMusteriTelNo { get; set; }

    public string? SikayetMusteriCepTelNo { get; set; }

    public int? PlsTelefonDegisti { get; set; }

    public int? PlsTelefonGonderildi { get; set; }

    public string? Sehir { get; set; }

    public string? Ilce { get; set; }

    public string? ErrorMessage { get; set; }
}
