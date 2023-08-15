using Microsoft.AspNetCore.Mvc;

namespace WebAppTutorial2.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
