using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class OnlineMesaj
{
    public int MesajId { get; set; }

    public string? MesajBaslik { get; set; }

    public string? MesajIcerik { get; set; }

    public int? MesajOkunduIsActive { get; set; }

    public DateTime? MesajTarih { get; set; }

    public int? MesajKimdenId { get; set; }

    public int? MesajParentId { get; set; }

    public int? MesajUserId { get; set; }
}
