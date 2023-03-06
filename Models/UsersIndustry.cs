using System;
using System.Collections.Generic;

namespace cofinder.Models;

public partial class UsersIndustry
{
    public int UserId { get; set; }

    public long IndustryEnumeration { get; set; }

    public int? Industry { get; set; }

    public virtual IndustriesList? IndustryNavigation { get; set; }

    public virtual User User { get; set; } = null!;
}
