using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbContact
{
    public int ContactId { get; set; }

    public string? ContactContent { get; set; }

    public string? GoogleMap { get; set; }
}
