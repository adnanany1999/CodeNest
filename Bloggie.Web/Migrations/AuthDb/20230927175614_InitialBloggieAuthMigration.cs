using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bloggie.Web.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class InitialBloggieAuthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "472ba632-6133-44a1-b158-6c10bd7d850d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b6caa5a-8fe3-416b-8433-96d3bdabf6e3", "AQAAAAIAAYagAAAAENKMpQz6nT+eqmXmJuun/P5NRI1Dg1GrWw3IFK8Rr7O3EzOBPuCovktHg09lvMWVbQ==", "119c3493-7533-48c7-b1e2-34414a174f90" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "472ba632-6133-44a1-b158-6c10bd7d850d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02dcd5f7-a690-45e5-95d4-d2706865a55a", "AQAAAAIAAYagAAAAEAv/okdecnfYm+tdXFAarHPtq8vkpGhFZQD+B7E9GrxWzpWmeOoLPvoad1NUUX8s7A==", "22993975-2e15-4a4e-9476-37b5ca1adbea" });
        }
    }
}
