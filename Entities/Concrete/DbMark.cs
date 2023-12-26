using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbMark
{
    public int MarkId { get; set; }

    public int? MarkIsActive { get; set; }

    public int? MarkLanguageId { get; set; }

    public string? MarkName { get; set; }

    public int? MarkSuppliersId { get; set; }

    public string? MarkPictureUrl { get; set; }

    public string? MarkContent { get; set; }

    public DateTime? MarkDate { get; set; }

    public string? SeoName { get; set; }

    public int? SingularCount { get; set; }

    public int? PluralCount { get; set; }
}
