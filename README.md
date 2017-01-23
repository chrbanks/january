Sample app for ASP.NET Core MVC + Postgres database.

Setup:

You should have .NET Core installed.
Set ASPNETCORE_ENVIRONMENT variable to development.
Set up a Postgres user named 'january' with a password 'test' and give them CREATEDB permission.

Run the following commands in the project directory:

dotnet restore
dotnet ef database update -c DataContext
dotnet ef database update -c ApplicationDbContext
dotnet run

open your browser to http://localhost:5000
