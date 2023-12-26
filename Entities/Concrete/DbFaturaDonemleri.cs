using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbFaturaDonemleri
{
    public int DonemId { get; set; }

    public DateTime? DonemTarih { get; set; }

    public DateTime? DonemFatTarihi { get; set; }

    public string? DonemFatNo { get; set; }

    public double? DonemOdenen { get; set; }

    public string? DonemNot { get; set; }

    public string? DonemSikayetler { get; set; }

    public int? DonemUserId { get; set; }

    public double? DonemIsToplam { get; set; }

    public double? DonemYolToplam { get; set; }

    public int? DonemTamam { get; set; }

    public int? DonemOdemeTuru { get; set; }
}
