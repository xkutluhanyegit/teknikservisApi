using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbSupplier
{
    public int SuppliersId { get; set; }

    public int? SuppliersIsActive { get; set; }

    public string? SuppliersName { get; set; }

    public string? SuppliersAddress { get; set; }

    public string? SuppliersTelephone { get; set; }

    public string? SuppliersAuthor { get; set; }

    public string? SuppliersMail { get; set; }

    public string? SuppliersTelephone1 { get; set; }

    public string? Suppliersweb { get; set; }
}
