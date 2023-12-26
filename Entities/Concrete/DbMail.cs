using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbMail
{
    public int MailId { get; set; }

    public string? MailUsers { get; set; }

    public string? MailSubject { get; set; }

    public string? MailContent { get; set; }

    public DateTime MailDate { get; set; }
}
