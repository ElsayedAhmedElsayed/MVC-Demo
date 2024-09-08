using Microsoft.AspNetCore.Mvc;

namespace MVC_Demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ContentResult result = new ContentResult();
            //result.Content = "Hello From Content Result";
            //return result;

            return Content("Hello From Content Result");
        }
        public string AboutUs()
        {
            return "This is Aboutus Action ";
        }
    }
}
