using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbBank
{
    public int BankId { get; set; }

    public bool? BankIsActive { get; set; }

    public string? BankName { get; set; }

    public string? BankSubeName { get; set; }

    public int? BankSubeCode { get; set; }

    public string? BankHesapType { get; set; }

    public string? BankHesapName { get; set; }

    public int? BankHesapNo { get; set; }

    public string? BankHesapIban { get; set; }
}
