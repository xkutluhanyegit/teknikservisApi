using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbPage
{
    public int PageId { get; set; }

    public int? PageCatId { get; set; }

    public int? PageGalCatId { get; set; }

    public int? PageIsActive { get; set; }

    public int? PageLanguageId { get; set; }

    public string? PageName { get; set; }

    public string? PageContent { get; set; }

    public int? PageVisitedCount { get; set; }

    public int? PageOrderCount { get; set; }

    public string? PagePictureUrl { get; set; }

    public string? Pagepdf { get; set; }

    public string? PageBannerUrl { get; set; }

    public string? PageBannerLink { get; set; }

    public DateTime? PageDate { get; set; }

    public string? SeoName { get; set; }

    public int? SingularCount { get; set; }

    public int? PluralCount { get; set; }

    public int? PageVideoCatId { get; set; }

    public string? PageGizlilik { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? PageHomeIsActive { get; set; }

    public string? MetaKeywords { get; set; }

    public string? MetaTitle { get; set; }

    public string? MetaDescription { get; set; }

    public string? LogIp { get; set; }

    public int? Menuaktif { get; set; }
}
