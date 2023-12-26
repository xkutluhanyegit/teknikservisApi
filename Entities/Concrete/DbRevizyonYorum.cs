using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbRevizyonYorum
{
    public int YorumId { get; set; }

    public int? RevizyonId { get; set; }

    public DateTime? YorumTarih { get; set; }

    public int? UserId { get; set; }

    public string? Yorum { get; set; }
}
