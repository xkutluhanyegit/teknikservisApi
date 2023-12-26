using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbDistrict
{
    public int DistrictId { get; set; }

    public string? DistrictName { get; set; }

    public int? DistrictCentId { get; set; }
}
