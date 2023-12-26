using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbProductCategory
{
    public int ProdCatId { get; set; }

    public int? CatId { get; set; }

    public int? ProdId { get; set; }
}
