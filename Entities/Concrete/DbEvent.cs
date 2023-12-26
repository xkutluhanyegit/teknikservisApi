using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbEvent
{
    public int PageId { get; set; }

    public int? PageIsActive { get; set; }

    public int? PageLanguageId { get; set; }

    public string? PageName { get; set; }

    public string? PageContent { get; set; }

    public int? PageVisitedCount { get; set; }

    public int? PageOrderCount { get; set; }

    public string? PagePictureUrl { get; set; }

    public DateTime? PageDate { get; set; }

    public string? SeoName { get; set; }

    public string? PageStartDate { get; set; }

    public string? PageFinishDate { get; set; }

    public int? SingularCount { get; set; }

    public int? PluralCount { get; set; }

    public int? PageVideoCatId { get; set; }
}
