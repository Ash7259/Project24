using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UserPurchaseHistories",
                columns: new[] { "Id", "Car", "CreatedBy", "CustomerId", "DateCreated", "DateUpdated", "PurchaseId", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Toyota", null, 1, new DateTime(2024, 1, 8, 0, 10, 4, 236, DateTimeKind.Local).AddTicks(7045), new DateTime(2024, 1, 8, 0, 10, 4, 236, DateTimeKind.Local).AddTicks(7058), 1, null },
                    { 2, "Nissan", null, 1, new DateTime(2024, 1, 8, 0, 10, 4, 236, DateTimeKind.Local).AddTicks(7062), new DateTime(2024, 1, 8, 0, 10, 4, 236, DateTimeKind.Local).AddTicks(7063), 2, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserPurchaseHistories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserPurchaseHistories",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
