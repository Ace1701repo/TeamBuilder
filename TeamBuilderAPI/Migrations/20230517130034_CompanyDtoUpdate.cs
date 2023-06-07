using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TeamBuilderAPI.Migrations
{
    /// <inheritdoc />
    public partial class CompanyDtoUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EventCentres",
                keyColumn: "Id",
                keyValue: new Guid("26d7a8af-76fe-486f-ab63-f734ccd6704a"));

            migrationBuilder.DeleteData(
                table: "EventCentres",
                keyColumn: "Id",
                keyValue: new Guid("7fe395bc-08a4-4353-9ac3-243d55e4b790"));

            migrationBuilder.DeleteData(
                table: "EventCentres",
                keyColumn: "Id",
                keyValue: new Guid("80e11cbd-b921-4b57-a7d8-b8e8a07ac3cd"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("10b7a251-4438-4a7e-a7c9-4c9026b46074"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("1de4ba8f-186f-4566-838e-8698685ce63b"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("bf4bc77a-7175-46f7-ad31-e100834dffc3"));

            migrationBuilder.InsertData(
                table: "EventCentres",
                columns: new[] { "Id", "Address", "Capacity", "CentreName", "CreatedBy", "LastModifiedBy", "LastModifiedOn" },
                values: new object[,]
                {
                    { new Guid("da0c3e08-bce3-462d-a868-04f6949a0be8"), "Justinijan Prvi, Drachevo", 50, "Paintball Arena BEST", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e5bb25fc-84de-4b73-92c2-1656b9ed7842"), "Planinarski Dom Matka Matka, 1060", 20, "Vrelo Cave Boat Trips & Kayak Rentale", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e724b32d-1a47-468c-aedb-15bb7b8e1f21"), "Unnamed Road, Volkovo", 50, "Karting Skaj Kart", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Capacity", "CreatedBy", "LastModifiedBy", "LastModifiedOn", "Location", "RestaurantName" },
                values: new object[,]
                {
                    { new Guid("056aaaca-a6c1-4eb7-80c3-ec507b071253"), 90, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Zagrebska 31, Skopje", "Dva Elena" },
                    { new Guid("486671a3-6ed5-4065-9f25-ec8a84af0b29"), 60, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Teodosij Gologanov 79", "Gostilnica Dukat" },
                    { new Guid("fba2afe0-33bd-4328-bd17-1c9c45ecc375"), 60, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Teodosie Gologanov no.63, Skopje", "Makedonska Kuka" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EventCentres",
                keyColumn: "Id",
                keyValue: new Guid("da0c3e08-bce3-462d-a868-04f6949a0be8"));

            migrationBuilder.DeleteData(
                table: "EventCentres",
                keyColumn: "Id",
                keyValue: new Guid("e5bb25fc-84de-4b73-92c2-1656b9ed7842"));

            migrationBuilder.DeleteData(
                table: "EventCentres",
                keyColumn: "Id",
                keyValue: new Guid("e724b32d-1a47-468c-aedb-15bb7b8e1f21"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("056aaaca-a6c1-4eb7-80c3-ec507b071253"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("486671a3-6ed5-4065-9f25-ec8a84af0b29"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("fba2afe0-33bd-4328-bd17-1c9c45ecc375"));

            migrationBuilder.InsertData(
                table: "EventCentres",
                columns: new[] { "Id", "Address", "Capacity", "CentreName", "CreatedBy", "LastModifiedBy", "LastModifiedOn" },
                values: new object[,]
                {
                    { new Guid("26d7a8af-76fe-486f-ab63-f734ccd6704a"), "Justinijan Prvi, Drachevo", 50, "Paintball Arena BEST", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7fe395bc-08a4-4353-9ac3-243d55e4b790"), "Planinarski Dom Matka Matka, 1060", 20, "Vrelo Cave Boat Trips & Kayak Rentale", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("80e11cbd-b921-4b57-a7d8-b8e8a07ac3cd"), "Unnamed Road, Volkovo", 50, "Karting Skaj Kart", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Capacity", "CreatedBy", "LastModifiedBy", "LastModifiedOn", "Location", "RestaurantName" },
                values: new object[,]
                {
                    { new Guid("10b7a251-4438-4a7e-a7c9-4c9026b46074"), 90, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Zagrebska 31, Skopje", "Dva Elena" },
                    { new Guid("1de4ba8f-186f-4566-838e-8698685ce63b"), 60, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Teodosij Gologanov 79", "Gostilnica Dukat" },
                    { new Guid("bf4bc77a-7175-46f7-ad31-e100834dffc3"), 60, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Teodosie Gologanov no.63, Skopje", "Makedonska Kuka" }
                });
        }
    }
}
