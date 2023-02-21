using Microsoft.AspNetCore.Mvc;

namespace EnocaProject.Api.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
