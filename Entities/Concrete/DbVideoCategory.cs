using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbVideoCategory
{
    public int VideoCatId { get; set; }

    public int? VideoCatIsActive { get; set; }

    public int? VideoCatLanguageId { get; set; }

    public string? VideoCatName { get; set; }

    public string? VideoCatContent { get; set; }

    public int? VideoCatParentCategoryId { get; set; }

    public string? VideoCatPictureUrl { get; set; }

    public DateTime? VideoCatDate { get; set; }

    public string? SeoName { get; set; }

    public int? VideoCatOrderCount { get; set; }

    public int? SingularCount { get; set; }

    public int? PluralCount { get; set; }
}
