using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbPersonel
{
    public int PersonelId { get; set; }

    public string? PersonelAdSoyad { get; set; }

    public int? UserId { get; set; }

    public string? PersonelMail { get; set; }

    public string? PersonelParola { get; set; }

    public bool? PersonelAktif { get; set; }

    public int? PersonelSube { get; set; }

    public string? PersonelYetki { get; set; }

    public string? Kkodukpm { get; set; }

    public string? PersonelIp { get; set; }

    public string? PersonelSirket { get; set; }

    public string? PersonelSayfalar { get; set; }

    public DateTime? UserLastLoginDate { get; set; }
}
