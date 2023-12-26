using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbGallery
{
    public int RefId { get; set; }

    public int? RefIsActive { get; set; }

    public int? RefLanguageId { get; set; }

    public string? RefTitle { get; set; }

    public string? RefDescription { get; set; }

    public int? RefCatId { get; set; }

    public string? RefPictureUrl { get; set; }

    public DateTime? RefDate { get; set; }

    public int? SingularCount { get; set; }

    public int? PluralCount { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
