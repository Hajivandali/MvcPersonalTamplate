using Microsoft.AspNetCore.Mvc;
using MvcPersonalTamplate.Models;

namespace MvcPersonalTamplate.ViewComponents

{
    public class ProjectsViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>
            {
                new Project()
            };
                return View("_Projects");
        }



    }

}