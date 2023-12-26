using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbProdCatMark
{
    public int CatMarkId { get; set; }

    public int? CatId { get; set; }

    public int? MarkId { get; set; }
}
