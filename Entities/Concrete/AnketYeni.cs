using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class AnketYeni
{
    public int Id { get; set; }

    public string? Numara { get; set; }

    public string? Tus { get; set; }

    public string? Moddate { get; set; }

    public string? UnitId { get; set; }

    public string? CallId { get; set; }

    public string? ModUid { get; set; }
}
