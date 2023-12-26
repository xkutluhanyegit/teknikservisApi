using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class V2023Product
{
    public int ProdId { get; set; }

    public string? ProdName { get; set; }

    public string? ProdBarcodeCode { get; set; }

    public double? ProdSatisPrice { get; set; }

    public int? ProdParentId { get; set; }

    public string? ProdBarcodeNo { get; set; }

    public string? DetalProdName { get; set; }

    public double? DetalProdSatisFiyat { get; set; }

    public bool? TGuncel { get; set; }

    public bool? DetaltGuncel { get; set; }
}
