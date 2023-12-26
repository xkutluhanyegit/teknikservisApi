using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbMessage
{
    public int MesId { get; set; }

    public int? MesUserId { get; set; }

    public int? MesReadIsActive { get; set; }

    public string? MesTitle { get; set; }

    public string? MesContent { get; set; }

    public DateTime? MesDate { get; set; }

    public int MesSendUserId { get; set; }

    public string? MesSendUserIp { get; set; }

    public int? MesajSikayetId { get; set; }

    public int? MesajarizaId { get; set; }
}
