using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbPayment
{
    public int BankIsActive { get; set; }

    public int? KapiIsActive { get; set; }

    public int? CreditIsActive { get; set; }

    public string? KapidaOdemeContent { get; set; }

    public int PayId { get; set; }
}
