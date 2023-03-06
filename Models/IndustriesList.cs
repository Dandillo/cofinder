using System;
using System.Collections.Generic;

namespace cofinder.Models;

public partial class IndustriesList
{
    public int IndustryId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<ProjectIndustry> ProjectIndustries { get; } = new List<ProjectIndustry>();

    public virtual ICollection<UsersIndustry> UsersIndustries { get; } = new List<UsersIndustry>();
}
