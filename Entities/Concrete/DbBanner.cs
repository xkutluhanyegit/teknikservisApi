using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbBanner
{
    public int BannerId { get; set; }

    public int? BannerPageId { get; set; }

    public bool? BannerIsActive { get; set; }

    public string? BannerTitle { get; set; }

    public string? BannerDescription { get; set; }

    public string? BannerLinkUrl { get; set; }

    public string? BannerPictureUrl { get; set; }

    public string? BannerLocation { get; set; }

    public int? BannerLanguageId { get; set; }

    public DateTime? BannerDate { get; set; }

    public int? BannerVisitedCount { get; set; }

    public int? BannerTitleShowIsActive { get; set; }

    public int? BannerOrderCount { get; set; }

    public string? BannerIcerikTablo { get; set; }

    public int? BannerIcerikId { get; set; }

    public DateTime? BannerBaslangicTarihi { get; set; }

    public DateTime? BannerBitisTarihi { get; set; }
}
