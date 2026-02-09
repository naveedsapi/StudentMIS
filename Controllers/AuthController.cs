using Microsoft.AspNetCore.Mvc;

namespace StudentMIS.Controllers
{
    public class AuthController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> logout()
        {
          

            return RedirectToAction("Index","Home");
        }

    }
}
