using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MvcPersonalTamplate.Models;
using System.Diagnostics;

namespace MvcPersonalTamplate.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Service> _Services = new List<Service>
        {
            new Service(id:1, name:"وب اپلیکیشن"),
            new Service(id:2, name:"طراحی UI | UX "),
            new Service(id:3, name:"خدمات Seo"),
            new Service(id:4, name:"خدمات برندینگ"),
        };
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
            var model = new ContactForm
            {
                Services = new SelectList(_Services, dataValueField: "Id", dataTextField: "Name")
            };
            return View(model);
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