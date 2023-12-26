using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbAssessment
{
    public int AssessId { get; set; }

    public string? AssessName { get; set; }

    public int? AssessRate { get; set; }
}
