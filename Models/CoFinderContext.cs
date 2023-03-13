using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace cofinder.Models;

public partial class CoFinderContext : DbContext
{
    public CoFinderContext()
    {
    }

    public CoFinderContext(DbContextOptions<CoFinderContext> options)
        : base(options)
    {
    }

    public virtual DbSet<IndustriesList> IndustriesLists { get; set; }

    public virtual DbSet<Post> Posts { get; set; }

    public virtual DbSet<PostCategory> PostCategories { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<ProjectIndustry> ProjectIndustries { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UsersIndustry> UsersIndustries { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configuration.GetConnectionString("test");
            optionsBuilder.UseNpgsql(connectionString);
        }
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<IndustriesList>(entity =>
        {
            entity.HasKey(e => e.IndustryId).HasName("industries_list_pkey");

            entity.ToTable("industries_list");

            entity.Property(e => e.IndustryId).HasColumnName("industry_id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Post>(entity =>
        {
            entity.HasKey(e => e.NewsId).HasName("news_pkey");

            entity.ToTable("post");

            entity.Property(e => e.NewsId).HasColumnName("news_id");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Heading).HasColumnName("heading");
            entity.Property(e => e.Likes).HasColumnName("likes");
            entity.Property(e => e.Timestamp).HasColumnName("timestamp");

            entity.HasOne(d => d.CategoryNavigation).WithMany(p => p.Posts)
                .HasForeignKey(d => d.Category)
                .HasConstraintName("post_category_fkey");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.Posts)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("post_created_by_fkey");
        });

        modelBuilder.Entity<PostCategory>(entity =>
        {
            entity.HasKey(e => e.PostCategoryId).HasName("post_categories_pkey");

            entity.ToTable("post_categories");

            entity.Property(e => e.PostCategoryId).HasColumnName("post_category_id");
            entity.Property(e => e.Name)
                .HasMaxLength(40)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.HasKey(e => e.ProjectId).HasName("projects_pkey");

            entity.ToTable("projects");

            entity.Property(e => e.ProjectId).HasColumnName("project_id");
            entity.Property(e => e.Descr).HasColumnName("descr");
            entity.Property(e => e.Industry).HasColumnName("industry");
            entity.Property(e => e.MainIdea).HasColumnName("main_idea");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.NeedSpec).HasColumnName("need_spec");
            entity.Property(e => e.ProjectLogo).HasColumnName("project_logo");
        });

        modelBuilder.Entity<ProjectIndustry>(entity =>
        {
            entity.HasKey(e => new { e.ProjectId, e.IndustryEnumeration }).HasName("project_industries_pkey");

            entity.ToTable("project_industries");

            entity.Property(e => e.ProjectId).HasColumnName("project_id");
            entity.Property(e => e.IndustryEnumeration)
                .ValueGeneratedOnAdd()
                .HasColumnName("industry_enumeration");
            entity.Property(e => e.Industry).HasColumnName("industry");

            entity.HasOne(d => d.IndustryNavigation).WithMany(p => p.ProjectIndustries)
                .HasForeignKey(d => d.Industry)
                .HasConstraintName("project_industries_industry_fkey");

            entity.HasOne(d => d.Project).WithMany(p => p.ProjectIndustries)
                .HasForeignKey(d => d.ProjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("project_industries_project_id_fkey");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("user_id_pkey");

            entity.ToTable("users");

            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.Cases).HasColumnName("cases");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("first_name");
            entity.Property(e => e.Industry).HasColumnName("industry");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("last_name");
            entity.Property(e => e.PicUrl).HasColumnName("pic_url");
            entity.Property(e => e.Pswrd).HasColumnName("pswrd");
            entity.Property(e => e.SecondName)
                .HasMaxLength(50)
                .HasColumnName("second_name");
            entity.Property(e => e.WorkExperience).HasColumnName("work_experience");
        });

        modelBuilder.Entity<UsersIndustry>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.IndustryEnumeration }).HasName("users_industries_pkey");

            entity.ToTable("users_industries");

            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.IndustryEnumeration)
                .ValueGeneratedOnAdd()
                .HasColumnName("industry_enumeration");
            entity.Property(e => e.Industry).HasColumnName("industry");

            entity.HasOne(d => d.IndustryNavigation).WithMany(p => p.UsersIndustries)
                .HasForeignKey(d => d.Industry)
                .HasConstraintName("users_industries_industry_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.UsersIndustries)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("users_industries_user_id_fkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
