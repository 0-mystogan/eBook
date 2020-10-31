using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Dal.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderController : Controller
    {
        public IOrderRepository _orderRepository { get; set; }
        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromBody] UserDto user)
        {
            var orders = await _orderRepository.GetOrders(user);
            return Ok(orders);
            
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] OrderDto order)
        {
            var orders = await _orderRepository.AddOrder(order);
            return Ok(orders);
        }
    }
}
