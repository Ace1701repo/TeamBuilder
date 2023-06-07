using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TeamBuilderAPI.Migrations
{
    /// <inheritdoc />
    public partial class editedCompanies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("1d9f6373-6bf1-4437-8f9a-6d6a940c5d2b"), "Unnamed Road, Volkovo", 50, "Carting Sky Cart", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("53a0c965-2611-4d29-b121-1b6810d48f09"), "Justinijan Prvi, Drachevo", 50, "Paintball Arena BEST", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ca74fe18-8e31-4caf-b997-3ba8aced1ca5"), "Planinarski Dom Matka Matka, 1060", 20, "Kayak Rental - Matka", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Capacity", "CreatedBy", "LastModifiedBy", "LastModifiedOn", "Location", "RestaurantName" },
                values: new object[,]
                {
                    { new Guid("39d5c8d7-e06d-4547-930f-56bd8556a0d3"), 60, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Teodosie Gologanov no.63, Skopje", "Makedonska Kuka" },
                    { new Guid("845c830f-cfe5-4e21-92e3-0f990e977913"), 90, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Zagrebska 31, Skopje", "Dva Elena" },
                    { new Guid("b2f1f55a-6104-479f-b6b6-de4ac8fba74f"), 60, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Teodosij Gologanov 79", "Gostilnica Dukat" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EventCentres",
                keyColumn: "Id",
                keyValue: new Guid("1d9f6373-6bf1-4437-8f9a-6d6a940c5d2b"));

            migrationBuilder.DeleteData(
                table: "EventCentres",
                keyColumn: "Id",
                keyValue: new Guid("53a0c965-2611-4d29-b121-1b6810d48f09"));

            migrationBuilder.DeleteData(
                table: "EventCentres",
                keyColumn: "Id",
                keyValue: new Guid("ca74fe18-8e31-4caf-b997-3ba8aced1ca5"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("39d5c8d7-e06d-4547-930f-56bd8556a0d3"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("845c830f-cfe5-4e21-92e3-0f990e977913"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("b2f1f55a-6104-479f-b6b6-de4ac8fba74f"));

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
    }
}
