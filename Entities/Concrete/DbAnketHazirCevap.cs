using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbAnketHazirCevap
{
    public int AnketCevId { get; set; }

    public int? AnketCevIsActive { get; set; }

    public string? AnketCevName { get; set; }

    public int? AnketId { get; set; }

    public int? AnketCevNameId { get; set; }
}
