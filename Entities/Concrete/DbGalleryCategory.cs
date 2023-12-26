using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbGalleryCategory
{
    public int RefCatId { get; set; }

    public int? RefCatIsActive { get; set; }

    public int? RefCatLanguageId { get; set; }

    public string? RefCatName { get; set; }

    public int? RefCatParentCategoryId { get; set; }

    public string? RefCatContent { get; set; }

    public string? RefCatPictureUrl { get; set; }

    public DateTime? RefCatDate { get; set; }

    public int? RefCatOrderCount { get; set; }

    public string? SeoName { get; set; }

    public int? SingularCount { get; set; }

    public int? PluralCount { get; set; }
}
