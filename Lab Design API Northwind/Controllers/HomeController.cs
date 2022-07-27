using Microsoft.AspNetCore.Mvc;

namespace Lab_Design_API_Northwind.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
