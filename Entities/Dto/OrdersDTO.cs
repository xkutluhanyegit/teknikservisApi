using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Dto
{
    public class OrdersDTO:IEntity
    {
        public int? siparisID { get; set; }
        public int? detailID { get; set; }
        public string siparisMail { get; set; }
        public DateTime? siparisTarihi { get; set; }
        public int? siparisOdemeYontemi { get; set; }
        public string siparisIP { get; set; }
        public string siparisKargoTipi { get; set; }
        public string siparisPosName { get; set; }
        public string siparisBankName { get; set; }
        public int? siparisDurumu { get; set; }
        public string siparisUrunler { get; set; }
        public decimal? siparisKargoFiyati { get; set; }
        public decimal? siparisKapidaOdeme { get; set; }
        public double? siparisPosOrderID { get; set; }
        public string siparisGuncellemeTarihi { get; set; }
        public string siparisNot { get; set; }
        public string siparisKargoTeslimatNo { get; set; }
        public string siparisVergiDairesi { get; set; }
        public string siparisVergiNo { get; set; }
        public string siparisMagazaNotu { get; set; }
        public string siparisFaturaAdSoyad { get; set; }
        public string siparisFaturaTelNo { get; set; }
        public string siparisFaturaAdresi { get; set; }
        public int? siparisFaturaSehir { get; set; }
        public int? siparisFaturaIlce { get; set; }
        public string siparisFaturaNo { get; set; }
        public string siparisTeslimatAdSoyad { get; set; }
        public string siparisTeslimatTelNo { get; set; }
        public string siparisTeslimatAdres { get; set; }
        public int? siparisTeslimatSehir { get; set; }
        public int? siparisTeslimatIlce { get; set; }
        public int? musteriID { get; set; }
        public int? bayiID { get; set; }
        public int? altBayiID { get; set; }
        public int? siparisUserID { get; set; }
        public double? siparisIndirimOrani { get; set; }
        public string siparisNot1 { get; set; }
        public int? Sales_Type { get; set; }
        public string kargoOdeme { get; set; }

        public string musteri_adsoyad { get; set; }
        public string musteri_kimlikno { get; set; }
        public string musteri_vergidairesi { get; set; }
        public string musteri_vergino { get; set; }
        public string musteri_email { get; set; }
        public string musteri_telefon { get; set; }
        public int? musteri_il { get; set; }
        public int? musteri_ilce { get; set; }
        public string musteri_adres { get; set; }
        public string fatura_adsoyad { get; set; }
        public string fatura_telefon { get; set; }
        public int? fatura_il { get; set; }
        public int? fatura_ilce { get; set; }
        public string fatura_adres { get; set; }
        public string teslimat_adsoyad { get; set; }
        public string teslimat_telefon { get; set; }
        public int? teslimat_il { get; set; }
        public int? teslimat_ilce { get; set; }
        public string teslimat_adres { get; set; }
        public string ifs_cari_kodu { get; set; }
        public string ifs_sevk_adresi { get; set; }

        public string detailProdBarcodeCode { get; set; }
        public string detailProdName { get; set; }
        public int? detailProdCount { get; set; }
        public string ikincilMiktar { get; set; }
        public string ikincilBirim { get; set; }
        public decimal? detailProdPrice { get; set; }
        public string prodName { get; set; }
    }
}