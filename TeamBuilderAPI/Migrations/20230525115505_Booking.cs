using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TeamBuilderAPI.Migrations
{
    /// <inheritdoc />
    public partial class Booking : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EventCentres",
                keyColumn: "Id",
                keyValue: new Guid("3db96146-a725-41e3-8128-519e59414ddc"));

            migrationBuilder.DeleteData(
                table: "EventCentres",
                keyColumn: "Id",
                keyValue: new Guid("8d5db5a4-0732-4c01-87df-40fb5771e386"));

            migrationBuilder.DeleteData(
                table: "EventCentres",
                keyColumn: "Id",
                keyValue: new Guid("e327817c-8c34-4695-958e-4853e826b173"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("680fe013-5fd7-44eb-b924-2bc26c828f7b"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("6c46abd2-f8aa-4bc4-8afb-e8d6cf0525b2"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("bcc25502-c3f5-429d-aed7-9646579b7135"));

            migrationBuilder.AddColumn<DateTime>(
                name: "BookRestaurant",
                table: "Restaurants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "BookActivity",
                table: "EventCentres",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "BookRestaurant",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "BookActivity",
                table: "EventCentres");

            migrationBuilder.InsertData(
                table: "EventCentres",
                columns: new[] { "Id", "Address", "Capacity", "CentreName", "CreatedBy", "LastModifiedBy", "LastModifiedOn" },
                values: new object[,]
                {
                    { new Guid("3db96146-a725-41e3-8128-519e59414ddc"), "Unnamed Road, Volkovo", 50, "Carting Sky Cart", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8d5db5a4-0732-4c01-87df-40fb5771e386"), "Justinijan Prvi, Drachevo", 50, "Paintball Arena BEST", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e327817c-8c34-4695-958e-4853e826b173"), "Planinarski Dom Matka Matka, 1060", 20, "Kayak Rental - Matka", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Capacity", "CreatedBy", "LastModifiedBy", "LastModifiedOn", "Location", "RestaurantName" },
                values: new object[,]
                {
                    { new Guid("680fe013-5fd7-44eb-b924-2bc26c828f7b"), 60, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Teodosij Gologanov 79", "Gostilnica Dukat" },
                    { new Guid("6c46abd2-f8aa-4bc4-8afb-e8d6cf0525b2"), 90, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Zagrebska 31, Skopje", "Dva Elena" },
                    { new Guid("bcc25502-c3f5-429d-aed7-9646579b7135"), 60, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Teodosie Gologanov no.63, Skopje", "Makedonska Kuka" }
                });
        }
    }
}
