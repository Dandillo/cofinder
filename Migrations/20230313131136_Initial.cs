using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace cofinder.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "industries_list",
                columns: table => new
                {
                    industry_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("industries_list_pkey", x => x.industry_id);
                });

            migrationBuilder.CreateTable(
                name: "post_categories",
                columns: table => new
                {
                    post_category_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("post_categories_pkey", x => x.post_category_id);
                });

            migrationBuilder.CreateTable(
                name: "projects",
                columns: table => new
                {
                    project_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    project_logo = table.Column<string>(type: "text", nullable: true),
                    industry = table.Column<int>(type: "integer", nullable: true),
                    main_idea = table.Column<string>(type: "text", nullable: true),
                    need_spec = table.Column<int>(type: "integer", nullable: true),
                    descr = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("projects_pkey", x => x.project_id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    first_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    last_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    second_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    work_experience = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    cases = table.Column<string>(type: "text", nullable: true),
                    pic_url = table.Column<string>(type: "text", nullable: true),
                    industry = table.Column<int>(type: "integer", nullable: true),
                    pswrd = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("user_id_pkey", x => x.user_id);
                });

            migrationBuilder.CreateTable(
                name: "project_industries",
                columns: table => new
                {
                    project_id = table.Column<int>(type: "integer", nullable: false),
                    industry_enumeration = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    industry = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("project_industries_pkey", x => new { x.project_id, x.industry_enumeration });
                    table.ForeignKey(
                        name: "project_industries_industry_fkey",
                        column: x => x.industry,
                        principalTable: "industries_list",
                        principalColumn: "industry_id");
                    table.ForeignKey(
                        name: "project_industries_project_id_fkey",
                        column: x => x.project_id,
                        principalTable: "projects",
                        principalColumn: "project_id");
                });

            migrationBuilder.CreateTable(
                name: "post",
                columns: table => new
                {
                    news_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    heading = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    likes = table.Column<int>(type: "integer", nullable: true),
                    timestamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    category = table.Column<int>(type: "integer", nullable: true),
                    created_by = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("news_pkey", x => x.news_id);
                    table.ForeignKey(
                        name: "post_category_fkey",
                        column: x => x.category,
                        principalTable: "post_categories",
                        principalColumn: "post_category_id");
                    table.ForeignKey(
                        name: "post_created_by_fkey",
                        column: x => x.created_by,
                        principalTable: "users",
                        principalColumn: "user_id");
                });

            migrationBuilder.CreateTable(
                name: "users_industries",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "integer", nullable: false),
                    industry_enumeration = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    industry = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("users_industries_pkey", x => new { x.user_id, x.industry_enumeration });
                    table.ForeignKey(
                        name: "users_industries_industry_fkey",
                        column: x => x.industry,
                        principalTable: "industries_list",
                        principalColumn: "industry_id");
                    table.ForeignKey(
                        name: "users_industries_user_id_fkey",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "user_id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_post_category",
                table: "post",
                column: "category");

            migrationBuilder.CreateIndex(
                name: "IX_post_created_by",
                table: "post",
                column: "created_by");

            migrationBuilder.CreateIndex(
                name: "IX_project_industries_industry",
                table: "project_industries",
                column: "industry");

            migrationBuilder.CreateIndex(
                name: "IX_users_industries_industry",
                table: "users_industries",
                column: "industry");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "post");

            migrationBuilder.DropTable(
                name: "project_industries");

            migrationBuilder.DropTable(
                name: "users_industries");

            migrationBuilder.DropTable(
                name: "post_categories");

            migrationBuilder.DropTable(
                name: "projects");

            migrationBuilder.DropTable(
                name: "industries_list");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
