using System;
using System.Net;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace mealassistantdotnetmvc.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "meal_times",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_meal_times", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "meals_components",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    meal_id = table.Column<int>(nullable: true),
                    component_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_meals_components", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tags",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(type: "character varying", nullable: true),
                    user_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tags", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    email = table.Column<string>(type: "character varying", nullable: true),
                    created_at = table.Column<DateTime>(nullable: false),
                    updated_at = table.Column<DateTime>(nullable: false),
                    token = table.Column<string>(type: "character varying", nullable: true),
                    encrypted_password = table.Column<string>(type: "character varying", nullable: false, defaultValueSql: "''::character varying"),
                    reset_password_token = table.Column<string>(type: "character varying", nullable: true),
                    reset_password_sent_at = table.Column<DateTime>(nullable: true),
                    remember_created_at = table.Column<DateTime>(nullable: true),
                    sign_in_count = table.Column<int>(nullable: false),
                    current_sign_in_at = table.Column<DateTime>(nullable: true),
                    last_sign_in_at = table.Column<DateTime>(nullable: true),
                    current_sign_in_ip = table.Column<IPAddress>(nullable: true),
                    last_sign_in_ip = table.Column<IPAddress>(nullable: true),
                    provider = table.Column<string>(type: "character varying", nullable: true),
                    uid = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "meals",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(type: "character varying", nullable: true),
                    start_time = table.Column<DateTime>(nullable: true),
                    rating = table.Column<double>(nullable: true),
                    created_at = table.Column<DateTime>(nullable: false),
                    updated_at = table.Column<DateTime>(nullable: false),
                    user_id = table.Column<int>(nullable: true),
                    meal_time_id = table.Column<int>(nullable: true),
                    end_time = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_meals", x => x.id);
                    table.ForeignKey(
                        name: "fk_rails_f94c6134ac",
                        column: x => x.meal_time_id,
                        principalTable: "meal_times",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "components",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(type: "character varying", nullable: true),
                    source = table.Column<string>(type: "character varying", nullable: true),
                    comments = table.Column<string>(nullable: true),
                    type = table.Column<string>(type: "character varying", nullable: true),
                    user_id = table.Column<int>(nullable: true),
                    rating = table.Column<int>(nullable: true, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_components", x => x.id);
                    table.ForeignKey(
                        name: "fk_rails_624f40a895",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "feedbacks",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    user_id = table.Column<int>(nullable: true),
                    message = table.Column<string>(type: "character varying", nullable: true),
                    created_at = table.Column<DateTime>(nullable: false),
                    updated_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_feedbacks", x => x.id);
                    table.ForeignKey(
                        name: "fk_rails_c57bb6cf28",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "main_dishes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(type: "character varying", nullable: true),
                    source = table.Column<string>(type: "character varying", nullable: true),
                    comments = table.Column<string>(nullable: true),
                    meal_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_main_dishes", x => x.id);
                    table.ForeignKey(
                        name: "fk_rails_dd5aa3f07c",
                        column: x => x.meal_id,
                        principalTable: "meals",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "component_tags",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    component_id = table.Column<int>(nullable: true),
                    tag_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_component_tags", x => x.id);
                    table.ForeignKey(
                        name: "fk_rails_89f23cfd96",
                        column: x => x.component_id,
                        principalTable: "components",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_rails_e168d83886",
                        column: x => x.tag_id,
                        principalTable: "tags",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "index_component_tags_on_component_id",
                table: "component_tags",
                column: "component_id");

            migrationBuilder.CreateIndex(
                name: "index_component_tags_on_tag_id",
                table: "component_tags",
                column: "tag_id");

            migrationBuilder.CreateIndex(
                name: "index_components_on_user_id",
                table: "components",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "index_feedbacks_on_user_id",
                table: "feedbacks",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "index_main_dishes_on_meal_id",
                table: "main_dishes",
                column: "meal_id");

            migrationBuilder.CreateIndex(
                name: "index_meals_on_meal_time_id",
                table: "meals",
                column: "meal_time_id");

            migrationBuilder.CreateIndex(
                name: "index_meals_components_on_component_id",
                table: "meals_components",
                column: "component_id");

            migrationBuilder.CreateIndex(
                name: "index_meals_components_on_meal_id",
                table: "meals_components",
                column: "meal_id");

            migrationBuilder.CreateIndex(
                name: "index_tags_on_user_id",
                table: "tags",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "index_users_on_email",
                table: "users",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "index_users_on_reset_password_token",
                table: "users",
                column: "reset_password_token",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "component_tags");

            migrationBuilder.DropTable(
                name: "feedbacks");

            migrationBuilder.DropTable(
                name: "main_dishes");

            migrationBuilder.DropTable(
                name: "meals_components");

            migrationBuilder.DropTable(
                name: "components");

            migrationBuilder.DropTable(
                name: "tags");

            migrationBuilder.DropTable(
                name: "meals");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "meal_times");
        }
    }
}
