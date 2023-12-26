using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class CatProd
{
    public int? ProdId { get; set; }

    public int DbProductsProdId { get; set; }

    public int? ProdVideoCatId { get; set; }

    public int? ProdMarkId { get; set; }

    public int? ProdAssessId { get; set; }

    public int? ProdIsActive { get; set; }

    public string? ProdName { get; set; }

    public int? ProdLanguageId { get; set; }

    public string? ProdDescription { get; set; }

    public string? ProdPictureUrl { get; set; }

    public string? ProdBannerUrl { get; set; }

    public string? ProdBannerLink { get; set; }

    public int? ProdVisitedCount { get; set; }

    public string? ProdDate { get; set; }

    public string? SeoName { get; set; }

    public int? ProdOrderCount { get; set; }

    public int? SingularCount { get; set; }

    public int? PluralCount { get; set; }

    public int? ProdStockSize { get; set; }

    public double? ProdAlisPrice { get; set; }

    public double? ProdTavsiyePrice { get; set; }

    public double? ProdSatisPrice { get; set; }

    public double? ProdBayiPrice { get; set; }

    public double? ProdIndirimPrice { get; set; }

    public int? ProdHomeIsActive { get; set; }

    public string? ProdBarcodeCode { get; set; }

    public string? ProdStockCode { get; set; }

    public int? ProdVergiId { get; set; }

    public string? ProdSeoKeys { get; set; }

    public string? ProdSeoDesc { get; set; }

    public int? ProdCommentIsActive { get; set; }

    public int? CartCount { get; set; }

    public int? OrderCount { get; set; }

    public int? TicketCount { get; set; }

    public string? Pdf1 { get; set; }

    public string? Pdf2 { get; set; }

    public string? Pdf3 { get; set; }

    public string? Pdf4 { get; set; }

    public string? Pdf5 { get; set; }

    public int? ProdCriticStock { get; set; }

    public int? CatId { get; set; }
}
