using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbSikayetler
{
    public int SikayetId { get; set; }

    public int? SikayetServisId { get; set; }

    public string? SikayetGarantiNo { get; set; }

    public DateTime? SikayetGarantiNo1 { get; set; }

    public int? SikayetKategoriId { get; set; }

    public int? SikayetUrunId { get; set; }

    public string? SikayetCihazSahibi { get; set; }

    public int? SikayetBayiId { get; set; }

    public int? SikayetAltBayiId { get; set; }

    public string? SikayetKimeAit { get; set; }

    public string? SikayetGarantiIsActive { get; set; }

    public string? SikayetMusteriAdi { get; set; }

    public string? SikayetMusteriSoyAdi { get; set; }

    public string? SikayetMusteriAdresi { get; set; }

    public int? SikayetMusteriSehirId { get; set; }

    public int? SikayetMusteriIlceId { get; set; }

    public string? SikayetMusteriTelNo { get; set; }

    public string? SikayetMusteriCepTelNo { get; set; }

    public string? SikayetMusteriMail { get; set; }

    public string? SikayetIcerik { get; set; }

    public int? SikayetArizaId { get; set; }

    public int? SikayetAriza2Id { get; set; }

    public int? SikayetAriza3Id { get; set; }

    public DateTime? SikayetTarih { get; set; }

    public int? SikayetDurum { get; set; }

    public int? SikayetSiparisId { get; set; }

    public string? SikayetHizmetTuru { get; set; }

    public int? SikayetKimActiId { get; set; }

    public string? SikayetCihazSeri { get; set; }

    public int? HakedisDurum { get; set; }

    public int? SikayetIscilikTipi { get; set; }

    public string? ServisFisNo { get; set; }

    public DateTime? TamirTarihi { get; set; }

    public string? HakedisRedAciklama { get; set; }

    public DateTime? SonGoruntuleme { get; set; }

    public int? PlsTelefonDegisti { get; set; }

    public int? PlsTelefonGonderildi { get; set; }

    public string? ErrorMessage { get; set; }
}
