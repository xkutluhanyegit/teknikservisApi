using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class ServisTicketNot
{
    public int NotId { get; set; }

    public int? NotUserId { get; set; }

    public int? NotTicketId { get; set; }

    public DateTime? NotAddDate { get; set; }

    public string? NotTitle { get; set; }

    public string? NotDesc { get; set; }

    public DateTime? NotHtDate { get; set; }

    public int? NotIsActive { get; set; }
}
