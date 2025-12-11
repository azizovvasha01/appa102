ASP.NET Core 8 MVC + EF Core sample.

Steps:
1. Run CompanyDB.sql in SQL Server to create the database.
2. Open FrontToBackSqlConnection.csproj in Visual Studio.
3. Open Package Manager Console and run:
   Add-Migration Initial
   Update-Database
4. Run the application. Default route is Students/Index.