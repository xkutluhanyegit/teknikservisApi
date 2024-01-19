using System;
using System.Collections.Generic;
using Core.Entities;

namespace Entities.Concrete;

public partial class DbProductOption:IEntity
{
    public int ProdId { get; set; }

    public int? ProdParentId { get; set; }

    public int? ProdStockSize { get; set; }

    public int? ProdIsActive { get; set; }

    public string? ProdName { get; set; }

    public double? ProdSatisPrice { get; set; }

    public string? ProdBarcodeNo { get; set; }

    public string? ProdPictureUrl { get; set; }

    public double? ProdBirim { get; set; }

    public int? ProdBirimDesc { get; set; }

    public DateTime? ProdDate { get; set; }

    public bool? TGuncel { get; set; }
}
