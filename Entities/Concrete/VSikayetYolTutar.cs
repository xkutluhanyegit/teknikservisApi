using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class VSikayetYolTutar
{
    public int SikayetId { get; set; }

    public double? YolTutar { get; set; }

    public int? SikayetServisId { get; set; }
}
