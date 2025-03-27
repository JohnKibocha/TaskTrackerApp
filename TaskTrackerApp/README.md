Task Tracker App - ASP.NET Core MVC
===================================

Project Overview:
-----------------
This is a task tracking web application built using ASP.NET Core MVC with Entity Framework Core (Code First) and SQLite as the database engine.

It supports full CRUD operations for managing tasks, including:
- Viewing task list
- Adding a new task
- Editing and deleting tasks
- Viewing task details
- Task validation (required fields, future due date, and priority > 0)
- Status assignment (Not Started, In Progress, Completed)

---

How to Run:
-----------
1. Ensure .NET SDK (7 or higher) is installed.
2. Open the solution in Visual Studio.
3. Run the following command from the terminal in the project root:

   dotnet run

4. Open a browser and go to: https://localhost:[PORT]

---

Routing Info:
-------------
- `/` redirects to `/Tasks` (task list page)
- Tasks controller supports the following routes:
    - `/Tasks`
    - `/Tasks/Create`
    - `/Tasks/Edit/{id}`
    - `/Tasks/Delete/{id}`
    - `/Tasks/Details/{id}`

---

Database Info:
--------------
- Database: SQLite (`tasktracker.db` file)
- Created via Entity Framework Core migrations
- Includes seed data for Status options
- DateCreated is automatically set for each task

---

Notes:
------
- All forms include client- and server-side validation
- Cancel buttons return to the appropriate view (Index or Details)
- Bootstrap is used for styling
- Slug property is implemented but not used in routing

---

Tested in:
----------
- Visual Studio 2022
- .NET SDK 9.0 (compatible with 7.0+)

