using Action11.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Action11.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public ContentResult Content()
        {
            return Content("this is my list.");
        }
        public ActionResult Empty()
        {
            return new EmptyResult();
        }
        public ActionResult Redirect()
        {
            return RedirectToAction("Index", "Home", new {page=1});
        }
        public JsonResult json()
        {
            return Json("Data");
        }
        public string Date()
        {
            return DateTime.Now.ToString("T");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}