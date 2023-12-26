using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class CatMark
{
    public int ProdCatId { get; set; }

    public int? ProdCatIsActive { get; set; }

    public int? ProdCatLanguageId { get; set; }

    public string? ProdCatName { get; set; }

    public int? ProdCatParentCategoryId { get; set; }

    public string? ProdCatPictureUrl { get; set; }

    public string? ProdCatContent { get; set; }

    public string? ProdUrl { get; set; }

    public string? ProdCatDate { get; set; }

    public string? SeoName { get; set; }

    public int? ProdCatOrderCount { get; set; }

    public int? SingularCount { get; set; }

    public int? PluralCount { get; set; }

    public string? ProdBarcodeCode { get; set; }

    public string? ProdStockCode { get; set; }

    public int? ProdCatVideoCatId { get; set; }

    public string? Pdf1 { get; set; }

    public string? Pdf2 { get; set; }

    public string? Pdf3 { get; set; }

    public string? Pdf4 { get; set; }

    public string? Pdf5 { get; set; }

    public string? Patlak1 { get; set; }

    public string? Patlak2 { get; set; }

    public string? Patlak3 { get; set; }

    public string? Patlak4 { get; set; }

    public string? Patlak5 { get; set; }

    public int MarkId { get; set; }

    public int? MarkIsActive { get; set; }

    public int? MarkLanguageId { get; set; }

    public string? MarkName { get; set; }

    public int? MarkSuppliersId { get; set; }

    public string? MarkPictureUrl { get; set; }

    public string? MarkContent { get; set; }

    public string? MarkDate { get; set; }

    public string? Expr1 { get; set; }

    public int? Expr2 { get; set; }

    public int? Expr3 { get; set; }
}
