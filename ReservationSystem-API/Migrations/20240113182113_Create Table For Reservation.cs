using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ReservationSystem_API.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableForReservation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "reservations_histories",
                columns: table => new
                {
                    idx = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    facility_idx = table.Column<int>(type: "integer", nullable: false),
                    space_idx = table.Column<int>(type: "integer", nullable: false),
                    user_idx = table.Column<int>(type: "integer", nullable: false),
                    device_idx = table.Column<int>(type: "integer", nullable: false),
                    created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    started = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ended = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    canceled = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_reservations_histories", x => x.idx);
                    table.ForeignKey(
                        name: "fk_reservations_histories_devices_device_idx",
                        column: x => x.device_idx,
                        principalTable: "devices",
                        principalColumn: "idx",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_reservations_histories_facilities_facility_idx",
                        column: x => x.facility_idx,
                        principalTable: "facilities",
                        principalColumn: "idx",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_reservations_histories_spaces_space_idx",
                        column: x => x.space_idx,
                        principalTable: "spaces",
                        principalColumn: "idx",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_reservations_histories_users_user_idx",
                        column: x => x.user_idx,
                        principalTable: "users",
                        principalColumn: "idx",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "reservations_alives",
                columns: table => new
                {
                    idx = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    rh_idx = table.Column<int>(type: "integer", nullable: false),
                    facility_idx = table.Column<int>(type: "integer", nullable: false),
                    space_idx = table.Column<int>(type: "integer", nullable: false),
                    user_idx = table.Column<int>(type: "integer", nullable: false),
                    device_idx = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_reservations_alives", x => x.idx);
                    table.ForeignKey(
                        name: "fk_reservations_alives_devices_device_idx",
                        column: x => x.device_idx,
                        principalTable: "devices",
                        principalColumn: "idx",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_reservations_alives_facilities_facility_idx",
                        column: x => x.facility_idx,
                        principalTable: "facilities",
                        principalColumn: "idx",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_reservations_alives_reservations_histories_rh_idx",
                        column: x => x.rh_idx,
                        principalTable: "reservations_histories",
                        principalColumn: "idx",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_reservations_alives_spaces_space_idx",
                        column: x => x.space_idx,
                        principalTable: "spaces",
                        principalColumn: "idx",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_reservations_alives_users_user_idx",
                        column: x => x.user_idx,
                        principalTable: "users",
                        principalColumn: "idx",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_reservations_alives_device_idx",
                table: "reservations_alives",
                column: "device_idx");

            migrationBuilder.CreateIndex(
                name: "ix_reservations_alives_facility_idx",
                table: "reservations_alives",
                column: "facility_idx");

            migrationBuilder.CreateIndex(
                name: "ix_reservations_alives_rh_idx",
                table: "reservations_alives",
                column: "rh_idx");

            migrationBuilder.CreateIndex(
                name: "ix_reservations_alives_space_idx",
                table: "reservations_alives",
                column: "space_idx");

            migrationBuilder.CreateIndex(
                name: "ix_reservations_alives_user_idx",
                table: "reservations_alives",
                column: "user_idx");

            migrationBuilder.CreateIndex(
                name: "ix_reservations_histories_device_idx",
                table: "reservations_histories",
                column: "device_idx");

            migrationBuilder.CreateIndex(
                name: "ix_reservations_histories_facility_idx",
                table: "reservations_histories",
                column: "facility_idx");

            migrationBuilder.CreateIndex(
                name: "ix_reservations_histories_space_idx",
                table: "reservations_histories",
                column: "space_idx");

            migrationBuilder.CreateIndex(
                name: "ix_reservations_histories_user_idx",
                table: "reservations_histories",
                column: "user_idx");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "reservations_alives");

            migrationBuilder.DropTable(
                name: "reservations_histories");
        }
    }
}
