using EnocaProject.Business.Abstract;
using EnocaProject.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EnocaProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("OrderList")]
        public IActionResult Get()
        {
            var result = _orderService.GetList();
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpPost("OrderAdd")]
        public IActionResult Add(Order order)
        {
            var result = _orderService.Add(order);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpPost("OrderUpdate")]
        public IActionResult Update(Order order)
        {
            var result = _orderService.Update(order);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpPost("OrderDelete")]
        public IActionResult Delete(Order order)
        {
            var result = _orderService.Delete(order);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
    }
}
