using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbAnketcvp
{
    public int CvpId { get; set; }

    public int? AnketId { get; set; }

    public int? SikayetId { get; set; }

    public DateTime? KatilimTarihi { get; set; }

    public string? Yaniticerik { get; set; }
}
