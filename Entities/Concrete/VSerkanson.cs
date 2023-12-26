using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class VSerkanson
{
    public int SikayetId { get; set; }

    public int? SikayetServisId { get; set; }

    public int? SikayetDurum { get; set; }

    public int? HakedisDurum { get; set; }

    public double? IscilikFiyat { get; set; }

    public double? Kdv { get; set; }

    public int? LogStateId { get; set; }

    public bool? BasitUsul { get; set; }

    public double? Yol { get; set; }

    public string? UserCariId { get; set; }

    public int? UserId { get; set; }
}
