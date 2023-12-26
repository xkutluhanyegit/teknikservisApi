using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbQuestion
{
    public int QuestionId { get; set; }

    public int? QuestionUserId { get; set; }

    public string? QuestionText { get; set; }

    public string? QuestionDate { get; set; }

    public string? QuestionResponse { get; set; }

    public int? QuestionIsActive { get; set; }

    public string? QuestionTitle { get; set; }
}
