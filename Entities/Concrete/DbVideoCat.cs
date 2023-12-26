using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbVideoCat
{
    public int V1 { get; set; }

    public int? VideoCatId { get; set; }

    public int? VideoId { get; set; }
}
