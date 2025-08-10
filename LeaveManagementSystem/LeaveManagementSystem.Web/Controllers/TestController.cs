using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var nam = new Models.TestViewModel
            {
                Name = "Test Name 1"
            };
            return View(nam);
        }
    }
}
