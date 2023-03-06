using System;
using System.Collections.Generic;

namespace cofinder.Models;

public partial class ProjectIndustry
{
    public int ProjectId { get; set; }

    public long IndustryEnumeration { get; set; }

    public int? Industry { get; set; }

    public virtual IndustriesList? IndustryNavigation { get; set; }

    public virtual Project Project { get; set; } = null!;
}
