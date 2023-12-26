using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbBasvurular
{
    public int BasvuruId { get; set; }

    public string? AdSoyad { get; set; }

    public string? SirketAdi { get; set; }

    public string? DogumYeri { get; set; }

    public string? DogumTarihi { get; set; }

    public string? Uyrugu { get; set; }

    public int? OrtaklikDurum { get; set; }

    public int? Cinsiyet { get; set; }

    public int? MedeniDurum { get; set; }

    public int? IletisimTercih { get; set; }

    public string? EvAdres { get; set; }

    public string? IsAdres { get; set; }

    public string? DigerAdres { get; set; }

    public string? EvTel { get; set; }

    public string? IsTel { get; set; }

    public string? Fax { get; set; }

    public string? Gsm { get; set; }

    public string? Email { get; set; }

    public string? Msn { get; set; }

    public int? Il { get; set; }

    public int? Ilce { get; set; }

    public string? BaktigiBolgeler { get; set; }

    public int? BolgeTercih { get; set; }

    public string? UniversiteOkul { get; set; }

    public string? UniversiteBolum { get; set; }

    public string? UniversiteBaslangic { get; set; }

    public string? UniversiteBitis { get; set; }

    public string? UniversiteMezDerece { get; set; }

    public string? YuksOkulOkul { get; set; }

    public string? YuksOkulBolum { get; set; }

    public string? YuksOkulBaslangic { get; set; }

    public string? YuksOkulBitis { get; set; }

    public string? YuksOkulMezDerece { get; set; }

    public string? LiseOkul { get; set; }

    public string? LiseBolum { get; set; }

    public string? LiseBaslangic { get; set; }

    public string? LiseBitis { get; set; }

    public string? LiseMezDerece { get; set; }

    public string? Meslek { get; set; }

    public int? AskerlikDurum { get; set; }

    public string? TecilTarih { get; set; }

    public string? YaptigiIsler { get; set; }

    public int? BisikletBilgi { get; set; }

    public int? MotorsikletBilgi { get; set; }

    public int? ElektrikBilgi { get; set; }

    public int? ElektronikBilgi { get; set; }

    public int? BeyazEsyaBilgi { get; set; }

    public int? KlimaBilgi { get; set; }

    public int? AnkastreBilgi { get; set; }

    public int? TesisatBilgi { get; set; }

    public int? YetkiliServisDahaOnce { get; set; }

    public int? YetkiliServisSuAn { get; set; }

    public string? YetkiliServisFirmalar { get; set; }

    public int? VergiTuru { get; set; }

    public int? TeminatDurumu { get; set; }

    public int? Tsehyb { get; set; }

    public string? TseKapsamlar { get; set; }

    public int? PcDurum { get; set; }

    public int? YabanciDil { get; set; }

    public string? YabanciDiller { get; set; }

    public string? AldigiEgitim { get; set; }

    public string? CalisanEleman { get; set; }

    public string? MuhendisSayisi { get; set; }

    public string? Myosayisi { get; set; }

    public string? LiseliSayisi { get; set; }

    public int? VasitaDurum { get; set; }

    public string? VasitaDetay { get; set; }

    public int? DukkanDurum { get; set; }

    public string? DukkanAlan { get; set; }

    public string? Ref1AdSoyad { get; set; }

    public string? Ref1Sirket { get; set; }

    public string? Ref1Telefon { get; set; }

    public string? Ref2AdSoyad { get; set; }

    public string? Ref2Sirket { get; set; }

    public string? Ref2Telefon { get; set; }

    public string? Ref3AdSoyad { get; set; }

    public string? Ref3Sirket { get; set; }

    public string? Ref3Telefon { get; set; }

    public string? Ref4AdSoyad { get; set; }

    public string? Ref4Sirket { get; set; }

    public string? Ref4Telefon { get; set; }

    public int? MahkemeDurum { get; set; }

    public string? MahkemeDetay { get; set; }

    public int? SaglikDurum { get; set; }

    public string? SaglikDetay { get; set; }

    public string? DernekKulup { get; set; }

    public string? NedenPilsan { get; set; }

    public int? SozlesmeOnay { get; set; }
}
