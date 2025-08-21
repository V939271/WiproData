using Microsoft.AspNetCore.Mvc;

namespace MvcDemoCore.Controllers
{
    public class DemoController : Controller
    {
        public string Index()
        {
            return "Welcome to ASP.NET Core Web MVC...";
        }

        public string Rajesh()
        {
            return "Hi I am Rajesh from .NET Full Stack Batch...";
        }

        public string Greeting()
        {
            int hr = DateTime.Now.Hour;
            if (hr < 12)
            {
                return "Good Morning...";
            }
            if (hr >= 12 && hr < 16)
            {
                return "Good Afternoon...";
            }
            if (hr >= 16)
            {
                return "Good Evening...";
            }
            return "";
        }

        public string Datta()
        {
            return "Hi I am Dev Datta...";
        }
    }
}