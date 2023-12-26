using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbTopluMesaj
{
    public int MesId { get; set; }

    public DateTime? MesTarih { get; set; }

    public string? MesKime { get; set; }

    public string? MesKonu { get; set; }

    public string? MesMesaj { get; set; }
}
