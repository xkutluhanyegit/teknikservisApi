using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbLanguage
{
    public int LangId { get; set; }

    public string? LangName { get; set; }

    public string? LangSembol { get; set; }

    public string? LangWebLogo { get; set; }
}
