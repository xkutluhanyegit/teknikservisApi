using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbRevizyonTakip
{
    public int RevizyonId { get; set; }

    public int? RevizyonYapildiMi { get; set; }

    public string? RevizyonBaslik { get; set; }

    public DateTime? RevizyonTalepTarihi { get; set; }

    public DateTime? RevizyonSonTarih { get; set; }

    public string? RevizyonTuru { get; set; }

    public string? RevizyonAciklamasi { get; set; }

    public int? RevizyonTalepEden { get; set; }

    public int? RevizyonKapatan { get; set; }

    public string? RevizyonKapatanNot { get; set; }

    public string? RevizyonPictureUrl { get; set; }

    public int? Revizyononem { get; set; }

    public int? RevizyonTipi { get; set; }

    public string? LogIp { get; set; }

    public string? RevizyonPictureUrl1 { get; set; }

    public string? RevizyonPictureUrl2 { get; set; }

    public string? RevizyonPictureUrl3 { get; set; }
}
