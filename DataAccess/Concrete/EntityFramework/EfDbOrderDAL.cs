using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDbOrderDAL : EfEntityRepositoryBase<DbOrder, DbPilsanTsContext>, IDbOrderDAL
    {
        public List<OrdersDTO> GetOrdersDTOs()
        {
            using (var context = new DbPilsanTsContext())
            {
                var ordersList = context.DbOrders.Where(p=>p.SiparisDurumu == 3);
                var orderDetailsList = context.DbOrderDetails;
                var musterilersList = context.DbMusterilers;
                var productOptionsList = context.DbProductOptions;

                var result = from orders in ordersList
                            join orderDetails in orderDetailsList
                            on orders.SiparisId equals orderDetails.DetailOrderId into t1
                            from table1 in t1.DefaultIfEmpty()

                            join musteriler in musterilersList
                            on orders.MusteriId equals musteriler.MusteriId into t2
                            from table2 in t2.DefaultIfEmpty()

                            join productOption in productOptionsList
                            on table1.DetailProdId equals productOption.ProdId into t3
                            from table3 in t3.DefaultIfEmpty()

                            select new OrdersDTO {

                               /*DbOrder Table*/
                               siparisID = orders.SiparisId,
                               siparisMail = orders.SiparisMail,
                               siparisTarihi = orders.SiparisTarihi,
                               siparisOdemeYontemi = orders.SiparisOdemeYontemi,
                               siparisIP = orders.SiparisIp,
                               siparisKargoTipi = orders.SiparisKargoTipi,
                               siparisPosName = orders.SiparisPosName,
                               siparisBankName = orders.SiparisBankName,
                               siparisDurumu = orders.SiparisDurumu,
                               siparisUrunler = orders.SiparisUrunler,
                               siparisKargoFiyati = orders.SiparisKargoFiyati,
                               siparisKapidaOdeme = orders.SiparisKapidaOdeme,
                               siparisPosOrderID = orders.SiparisPosOrderId,
                               siparisGuncellemeTarihi = orders.SiparisGuncellemeTarihi,
                               siparisNot = orders.SiparisNot,
                               siparisKargoTeslimatNo = orders.SiparisKargoTeslimatNo,
                               siparisVergiDairesi = orders.SiparisVergiDairesi,
                               siparisVergiNo = orders.SiparisVergiNo,
                               siparisMagazaNotu = orders.SiparisMagazaNotu,
                               siparisFaturaAdSoyad = orders.SiparisFaturaAdSoyad,
                               siparisFaturaTelNo = orders.SiparisFaturaTelNo,
                               siparisFaturaAdresi = orders.SiparisFaturaAdresi,
                               siparisFaturaSehir = orders.SiparisFaturaSehir,
                               siparisFaturaIlce = orders.SiparisFaturaIlce,
                               siparisFaturaNo = orders.SiparisFaturaNo,
                               siparisTeslimatAdSoyad = orders.SiparisTeslimatAdSoyad,
                               siparisTeslimatTelNo = orders.SiparisTeslimatTelNo,
                               siparisTeslimatAdres = orders.SiparisTeslimatAdres,
                               siparisTeslimatSehir = orders.SiparisTeslimatSehir,
                               siparisTeslimatIlce = orders.SiparisTeslimatIlce,
                               musteriID = orders.MusteriId,
                               bayiID = orders.BayiId,
                               altBayiID = orders.AltBayiId,
                               siparisUserID = orders.SiparisUserId,
                               siparisIndirimOrani = orders.SiparisIndirimOrani,
                               siparisNot1 = orders.SiparisNot1,
                               Sales_Type = orders.SalesType,
                               kargoOdeme = orders.KargoOdeme,
                               ifs_cari_kodu = orders.IfsCariKodu,
                               ifs_sevk_adresi = orders.IfsSevkAdresi,


                               /*Müşteriler Table*/
                               musteri_adsoyad = table2.MusteriAdsoyad,
                               musteri_kimlikno = table2.MusteriKimlikno,
                               musteri_vergidairesi = table2.MusteriVergidairesi,
                               musteri_vergino = table2.MusteriVergino,
                               musteri_email = table2.MusteriEmail,
                               musteri_telefon = table2.MusteriTelefon,
                               musteri_il = table2.MusteriIl,
                               musteri_ilce = table2.MusteriIlce,
                               musteri_adres = table2.MusteriAdres,
                               fatura_adsoyad = table2.FaturaAdsoyad,
                               fatura_telefon = table2.FaturaTelefon,
                               fatura_il = table2.FaturaIl,
                               fatura_ilce = table2.FaturaIlce,
                               fatura_adres = table2.FaturaAdres,
                               teslimat_adsoyad = table2.TeslimatAdsoyad,
                               teslimat_telefon = table2.TeslimatTelefon,
                               teslimat_il = table2.TeslimatIl,
                               teslimat_ilce = table2.TeslimatIlce,
                               teslimat_adres = table2.TeslimatAdres,

                               /*OrderDetails Table*/
                               detailProdBarcodeCode = table1.DetailProdBarcodeCode,
                               detailProdName = table1.DetailProdName,
                               detailProdCount = table1.DetailProdCount,
                               ikincilMiktar = "",
                               ikincilBirim = "",
                               detailProdPrice = table1.DetailProdPrice,
                               detailID = table1.DetailId,

                               /*ProductOption Table*/
                               prodName = table3.ProdName
                               
                               };



                return result.ToList(); 
            }
        }
    }
}