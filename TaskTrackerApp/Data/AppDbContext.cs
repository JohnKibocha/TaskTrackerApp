using Microsoft.EntityFrameworkCore;
using TaskTrackerApp.Models;

namespace TaskTrackerApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Models.Task> Tasks { get; set; }
        public DbSet<Status> Statuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Statuses
            modelBuilder.Entity<Status>().HasData(
                new Status { StatusId = 1, StatusName = "Not Started" },
                new Status { StatusId = 2, StatusName = "In Progress" },
                new Status { StatusId = 3, StatusName = "Completed" }
            );

            // Seed 5 Tasks
            modelBuilder.Entity<Models.Task>().HasData(
                new Models.Task
                {
                    TaskId = 1,
                    Title = "Set up project",
                    Description = "Initialize ASP.NET Core MVC project and configure EF Core",
                    DueDate = new DateTime(2025, 4, 1),
                    Priority = 1,
                    StatusId = 1,
                    DateCreated = new DateTime(2025, 3, 25, 10, 0, 0)
                },
                new Models.Task
                {
                    TaskId = 2,
                    Title = "Create models",
                    Description = "Define Task and Status models with relationships and validation",
                    DueDate = new DateTime(2025, 4, 2),
                    Priority = 2,
                    StatusId = 2,
                    DateCreated = new DateTime(2025, 3, 25, 10, 15, 0)
                },
                new Models.Task
                {
                    TaskId = 3,
                    Title = "Build task views",
                    Description = "Scaffold controller and Razor views for CRUD operations",
                    DueDate = new DateTime(2025, 4, 3),
                    Priority = 3,
                    StatusId = 2,
                    DateCreated = new DateTime(2025, 3, 25, 10, 30, 0)
                },
                new Models.Task
                {
                    TaskId = 4,
                    Title = "Seed default data",
                    Description = "Seed task statuses and initial tasks in OnModelCreating",
                    DueDate = new DateTime(2025, 4, 4),
                    Priority = 2,
                    StatusId = 3,
                    DateCreated = new DateTime(2025, 3, 25, 10, 45, 0)
                },
                new Models.Task
                {
                    TaskId = 5,
                    Title = "Test and submit",
                    Description = "Run the app, test all features, and prepare final ZIP submission",
                    DueDate = new DateTime(2025, 4, 5),
                    Priority = 1,
                    StatusId = 1,
                    DateCreated = new DateTime(2025, 3, 25, 11, 0, 0)
                }
            );
        }
    }
}