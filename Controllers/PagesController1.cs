using Microsoft.AspNetCore.Mvc;

namespace MultiShop.Controllers
{
    public class PagesController1 : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
