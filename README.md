# Sample app for ASP.NET Core MVC + Postgres database.

### Setup:

1. You should have .NET Core installed.
2. Set ASPNETCORE_ENVIRONMENT variable to development.
3. Set up a Postgres user named 'january' with a password 'test' and give them CREATEDB permission.
4. Run the following commands in the project directory:
  1. dotnet restore
  2. dotnet ef database update -c DataContext
  3. dotnet ef database update -c ApplicationDbContext
  4. dotnet run
5. open your browser to http://localhost:5000

### Links:

1. [.NET Core](https://www.microsoft.com/net/core)
2. [Building projects with Yeoman](https://docs.microsoft.com/en-us/aspnet/core/client-side/yeoman)
3. [.NET Core CLI](https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dotnet)
4. [Postgres.app](https://postgresapp.com/)
5. [pgAdmin](https://www.pgadmin.org/)