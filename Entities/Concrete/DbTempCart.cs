using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbTempCart
{
    public int TempId { get; set; }

    public DateTime? Date { get; set; }

    public int? TempProductId { get; set; }

    public int? TempUserId { get; set; }

    public string? TempIsActive { get; set; }

    public int? TempProductCount { get; set; }

    public int? TempRandom { get; set; }

    public int? TempOptId { get; set; }

    public int? TempSikayetId { get; set; }
}
