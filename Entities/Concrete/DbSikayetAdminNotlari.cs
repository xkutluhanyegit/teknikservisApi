using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbSikayetAdminNotlari
{
    public int NotId { get; set; }

    public DateTime? EklenmeTarihi { get; set; }

    public int? SikayetId { get; set; }

    public string? Ekleyen { get; set; }

    public string? Aciklama { get; set; }
}
