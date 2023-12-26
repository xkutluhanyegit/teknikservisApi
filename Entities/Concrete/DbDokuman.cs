using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbDokuman
{
    public int DokumanId { get; set; }

    public int? DokumanUserId { get; set; }

    public int? DokumanBayiId { get; set; }

    public DateTime? DokumanTarih { get; set; }

    public string? Dokuman { get; set; }

    public bool? DokumanDurum { get; set; }

    public string? DokumanUserIp { get; set; }

    public long? DokumanUserTc { get; set; }

    public bool? DokumanKef { get; set; }
}
