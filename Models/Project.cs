using System;
using System.Collections.Generic;

namespace cofinder.Models;

public partial class Project
{
    public int ProjectId { get; set; }

    public string? Name { get; set; }

    public string? ProjectLogo { get; set; }

    public int? Industry { get; set; }

    public string? MainIdea { get; set; }

    public int? NeedSpec { get; set; }

    public string? Descr { get; set; }

    public virtual ICollection<ProjectIndustry> ProjectIndustries { get; } = new List<ProjectIndustry>();
}
