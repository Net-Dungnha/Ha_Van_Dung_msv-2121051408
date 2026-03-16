<!-- Tìm hiểu khái niệm ViewBag -->
ViewBag là một đối tượng động (dynamic object) được sử dụng trong ASP.NET MVC để truyền dữ liệu từ controller đến view. Nó cho phép bạn lưu trữ và truy cập dữ liệu một cách linh hoạt mà không cần phải định nghĩa trước các thuộc tính cụ thể.
VD: C#
public IActionResult Index()
{
    ViewBag.Message = "Hello, World!";
    return View();
}
đặc điểm : Không cần khai báo dữ liệu , chỉ dùng controller -> view
và dữ liệu chỉ tồn tại trong request hiện tại.
<!-- Ví dụ gửi dữ liệu từ controller đến view bằng viewbag -->
VD: Controller
public IActionResult Hello(){
    ViewBag.Greeting = "Welcome to ASP.NET MVC!";
    return View();
}
View (Hello.cshtml)
<h1>@ViewBag.Greeting</h1>

Ví dụ thực tế : Nhập họ và tên trả về Xin chào + Họ Và tên
