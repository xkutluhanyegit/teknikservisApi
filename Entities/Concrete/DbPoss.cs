using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbPoss
{
    public int PosId { get; set; }

    public int? PosIsActive { get; set; }

    public string? PosCartName { get; set; }

    public string? PosCartUser { get; set; }

    public string? PosCartPassword { get; set; }

    public string? PosMagazaId { get; set; }

    public string? PosClientId { get; set; }

    public string? PosName { get; set; }

    public string? BankaTaksitOranlari { get; set; }

    public string? PosUrl { get; set; }

    public int? PosOrderCount { get; set; }

    public int? PosIsDefault { get; set; }

    public string? PosYontem { get; set; }

    public int? Pos3d { get; set; }

    public string? Pos3StoreKey { get; set; }
}
