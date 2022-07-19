using Microsoft.AspNetCore.Mvc;
using MvcPersonalTamplate.Models;
namespace MvcPersonalTamplate.ViewComponents
{
    public class ArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Articles>
            {
                new Articles(1,"تست شماره 1","پروژه تست شماره 1 ","blog-post-thumb-card-1.jpg"),
                new Articles(2,"تست شماره 2","پروژه تست شماره 1 ","blog-post-thumb-card-2.jpg"),
                new Articles(3,"تست شماره 3","پروژه تست شماره 1 ","blog-post-thumb-card-3.jpg"),
                new Articles(4,"تست شماره 4","پروژه تست شماره 1 ","blog-post-thumb-card-4.jpg"),

            };
            return View("_Articles",articles);
        }
    }
}
