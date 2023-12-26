using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class VTegSoftContactsToCampaign
{
    public int Id { get; set; }

    public int SikayetId { get; set; }

    public string? SikayetMusteriAdi { get; set; }

    public string? SikayetMusteriSoyAdi { get; set; }

    public int? SikayetMusteriSehirId { get; set; }

    public string? SikayetMusteriTelNo { get; set; }

    public string? SikayetMusteriCepTelNo { get; set; }

    public string? StateName { get; set; }

    public int? StateId { get; set; }

    public DateTime? KapanisTarih { get; set; }

    public string? SikayetMusteriSehirText { get; set; }
}
