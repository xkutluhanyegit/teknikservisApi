using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbFriend
{
    public int FriendId { get; set; }

    public string? FriendLangId { get; set; }

    public int? FriendPageId { get; set; }

    public int? FriendParentPageId { get; set; }

    public string? FriendType { get; set; }
}
