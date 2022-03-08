using Microsoft.AspNetCore.Mvc;

namespace Annotations.Controllers
{
    public class DataController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
