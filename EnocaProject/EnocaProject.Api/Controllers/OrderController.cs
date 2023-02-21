using EnocaProject.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace EnocaProject.Api.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        public IActionResult Index()
        {
            return View();
        }
    }
}
