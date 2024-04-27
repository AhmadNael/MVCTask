using Microsoft.AspNetCore.Mvc;

namespace MVCTask.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
