using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbOrderState
{
    public int StateId { get; set; }

    public string? StateName { get; set; }

    public string? StateColor { get; set; }
}
