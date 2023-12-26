using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbMenu
{
    public int MenuId { get; set; }

    public int? MenuParentId { get; set; }

    public int? MenuLangId { get; set; }

    public int? MenuIsActive { get; set; }

    public string? MenuName { get; set; }

    public int? MenuOrderCount { get; set; }

    public string? MenuUrl { get; set; }

    public int? MenuAuthIsActive { get; set; }

    public string? MenuLocation { get; set; }

    public DateTime? MenuIsDate { get; set; }

    public DateTime? MenuIsUpDate { get; set; }
}
