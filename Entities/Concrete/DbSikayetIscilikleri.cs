using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbSikayetIscilikleri
{
    public int LogId { get; set; }

    public int? IscilikId { get; set; }

    public int? SikayetId { get; set; }

    public string? IscilikInputDeger { get; set; }

    public string? LogAciklama { get; set; }

    public DateTime? LogDate { get; set; }

    public int? UserId { get; set; }

    public byte? IsAdmin { get; set; }

    public int? LogOnay { get; set; }

    public int? LogDegisiklik { get; set; }

    public double? IscilikFiyat { get; set; }

    public string? LogAdminAciklama { get; set; }

    public DateTime? TamirTarihi { get; set; }
}
