using Microsoft.AspNetCore.Mvc;

namespace StudentMIS.Controllers
{
    public class BranchesController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult ViewBranch()
        {
            return View();
        }

    }
}
