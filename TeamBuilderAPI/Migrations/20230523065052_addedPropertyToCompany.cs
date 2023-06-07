using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TeamBuilderAPI.Migrations
{
    /// <inheritdoc />
    public partial class addedPropertyToCompany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EventCentres",
                keyColumn: "Id",
                keyValue: new Guid("276e78a1-ea7f-4a5f-b7f2-dab543a8fad1"));

            migrationBuilder.DeleteData(
                table: "EventCentres",
                keyColumn: "Id",
                keyValue: new Guid("a7040199-a06f-4e46-ab2b-7142680bf19b"));

            migrationBuilder.DeleteData(
                table: "EventCentres",
                keyColumn: "Id",
                keyValue: new Guid("c392678b-d32a-48d6-b951-830f9e4ff6e8"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("7350bfc2-aaf8-469e-a0c7-001d5c119fdc"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("9b9da9cc-2b44-4786-b28b-48fc2098552b"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("fc19be1d-0918-4239-be94-a622fd273eed"));

            migrationBuilder.InsertData(
                table: "EventCentres",
                columns: new[] { "Id", "Address", "Capacity", "CentreName", "CreatedBy", "LastModifiedBy", "LastModifiedOn" },
                values: new object[,]
                {
                    { new Guid("4fd894e1-d0a8-4905-b2cf-0f0504360a04"), "Justinijan Prvi, Drachevo", 50, "Paintball Arena BEST", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("56f3fa13-26ac-4e15-aee5-e65905e8b9c0"), "Unnamed Road, Volkovo", 50, "Carting Sky Cart", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9dcaeb34-3a49-46b4-84e4-481466061340"), "Planinarski Dom Matka Matka, 1060", 20, "Kayak Rental - Matka", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Capacity", "CreatedBy", "LastModifiedBy", "LastModifiedOn", "Location", "RestaurantName" },
                values: new object[,]
                {
                    { new Guid("022ed881-e38f-4e5c-95d0-ff3ea260c8fa"), 60, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Teodosie Gologanov no.63, Skopje", "Makedonska Kuka" },
                    { new Guid("8345aacf-2d4d-4f86-80b4-a88a524eff6d"), 90, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Zagrebska 31, Skopje", "Dva Elena" },
                    { new Guid("bdfdfe73-bccd-4876-88ad-96aac537f598"), 60, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Teodosij Gologanov 79", "Gostilnica Dukat" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EventCentres",
                keyColumn: "Id",
                keyValue: new Guid("4fd894e1-d0a8-4905-b2cf-0f0504360a04"));

            migrationBuilder.DeleteData(
                table: "EventCentres",
                keyColumn: "Id",
                keyValue: new Guid("56f3fa13-26ac-4e15-aee5-e65905e8b9c0"));

            migrationBuilder.DeleteData(
                table: "EventCentres",
                keyColumn: "Id",
                keyValue: new Guid("9dcaeb34-3a49-46b4-84e4-481466061340"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("022ed881-e38f-4e5c-95d0-ff3ea260c8fa"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("8345aacf-2d4d-4f86-80b4-a88a524eff6d"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("bdfdfe73-bccd-4876-88ad-96aac537f598"));

            migrationBuilder.InsertData(
                table: "EventCentres",
                columns: new[] { "Id", "Address", "Capacity", "CentreName", "CreatedBy", "LastModifiedBy", "LastModifiedOn" },
                values: new object[,]
                {
                    { new Guid("276e78a1-ea7f-4a5f-b7f2-dab543a8fad1"), "Planinarski Dom Matka Matka, 1060", 20, "Kayak Rental - Matka", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a7040199-a06f-4e46-ab2b-7142680bf19b"), "Unnamed Road, Volkovo", 50, "Carting Sky Cart", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c392678b-d32a-48d6-b951-830f9e4ff6e8"), "Justinijan Prvi, Drachevo", 50, "Paintball Arena BEST", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Capacity", "CreatedBy", "LastModifiedBy", "LastModifiedOn", "Location", "RestaurantName" },
                values: new object[,]
                {
                    { new Guid("7350bfc2-aaf8-469e-a0c7-001d5c119fdc"), 90, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Zagrebska 31, Skopje", "Dva Elena" },
                    { new Guid("9b9da9cc-2b44-4786-b28b-48fc2098552b"), 60, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Teodosie Gologanov no.63, Skopje", "Makedonska Kuka" },
                    { new Guid("fc19be1d-0918-4239-be94-a622fd273eed"), 60, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Teodosij Gologanov 79", "Gostilnica Dukat" }
                });
        }
    }
}
