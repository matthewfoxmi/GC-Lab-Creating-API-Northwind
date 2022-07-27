using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Lab_Design_API_Northwind.Models;

namespace Lab_Design_API_Northwind.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        public NorthWindContext northWindContext = new NorthWindContext();


        [HttpGet("GetByOrderId")]

        public Order GetByOrderId(int id)
        {
            return northWindContext.Orders.FirstOrDefault(o => o.OrderId == id);
        }

        [HttpGet("GetByCity")]

        public Order GetByCity(string city)
        {
            return northWindContext.Orders.FirstOrDefault(o => o.ShipCity == city);

        }
    }
}
