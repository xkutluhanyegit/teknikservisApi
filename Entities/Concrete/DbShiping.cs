using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbShiping
{
    public int ShipId { get; set; }

    public string? ShipName { get; set; }

    public double? ShipPrice { get; set; }

    public int? ShipKapiIsActive { get; set; }

    public double? ShipKapiPrice { get; set; }

    public string? KapidaOdemeContent { get; set; }

    public string? ShipYetkiliName { get; set; }

    public string? Shiptelefon { get; set; }

    public string? Shipsube { get; set; }

    public string? Shiplinkkontrol { get; set; }

    public string? ShipDesiPrice { get; set; }

    public string? ShipDesiAktif { get; set; }

    public int? ShipIsActive { get; set; }

    public string? ShipState { get; set; }

    public double? ShipTuketiciFiyati { get; set; }

    public string? TakipUrl { get; set; }

    public int? ShipDefault { get; set; }
}
