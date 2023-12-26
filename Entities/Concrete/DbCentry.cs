using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbCentry
{
    public int CentId { get; set; }

    public string CentName { get; set; } = null!;

    public string? CentNameTegSoft { get; set; }
}
