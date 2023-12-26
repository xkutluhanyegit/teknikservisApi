using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbAnketcvpAlt
{
    public int CvpId { get; set; }

    public int? AnketId { get; set; }

    public int? AnketCevId { get; set; }
}
