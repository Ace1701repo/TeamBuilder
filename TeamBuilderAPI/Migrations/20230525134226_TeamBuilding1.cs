using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TeamBuilderAPI.Migrations
{
    /// <inheritdoc />
    public partial class TeamBuilding1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EventCentres",
                keyColumn: "Id",
                keyValue: new Guid("39f9433f-14d0-445b-969a-4f05269ec648"));

            migrationBuilder.DeleteData(
                table: "EventCentres",
                keyColumn: "Id",
                keyValue: new Guid("81ce3424-c213-4e10-b5ed-7a72ec8ec03e"));

            migrationBuilder.DeleteData(
                table: "EventCentres",
                keyColumn: "Id",
                keyValue: new Guid("db7c6efc-9c51-4735-9190-53b67e38c8fa"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("06aec49c-15e2-4a9b-b426-a437ece2984c"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("9917b0a1-f642-4bdc-9cd2-4eb87345fb45"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("ae37a053-344f-49c2-a4a6-c8ed71ad8f10"));

            migrationBuilder.InsertData(
                table: "EventCentres",
                columns: new[] { "Id", "Address", "BookActivity", "Capacity", "CentreName", "CreatedBy", "LastModifiedBy", "LastModifiedOn" },
                values: new object[,]
                {
                    { new Guid("0db9b179-f4db-4e2f-8eb8-1716cf955f9a"), "Planinarski Dom Matka Matka, 1060", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "Kayak Rental - Matka", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("15e679aa-3435-4683-8ee2-129f6c8ee66c"), "Justinijan Prvi, Drachevo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, "Paintball Arena BEST", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3ca889e7-adb0-488f-80e6-87eddb50548a"), "Unnamed Road, Volkovo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, "Carting Sky Cart", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "BookRestaurant", "Capacity", "CreatedBy", "LastModifiedBy", "LastModifiedOn", "Location", "RestaurantName" },
                values: new object[,]
                {
                    { new Guid("0cedb2ea-2d77-4506-bee5-6143a329265a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Teodosie Gologanov no.63, Skopje", "Makedonska Kuka" },
                    { new Guid("141f6781-8bf5-4d99-a7e5-afde2313aa53"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 90, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Zagrebska 31, Skopje", "Dva Elena" },
                    { new Guid("336dd3ac-825c-4c9f-83d7-4f2bce416f9c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Teodosij Gologanov 79", "Gostilnica Dukat" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EventCentres",
                keyColumn: "Id",
                keyValue: new Guid("0db9b179-f4db-4e2f-8eb8-1716cf955f9a"));

            migrationBuilder.DeleteData(
                table: "EventCentres",
                keyColumn: "Id",
                keyValue: new Guid("15e679aa-3435-4683-8ee2-129f6c8ee66c"));

            migrationBuilder.DeleteData(
                table: "EventCentres",
                keyColumn: "Id",
                keyValue: new Guid("3ca889e7-adb0-488f-80e6-87eddb50548a"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("0cedb2ea-2d77-4506-bee5-6143a329265a"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("141f6781-8bf5-4d99-a7e5-afde2313aa53"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("336dd3ac-825c-4c9f-83d7-4f2bce416f9c"));

            migrationBuilder.InsertData(
                table: "EventCentres",
                columns: new[] { "Id", "Address", "BookActivity", "Capacity", "CentreName", "CreatedBy", "LastModifiedBy", "LastModifiedOn" },
                values: new object[,]
                {
                    { new Guid("39f9433f-14d0-445b-969a-4f05269ec648"), "Unnamed Road, Volkovo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, "Carting Sky Cart", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("81ce3424-c213-4e10-b5ed-7a72ec8ec03e"), "Planinarski Dom Matka Matka, 1060", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "Kayak Rental - Matka", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("db7c6efc-9c51-4735-9190-53b67e38c8fa"), "Justinijan Prvi, Drachevo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, "Paintball Arena BEST", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "BookRestaurant", "Capacity", "CreatedBy", "LastModifiedBy", "LastModifiedOn", "Location", "RestaurantName" },
                values: new object[,]
                {
                    { new Guid("06aec49c-15e2-4a9b-b426-a437ece2984c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Teodosij Gologanov 79", "Gostilnica Dukat" },
                    { new Guid("9917b0a1-f642-4bdc-9cd2-4eb87345fb45"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Teodosie Gologanov no.63, Skopje", "Makedonska Kuka" },
                    { new Guid("ae37a053-344f-49c2-a4a6-c8ed71ad8f10"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 90, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Zagrebska 31, Skopje", "Dva Elena" }
                });
        }
    }
}
