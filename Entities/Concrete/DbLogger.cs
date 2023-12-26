using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbLogger
{
    public int LogId { get; set; }

    public string? LogIp { get; set; }

    public DateTime? LogDate { get; set; }

    public string? LogBrowser { get; set; }

    public int? LogUserId { get; set; }

    public string? LogUserName { get; set; }

    public int? UserId { get; set; }

    public int? PersonelId { get; set; }

    public string? PersonelAdi { get; set; }

    public int? PersonelActive { get; set; }

    public string? LogoutDate { get; set; }
}
