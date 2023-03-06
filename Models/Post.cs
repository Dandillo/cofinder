using System;
using System.Collections.Generic;

namespace cofinder.Models;

public partial class Post
{
    public int NewsId { get; set; }

    public string? Heading { get; set; }

    public string? Description { get; set; }

    public int? Likes { get; set; }

    public DateTime? Timestamp { get; set; }

    public int? Category { get; set; }

    public int? CreatedBy { get; set; }

    public virtual PostCategory? CategoryNavigation { get; set; }

    public virtual User? CreatedByNavigation { get; set; }
}
