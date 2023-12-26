using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbSikayetState
{
    public int StateId { get; set; }

    public string? StateName { get; set; }

    public string? StateColor { get; set; }

    public string? StateDescription { get; set; }

    public double? StatePrice { get; set; }

    public int? StateIsActive { get; set; }

    public string? StateUrl { get; set; }
}
