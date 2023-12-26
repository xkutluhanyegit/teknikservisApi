using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class VSikayetDetay
{
    public int SikayetId { get; set; }

    public int? SikayetServisId { get; set; }

    public int? SikayetKimActiId { get; set; }

    public int? SikayetDurum { get; set; }

    public string? SikayetGarantiIsActive { get; set; }

    public string? SikayetKimeAit { get; set; }

    public int? SikayetBayiId { get; set; }

    public DateTime? SikayetTarih { get; set; }

    public string? AnaBayiAdi { get; set; }

    public string? SikayetMusteriAdi { get; set; }

    public string? SikayetMusteriSoyAdi { get; set; }

    public string? SikayetMusteriAdresi { get; set; }

    public string? MusteriSehir { get; set; }

    public string? MusteriIlce { get; set; }

    public string? SikayetMusteriTelNo { get; set; }

    public string? SikayetMusteriCepTelNo { get; set; }

    public string? SikayetMusteriMail { get; set; }

    public int? SikayetAltBayiId { get; set; }

    public string? AltBayiAdi { get; set; }

    public string? AltBayiAdres { get; set; }

    public string? AltBayiSehir { get; set; }

    public string? AltBayiIlce { get; set; }

    public string? AltBayiYetkili { get; set; }

    public string? AltBayiTelefon { get; set; }

    public string? AltBayiTelefon1 { get; set; }

    public string? AltBayiMail { get; set; }

    public int? SikayetUrunId { get; set; }

    public string? UrunAdi { get; set; }

    public string Nerelerdesin { get; set; } = null!;

    public string? ServisFisNo { get; set; }
}
