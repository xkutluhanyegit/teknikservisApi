using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbMenuListNew
{
    public int AdMenuId { get; set; }

    public string? AdMenuName { get; set; }

    public string? AdMenuDesc { get; set; }

    public int? AdMenuOrderCount { get; set; }

    public string? AdMenuUrl { get; set; }

    public string? AdMenuPictureUrl { get; set; }

    public int? AdMenuIsActive { get; set; }

    public int? AdmenuParentId { get; set; }

    public int? AdMenustIsActive { get; set; }
}
