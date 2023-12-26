using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbVideo
{
    public int RefId { get; set; }

    public int? RefIsActive { get; set; }

    public int? RefLanguageId { get; set; }

    public string? RefTitle { get; set; }

    public string? RefDescription { get; set; }

    public string? RefPictureUrl { get; set; }

    public string? RefVideoUrl { get; set; }

    public string? RefDate { get; set; }

    public string? SeoName { get; set; }

    public int? SingularCount { get; set; }

    public int? PluralCount { get; set; }

    public string? RefYoutubeId { get; set; }

    public string? RefVimeoId { get; set; }
}
