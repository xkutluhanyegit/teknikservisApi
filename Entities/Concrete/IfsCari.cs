using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class IfsCari
{
    public int Id { get; set; }

    public string? CariNo { get; set; }

    public DateTime? Tarih { get; set; }

    public string? BelgeTuru { get; set; }

    public string? DokumanNo { get; set; }

    public string? Aciklama { get; set; }

    public double? Borc { get; set; }

    public double? Alacak { get; set; }

    public double? Kalan { get; set; }

    public double? RiskLimit { get; set; }

    public int? UserId { get; set; }
}
