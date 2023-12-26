using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbLow
{
    public int LowId { get; set; }

    public int? LowCatId { get; set; }

    public string? LowDesc { get; set; }

    public int? LowIsActive { get; set; }

    public int? LowSortOrtder { get; set; }

    public int? LowLang { get; set; }
}
