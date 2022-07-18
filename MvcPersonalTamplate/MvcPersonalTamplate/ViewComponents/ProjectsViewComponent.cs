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
                new Project(1,"taxi","description taxi app","HajivandAli"),
                new Project(2,"modirit","description modirit app","HajivandAli"),
                new Project(3,"foodapp","description foodapp app","HajivandAli"),
                new Project(4,"lunch","description lunch app","HajivandAli"),


            };
                return View("_Projects", projects);
        }



    }

}