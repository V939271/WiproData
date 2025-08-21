using Microsoft.AspNetCore.Mvc;

namespace MvcDemoCore.Controllers
{
    public class DetailsController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Topic = "Dotnet Core Training...";
            ViewBag.Venue = "Online Training...";
            return View();
        }

        public ActionResult Module2()
        {
            ViewBag.Content = "Winforms, Entity Framework, WPF";
            return View();
        }

        public ActionResult Module3()
        {
            ViewBag.Content = "WCF, ASP.NET and MVC";
            return View();
        }

    }
}