using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskTrackerApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedDefaultTasks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "TaskId", "DateCreated", "Description", "DueDate", "Priority", "StatusId", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), "Initialize ASP.NET Core MVC project and configure EF Core", new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "Set up project" },
                    { 2, new DateTime(2025, 3, 25, 10, 15, 0, 0, DateTimeKind.Unspecified), "Define Task and Status models with relationships and validation", new DateTime(2025, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "Create models" },
                    { 3, new DateTime(2025, 3, 25, 10, 30, 0, 0, DateTimeKind.Unspecified), "Scaffold controller and Razor views for CRUD operations", new DateTime(2025, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2, "Build task views" },
                    { 4, new DateTime(2025, 3, 25, 10, 45, 0, 0, DateTimeKind.Unspecified), "Seed task statuses and initial tasks in OnModelCreating", new DateTime(2025, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, "Seed default data" },
                    { 5, new DateTime(2025, 3, 25, 11, 0, 0, 0, DateTimeKind.Unspecified), "Run the app, test all features, and prepare final ZIP submission", new DateTime(2025, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "Test and submit" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 5);
        }
    }
}
