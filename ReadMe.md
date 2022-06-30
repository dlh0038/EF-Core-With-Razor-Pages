Following tutorial on: https://docs.microsoft.com/en-us/aspnet/core/data/ef-rp/intro?view=aspnetcore-6.0&tabs=visual-studio-code

Completed app available at: https://github.com/dotnet/AspNetCore.Docs/tree/main/aspnetcore/data/ef-rp/intro/samples/cu60

A series of code first approach tutorials that show how to use Entity Framework (EF) Core in an ASP.NET Core Razor Pages app. The tutorials build a web site for a fictional Contoso University. The site includes functionality such as student admission, course creation, and instructor assignments. 

# Tutorial 1 of 8
    dotnet new webapp -o ContosoUniversity
    created student, enrollment and course entity
    dotnet add package Microsoft.EntityFrameworkCore.SQLite
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer
    dotnet add package Microsoft.EntityFrameworkCore.Design
    dotnet add package Microsoft.EntityFrameworkCore.Tools
    dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
    dotnet add package Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore
    scaffold using dotnet aspnet-codegenerator razorpage -m Student -dc ContosoUniversity.Data.SchoolContext -udl -outDir Pages\Students --referenceScriptLibraries -sqlite

# Tutorial 2 of 8
    display enrollments per student

# Tutorial 3 of 8
    replaced code in Index.cshtml and Index.cshtml.cs to enable sorting by lastname and enrollment date
    updated code in Index.cshtml and Index.cshtml.cs to search by last and first name
    created pagination to show 3 students at a time
    created grouping on About page to list number of students registered by date

# Tutorial 4 of 8
    removed context.Database.EnsureCreated(); from Program.cs
    created initial DB migration

# Tutorial 5 of 8
    Updated and created new entities based on the data model illustration.
    NOTE: the Instructor and Course entities have a many-to-many relationship using a pure join table (PJT).
    Updated DBContext
    since using SQLite, had to drop and reseed db
        dotnet ef database drop --force
        dotnet ef migrations add InitialCreate
        dotnet ef database update

# Tutorial 6 of 8
    scaffolded new entities
    dotnet aspnet-codegenerator razorpage -m Course -dc SchoolContext -udl -outDir Pages\Courses --referenceScriptLibraries