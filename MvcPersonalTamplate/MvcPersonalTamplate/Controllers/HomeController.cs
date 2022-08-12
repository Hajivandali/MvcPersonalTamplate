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
            new Service(1, "طراحی "),
            new Service(2, "ثبت"),
            new Service(3, "ارتباط"),
            new Service(4, "تماس"),
        };

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

        //[HttpPost]
        //public JsonResult Contact(IFormCollection form)
        //{
        //    var name = form["name"];
        //    return Json(Ok());
        //}

        [HttpPost]
        public IActionResult Contact(ContactForm model)
        {
            model.Services = new SelectList(_Services, dataValueField: "Id", dataTextField: "Name");
            //if(ModelState.IsValid == false)
            if (!ModelState.IsValid)
            {
                ViewBag.error = "اطلاعات وارد شده صحیح نیست. لطفا دوباره تلاش کنید";
                return View(model);
            }

            ModelState.Clear();

            model = new ContactForm
            {
                Services = new SelectList(_Services, dataValueField: "Id", dataTextField: "Name")
            };
            ViewBag.success = "پیغام شما با موفقیت ارسال شد. باتشکر";
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}