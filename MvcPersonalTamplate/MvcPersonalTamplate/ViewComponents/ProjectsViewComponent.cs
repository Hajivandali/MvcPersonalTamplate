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
                new Project(1,"taxi","description taxi app","project-1.jpg","HajivandAli"),
                new Project(2,"modirit","description modirit app","project-2.jpg","HajivandAli"),
                new Project(3,"foodapp","description foodapp app","project-3.jpg","HajivandAli"),
                new Project(4,"lunch","description lunch app","project-4.jpg","HajivandAli"),


            };
                return View("_Projects", projects);
        }



    }

}