using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbAnketCategory
{
    public int AnketCatId { get; set; }

    public int? AnketCatIsActive { get; set; }

    public int? AnketCatLanguageId { get; set; }

    public string? AnketCatName { get; set; }

    public string? AnketCatDate { get; set; }

    public string? SeoName { get; set; }

    public int? AnketCatOrderCount { get; set; }

    public int? SingularCount { get; set; }

    public int? PluralCount { get; set; }
}
