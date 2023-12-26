using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbTopluMailList
{
    public int MailId { get; set; }

    public int? MailKat { get; set; }

    public string? MailAdres { get; set; }

    public bool? AktifPasif { get; set; }
}
