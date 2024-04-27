using Microsoft.AspNetCore.Mvc;

namespace MVCTask.Controllers
{
    public class LoginAndSignupController : Controller
    {
       
        public IActionResult Signup()
        {
            return View();
        }
    }
}
