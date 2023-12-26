using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class VTegSoftDbUser
{
    public int UserId { get; set; }

    public string? UserCariId { get; set; }

    public string? UserMail { get; set; }

    public string? UserName { get; set; }

    public string? UserVergiNo { get; set; }

    public string? UserTel1 { get; set; }

    public string? UserTel2 { get; set; }

    public string? UserTel3 { get; set; }

    public string? CentNameTegSoft { get; set; }

    public string? TeslimatTelNo { get; set; }

    public string? FaturaTelNo { get; set; }
}
