using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbAdminModule
{
    public int ModuleId { get; set; }

    public string? ModuleName { get; set; }

    public int? ModuleListId { get; set; }

    public int? ModuleIsActive { get; set; }

    public string? ModulePictureUrl { get; set; }

    public string? ModuleDescription { get; set; }

    public string? ModuleScriptUrl { get; set; }
}
