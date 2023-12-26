using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbYedekParcalar
{
    public int Id { get; set; }

    public int? DonemId { get; set; }

    public int? DonemUserId { get; set; }

    public DateTime? DonemTarih { get; set; }

    public string? ProdNo { get; set; }

    public string? Aciklama { get; set; }

    public int? Miktar { get; set; }

    public double? BirimFiyat { get; set; }
}
