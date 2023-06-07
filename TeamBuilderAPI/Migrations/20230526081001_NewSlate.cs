using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TeamBuilderAPI.Migrations
{
    /// <inheritdoc />
    public partial class NewSlate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EventCentres",
                keyColumn: "Id",
                keyValue: new Guid("28537ed4-4366-4912-96d1-58f3fb0c0880"));

            migrationBuilder.DeleteData(
                table: "EventCentres",
                keyColumn: "Id",
                keyValue: new Guid("ac5c4d36-6c03-40f2-8c06-bb1fd7849561"));

            migrationBuilder.DeleteData(
                table: "EventCentres",
                keyColumn: "Id",
                keyValue: new Guid("e36c05b9-620d-436d-97a8-3cba26570062"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("2b5f361f-004b-4323-a1bb-15eb1cd40a97"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("bba44465-e237-43c7-8d51-8c818c1d2212"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("d7e0a2d9-b0f3-4d68-9a54-ffbc9d424aec"));

            migrationBuilder.InsertData(
                table: "EventCentres",
                columns: new[] { "Id", "Address", "BookActivity", "Capacity", "CentreName", "CreatedBy", "LastModifiedBy", "LastModifiedOn" },
                values: new object[,]
                {
                    { new Guid("623f0de0-8c81-4e7b-bc34-b460fe0a7c36"), "Unnamed Road, Volkovo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, "Carting Sky Cart", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a7f1d9a2-e91c-4190-b104-88e314c156ec"), "Planinarski Dom Matka Matka, 1060", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "Kayak Rental - Matka", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d8323d2b-71da-42b1-b6ae-777a93e2f941"), "Justinijan Prvi, Drachevo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, "Paintball Arena BEST", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "BookRestaurant", "Capacity", "CreatedBy", "LastModifiedBy", "LastModifiedOn", "Location", "RestaurantName" },
                values: new object[,]
                {
                    { new Guid("82cb741a-372b-494b-8678-898c13cbb6b7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 90, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Zagrebska 31, Skopje", "Dva Elena" },
                    { new Guid("ce9a189e-a4c5-48f8-ad21-86d1a3b58efd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Teodosij Gologanov 79", "Gostilnica Dukat" },
                    { new Guid("f979b8df-7748-4ad8-b576-55431a59edc1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Teodosie Gologanov no.63, Skopje", "Makedonska Kuka" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EventCentres",
                keyColumn: "Id",
                keyValue: new Guid("623f0de0-8c81-4e7b-bc34-b460fe0a7c36"));

            migrationBuilder.DeleteData(
                table: "EventCentres",
                keyColumn: "Id",
                keyValue: new Guid("a7f1d9a2-e91c-4190-b104-88e314c156ec"));

            migrationBuilder.DeleteData(
                table: "EventCentres",
                keyColumn: "Id",
                keyValue: new Guid("d8323d2b-71da-42b1-b6ae-777a93e2f941"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("82cb741a-372b-494b-8678-898c13cbb6b7"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("ce9a189e-a4c5-48f8-ad21-86d1a3b58efd"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("f979b8df-7748-4ad8-b576-55431a59edc1"));

            migrationBuilder.InsertData(
                table: "EventCentres",
                columns: new[] { "Id", "Address", "BookActivity", "Capacity", "CentreName", "CreatedBy", "LastModifiedBy", "LastModifiedOn" },
                values: new object[,]
                {
                    { new Guid("28537ed4-4366-4912-96d1-58f3fb0c0880"), "Justinijan Prvi, Drachevo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, "Paintball Arena BEST", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ac5c4d36-6c03-40f2-8c06-bb1fd7849561"), "Planinarski Dom Matka Matka, 1060", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "Kayak Rental - Matka", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e36c05b9-620d-436d-97a8-3cba26570062"), "Unnamed Road, Volkovo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, "Carting Sky Cart", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "BookRestaurant", "Capacity", "CreatedBy", "LastModifiedBy", "LastModifiedOn", "Location", "RestaurantName" },
                values: new object[,]
                {
                    { new Guid("2b5f361f-004b-4323-a1bb-15eb1cd40a97"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Teodosie Gologanov no.63, Skopje", "Makedonska Kuka" },
                    { new Guid("bba44465-e237-43c7-8d51-8c818c1d2212"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Teodosij Gologanov 79", "Gostilnica Dukat" },
                    { new Guid("d7e0a2d9-b0f3-4d68-9a54-ffbc9d424aec"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 90, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Zagrebska 31, Skopje", "Dva Elena" }
                });
        }
    }
}
