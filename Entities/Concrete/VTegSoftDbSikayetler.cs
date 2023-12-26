using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class VTegSoftDbSikayetler
{
    public int SikayetId { get; set; }

    public int? Id { get; set; }

    public string? SikayetMusteriAdi { get; set; }

    public string? SikayetMusteriSoyAdi { get; set; }

    public string? SikayetMusteriSehirId { get; set; }

    public string? SikayetMusteriSehirText { get; set; }

    public string? SikayetMusteriTelNo { get; set; }

    public string? SikayetMusteriCepTelNo { get; set; }
}
