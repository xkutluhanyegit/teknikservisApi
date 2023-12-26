using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbMailList
{
    public int MailId { get; set; }

    public string? MailName { get; set; }

    public string? MailIp { get; set; }

    public string? MailDate { get; set; }
}
