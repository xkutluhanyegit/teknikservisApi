using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbSikayetlerGrouped
{
    public int Id { get; set; }

    public string? SikayetMusteriAdi { get; set; }

    public string? SikayetMusteriSoyAdi { get; set; }

    public int? SikayetMusteriSehirId { get; set; }

    public string? SikayetMusteriTelNo { get; set; }

    public string? SikayetMusteriCepTelNo { get; set; }
}
