using Microsoft.AspNetCore.Mvc;

namespace DevCard___Project.Controllers
{
    //attribute based routing has higher priority than convention based routing
    [Route("/shop")]
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
