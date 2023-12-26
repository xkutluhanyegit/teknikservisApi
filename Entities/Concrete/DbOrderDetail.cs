using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbOrderDetail
{
    public int DetailId { get; set; }

    public int? DetailOrderId { get; set; }

    public int? DetailProdId { get; set; }

    public int? DetailSubProdId { get; set; }

    public int? DetailProdCount { get; set; }

    public int? DetailGonderilenAdet { get; set; }

    public string? DetailProdBarcodeCode { get; set; }

    public string? DetailPlu { get; set; }

    public string? DetailProdName { get; set; }

    public decimal? DetailProdPrice { get; set; }

    public string? DetailProdPurchaseRate { get; set; }

    public string? DetailOrderTempId { get; set; }

    public int? DetailsikayetId { get; set; }

    public int? DetailUserId { get; set; }

    public byte? NavCektiMi { get; set; }

    public int? OrderType { get; set; }
}
