using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TeamBuilderAPI.Migrations
{
    /// <inheritdoc />
    public partial class CompanyAddedToTB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EventCentres",
                keyColumn: "Id",
                keyValue: new Guid("542d2ff7-bed0-4be3-9784-46e92bddcf25"));

            migrationBuilder.DeleteData(
                table: "EventCentres",
                keyColumn: "Id",
                keyValue: new Guid("c01f77fb-be97-4a4d-a143-4bd75ebd49b1"));

            migrationBuilder.DeleteData(
                table: "EventCentres",
                keyColumn: "Id",
                keyValue: new Guid("ff3033a7-11a5-4a1c-80ef-1db11f4fe749"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("091c2a08-abd3-45bd-9ec0-640d6f7d7cfe"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("10e764f9-d30e-4a4d-b0c1-bcfe1970a73a"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("c5c920cc-68de-4fee-a672-95614333077b"));

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

            migrationBuilder.CreateIndex(
                name: "IX_TeamBuildings_CompanyId",
                table: "TeamBuildings",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamBuildings_Companies_CompanyId",
                table: "TeamBuildings",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeamBuildings_Companies_CompanyId",
                table: "TeamBuildings");

            migrationBuilder.DropIndex(
                name: "IX_TeamBuildings_CompanyId",
                table: "TeamBuildings");

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
                    { new Guid("542d2ff7-bed0-4be3-9784-46e92bddcf25"), "Justinijan Prvi, Drachevo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, "Paintball Arena BEST", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c01f77fb-be97-4a4d-a143-4bd75ebd49b1"), "Planinarski Dom Matka Matka, 1060", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "Kayak Rental - Matka", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ff3033a7-11a5-4a1c-80ef-1db11f4fe749"), "Unnamed Road, Volkovo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, "Carting Sky Cart", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "BookRestaurant", "Capacity", "CreatedBy", "LastModifiedBy", "LastModifiedOn", "Location", "RestaurantName" },
                values: new object[,]
                {
                    { new Guid("091c2a08-abd3-45bd-9ec0-640d6f7d7cfe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Teodosij Gologanov 79", "Gostilnica Dukat" },
                    { new Guid("10e764f9-d30e-4a4d-b0c1-bcfe1970a73a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 90, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Zagrebska 31, Skopje", "Dva Elena" },
                    { new Guid("c5c920cc-68de-4fee-a672-95614333077b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Teodosie Gologanov no.63, Skopje", "Makedonska Kuka" }
                });
        }
    }
}
