using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ReservationSystem_API.Migrations
{
    /// <inheritdoc />
    public partial class CreateUserAndGroupAndSpace : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "groups",
                columns: table => new
                {
                    idx = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    facility_idx = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_groups", x => x.idx);
                    table.ForeignKey(
                        name: "fk_groups_facilities_facility_idx",
                        column: x => x.facility_idx,
                        principalTable: "facilities",
                        principalColumn: "idx",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "spaces",
                columns: table => new
                {
                    idx = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    comment = table.Column<string>(type: "text", nullable: false),
                    facility_idx = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_spaces", x => x.idx);
                    table.ForeignKey(
                        name: "fk_spaces_facilities_facility_idx",
                        column: x => x.facility_idx,
                        principalTable: "facilities",
                        principalColumn: "idx",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    idx = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    birth = table.Column<string>(type: "text", nullable: false),
                    sex = table.Column<string>(type: "text", nullable: false),
                    contact = table.Column<string>(type: "text", nullable: false),
                    valid = table.Column<int>(type: "integer", nullable: false),
                    join_date = table.Column<DateOnly>(type: "date", nullable: false),
                    group_idx = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_users", x => x.idx);
                    table.ForeignKey(
                        name: "fk_users_groups_group_idx",
                        column: x => x.group_idx,
                        principalTable: "groups",
                        principalColumn: "idx",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_groups_facility_idx",
                table: "groups",
                column: "facility_idx");

            migrationBuilder.CreateIndex(
                name: "ix_spaces_facility_idx",
                table: "spaces",
                column: "facility_idx");

            migrationBuilder.CreateIndex(
                name: "ix_users_group_idx",
                table: "users",
                column: "group_idx");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "spaces");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "groups");
        }
    }
}
