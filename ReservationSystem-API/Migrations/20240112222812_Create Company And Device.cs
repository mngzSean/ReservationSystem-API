using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ReservationSystem_API.Migrations
{
    /// <inheritdoc />
    public partial class CreateCompanyAndDevice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "companies",
                columns: table => new
                {
                    idx = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    contact = table.Column<string>(type: "text", nullable: false),
                    mail = table.Column<string>(type: "text", nullable: false),
                    address = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_companies", x => x.idx);
                });

            migrationBuilder.CreateTable(
                name: "devices",
                columns: table => new
                {
                    idx = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    pid = table.Column<string>(type: "text", nullable: false),
                    label = table.Column<string>(type: "text", nullable: false),
                    type = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    sn = table.Column<string>(type: "text", nullable: false),
                    company_idx = table.Column<int>(type: "integer", nullable: false),
                    facility_idx = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_devices", x => x.idx);
                    table.ForeignKey(
                        name: "fk_devices_companies_company_idx",
                        column: x => x.company_idx,
                        principalTable: "companies",
                        principalColumn: "idx",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_devices_facilities_facility_idx",
                        column: x => x.facility_idx,
                        principalTable: "facilities",
                        principalColumn: "idx",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_devices_company_idx",
                table: "devices",
                column: "company_idx");

            migrationBuilder.CreateIndex(
                name: "ix_devices_facility_idx",
                table: "devices",
                column: "facility_idx");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "devices");

            migrationBuilder.DropTable(
                name: "companies");
        }
    }
}
