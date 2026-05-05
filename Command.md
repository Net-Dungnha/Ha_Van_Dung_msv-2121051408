# Tao project
dotnet new mvc -o MyProject

# Cai Package
dotnet add package Microsoft.EntityFrameworkCore --version 9.0.0
dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 9.0.0
dotnet add package Microsoft.EntityFrameworkCore.Design --version 9.0.0
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 9.0.0
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 9.0.0


# Tao model : Models/Student.cs
vd: C#
# namespace MyProject.Models
# {
#     public class Student
#     {
#         public int Id { get; set; }

#         public string StudentCode { get; set; } = string.Empty;

#         public string FullName { get; set; } = string.Empty;
#     }
# }

# Tao DbContext : Data/AppDbContext.cs
vd: C#
# using Microsoft.EntityFrameworkCore;
# using MyProject.Models;

# Cau hinh Db
# file: appsettings.json
{
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=student.db"
  }
}
# Cau hinh program.cs
# Them 
using Microsoft.EntityFrameworkCore;
using MyProject.Data;
# them service
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

# Build Project
dotnet build
# phai thay : Build succeeded

# tao Migration
dotnet ef migrations add InitialCreate
# tao database
dotnet ef database update

# Generate CRUD tu dong
# cai code generator
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 9.0.0

# Chay 
dotnet aspnet-codegenerator controller \
-name StudentsController \
-m Student \
-dc AppDbContext \
--relativeFolderPath Controllers \
--useDefaultLayout \
--referenceScriptLibraries

dotnet aspnet-codegenerator controller -name StudentsController -m Student -dc AppDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries

# Ket qua khoi tao
Controllers
    StudentsController.cs

Views
    Students
        Create.cshtml
        Edit.cshtml
        Delete.cshtml
        Details.cshtml
        Index.cshtml
