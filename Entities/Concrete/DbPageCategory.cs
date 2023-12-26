using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbPageCategory
{
    public int PageCatId { get; set; }

    public int? PageCatIsActive { get; set; }

    public int? PageCatLanguageId { get; set; }

    public string? PageCatName { get; set; }

    public string? PageCatContent { get; set; }

    public int? PageCatParentCategoryId { get; set; }

    public string? PageCatPictureUrl { get; set; }

    public DateTime? PageCatDate { get; set; }

    public string? SeoName { get; set; }

    public int? PageCatOrderCount { get; set; }

    public int? SingularCount { get; set; }

    public int? PluralCount { get; set; }
}
