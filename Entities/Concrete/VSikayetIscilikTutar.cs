using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class VSikayetIscilikTutar
{
    public int SikayetId { get; set; }

    public double? IscilikToplam { get; set; }

    public int? UserId { get; set; }

    public byte? IsAdmin { get; set; }
}
