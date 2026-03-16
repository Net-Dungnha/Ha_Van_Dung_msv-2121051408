Cấu trúc dự án .NET MVC
Khi bạn tạo project bằng lệnh dotnet mvc 
dự án sẽ có cấu trúc như sau:
 ProjectName
│
├── Controllers
├── Models
├── Views
├── wwwroot
├── appsettings.json
├── Program.cs
└── ProjectName.csproj
Trong đó:
<!-- 
Controllers: Chứa các controller xử lý logic của ứng dụng. Controller nhận request từ người dùng , xử lý logic và trả về view hoặc dữ liệu -->
VD: C#
 public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}

<!-- Models: Chứa các lớp mô hình dữ liệu. Đây là nơi bạn định nghĩa các lớp đại diện cho dữ liệu của ứng dụng. -->
VD: C#
 public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}
<!-- Views: Chứa các file view (thường là file .cshtml) dùng để hiển thị giao diện người dùng. Các view này sẽ được controller trả về để hiển thị dữ liệu. -->
VD: Views
 ├── Home
 │   └── Index.cshtml

<!-- wwwroot: Chứa các file tĩnh như CSS, JavaScript, hình ảnh,... Đây là nơi bạn đặt các tài nguyên mà trình duyệt có thể truy cập trực tiếp. -->
VD: wwwroot
├── css
│   └── site.css
├── js
│   └── site.js
├── images
│   └── logo.png
appsettings.json: Chứa các cấu hình của ứng dụng như kết nối cơ sở dữ liệu, cài đặt ứng dụng,...
<!-- Program: Là file khởi động ứng dụng -->
VD:
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

<!-- file appsettings.json: là file cấu hình ứng dụng -->
VD:
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=MyDatabase;Trusted_Connection=True;"
  }
}

<!-- Định tuyến (Route) trong .NET MVC -->
Route là cơ chế ánh xạ URL -> Controller -> Action
VD: /Home/Index
Trong đó: APS.NET MVC sẽ gọi
Controller: HomeController -> Index()
Route mặc định
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

ý nghĩa: {controller} → tên controller
{action} → phương thức
{id?} → tham số (optional)

<!-- Namespace trong C# -->
Namespace là một cách để tổ chức mã nguồn và tránh xung đột tên giữa các lớp, phương thức, biến,...
VD:
namespace Prac_Lesson003.Controller
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
Trong ví dụ trên, HomeController được đặt trong namespace Prac_Lesson003.Controller. Điều này giúp tổ chức mã nguồn và tránh xung đột tên nếu có nhiều lớp cùng tên trong dự án. Để sử dụng HomeController trong một file khác, bạn cần sử dụng câu lệnh using để nhập namespace đó: