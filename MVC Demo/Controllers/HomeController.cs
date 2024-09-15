using Microsoft.AspNetCore.Mvc;

namespace MVC_Demo.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index()
        //{
        //    //ContentResult result = new ContentResult();
        //    //result.Content = "Hello From Content Result";
        //    //return result;

        //    return Content("Hello From Content Result");
        //}
        //public string AboutUs()
        //{
        //    return "This is Aboutus Action ";
        //}

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
