using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbAnket
{
    public int AnketId { get; set; }

    public int? AnketIsActive { get; set; }

    public int? AnketLanguageId { get; set; }

    public int? AnketCatId { get; set; }

    public string? AnketSoru { get; set; }

    public DateTime? AnketDate { get; set; }

    public int? AnketCount { get; set; }

    public int? AnketInput { get; set; }
}
