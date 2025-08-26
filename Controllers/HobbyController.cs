using Microsoft.AspNetCore.Mvc;
namespace NguyenDinhCong.Controllers
{
    public class HobbyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
