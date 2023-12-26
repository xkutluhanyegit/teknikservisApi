using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class VParcaListesi
{
    public int? ProdId { get; set; }

    public int? ProdOptId { get; set; }

    public string? ProdName { get; set; }

    public string? ProdPictureUrl { get; set; }

    public string? ProdBarcodeCode { get; set; }

    public double? ProdSatisPrice { get; set; }

    public int? CatId { get; set; }

    public string? No { get; set; }

    public int? ProdIsActive { get; set; }
}
