using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        IDbOrderService _dbOrderService;
        public OrdersController(IDbOrderService dbOrderService)
        {
            _dbOrderService = dbOrderService;
        }

        [HttpGet("GetOrders")]
        public IActionResult GetOrders()
        {
          var result = _dbOrderService.OrdersDTOGetAll();

          if (result.Success)
          {
                return Ok(result.Data);
          }

          return BadRequest(result.Message);
        }

    }
}