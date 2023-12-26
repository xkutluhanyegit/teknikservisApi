using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class VServisticket
{
    public int TemsilciId { get; set; }

    public int MtemId { get; set; }

    public int? Hatirlatma { get; set; }

    public string? Alarm { get; set; }

    public int? SikayetDurum { get; set; }
}
