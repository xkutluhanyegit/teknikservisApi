using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbBlog
{
    public int BlogId { get; set; }

    public int? BlogLanguageId { get; set; }

    public int? BlogVideoCatId { get; set; }

    public int? BlogIsActive { get; set; }

    public string? BlogTitle { get; set; }

    public string? BlogContent { get; set; }

    public string? BlogPictureUrl { get; set; }

    public string? SeoName { get; set; }

    public int? BlogOrderCount { get; set; }

    public DateTime? BlogDate { get; set; }

    public bool? BlogMenuIsActive { get; set; }

    public int? BlogCategoryId { get; set; }

    public int? BlogGalCatId { get; set; }

    public int? BlogVideoId { get; set; }

    public bool? BlogIsDelete { get; set; }

    public string? BlogName { get; set; }

    public string? BlogBannerUrl { get; set; }

    public string? BlogBannerLink { get; set; }

    public int? SingularCount { get; set; }

    public int? PluralCount { get; set; }

    public int? ParentId { get; set; }

    public bool? BlogHomeIsActive { get; set; }

    public string? MetaKeywords { get; set; }

    public string? MetaTitle { get; set; }

    public string? MetaDescription { get; set; }

    public string? Blogpdf { get; set; }

    public DateTime? BlogIsUpDate { get; set; }

    public string? LogIp { get; set; }

    public bool? Menuaktif { get; set; }

    public string? Blogclass { get; set; }

    public string? BlogGizlilik { get; set; }

    public int? BlogProdCat { get; set; }

    public int? BlogUserId { get; set; }
}
