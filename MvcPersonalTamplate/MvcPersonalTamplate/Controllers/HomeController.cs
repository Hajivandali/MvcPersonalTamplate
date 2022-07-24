using Microsoft.AspNetCore.Mvc;
using MvcPersonalTamplate.Models;
using System.Diagnostics;

namespace MvcPersonalTamplate.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
        }


        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }


        [HttpPost]
        public JsonResult Contact(ContactForm form)
        {
            Console.WriteLine(form.ToString());
                  return Json(Ok());
        } 




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}