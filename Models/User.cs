using System;
using System.Collections.Generic;

namespace cofinder.Models;

public partial class User
{
    public int UserId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? SecondName { get; set; }

    public string? WorkExperience { get; set; }

    public string? Description { get; set; }

    public string? Cases { get; set; }

    public string? PicUrl { get; set; }

    public int? Industry { get; set; }

    public string? Pswrd { get; set; }

    public virtual ICollection<Post> Posts { get; } = new List<Post>();

    public virtual ICollection<UsersIndustry> UsersIndustries { get; } = new List<UsersIndustry>();
}
