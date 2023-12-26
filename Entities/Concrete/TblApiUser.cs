using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class TblApiUser
{
    public int Id { get; set; }

    public string? FirmCode { get; set; }

    public Guid? SecretKey { get; set; }

    public Guid? PrimaryKey { get; set; }

    public string? Password { get; set; }
}
