using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbLisan
{
    public int LowId { get; set; }

    public int? LowIsActive { get; set; }

    public string? LowDesc { get; set; }

    public int? LowLangId { get; set; }

    public int? LowParId { get; set; }

    public string? LowAciklama { get; set; }
}
