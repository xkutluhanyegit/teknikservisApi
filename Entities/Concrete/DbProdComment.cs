using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbProdComment
{
    public int ProdCommentId { get; set; }

    public int? ProdId { get; set; }

    public int? ProdCommentIsActive { get; set; }

    public string? ProdCommentName { get; set; }

    public string? ProdCommentMail { get; set; }

    public string? ProdCommentTitle { get; set; }

    public string? ProdCommentText { get; set; }

    public int? ProdUserId { get; set; }

    public DateTime? Commentdate { get; set; }

    public string? Ipadresi { get; set; }

    public string? CommentTip { get; set; }
}
