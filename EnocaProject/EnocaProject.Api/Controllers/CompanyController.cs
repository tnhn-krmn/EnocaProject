using Microsoft.AspNetCore.Mvc;

namespace EnocaProject.Api.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
