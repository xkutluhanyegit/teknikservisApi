using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbSikayetMesajlari
{
    public int MesajId { get; set; }

    public int? MesajOkunduIsActive { get; set; }

    public string? MesajBaslik { get; set; }

    public string? MesajIcerik { get; set; }

    public int? MesajKimeId { get; set; }

    public int? MesajKimdenId { get; set; }

    public int? MesajSikayetId { get; set; }

    public DateTime? MesajTarih { get; set; }

    public int? MesajarizaId { get; set; }
}
