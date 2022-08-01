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
        public IActionResult Contact(ContactForm form)
        {
            if(ModelState.IsValid == false)
            {
                ViewBag.error = "مشکلی دارد ";
                return View(form);
            }
            ViewBag.success = "با موفقیت ارسال شد ";
            return View();
        } 




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() 
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}