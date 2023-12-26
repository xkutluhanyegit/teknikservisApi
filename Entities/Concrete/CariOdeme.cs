using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class CariOdeme
{
    public int OdemeId { get; set; }

    public int? OdemeUserId { get; set; }

    public DateTime? OdemeEklenmeTarih { get; set; }

    public string? OdemeTutar5 { get; set; }

    public decimal? OdemeTutar { get; set; }

    public int? OdemeActive { get; set; }

    public int? OdemeTaksitActive { get; set; }

    public string? OdemeCariId { get; set; }

    public int OdemeOnay { get; set; }

    public string? OdemeTarih { get; set; }

    public DateTime? OdemeUpdate { get; set; }

    public int? OdemeUserAdmin { get; set; }
}
