using Microsoft.AspNetCore.Mvc;



namespace MvcPersonalTamplate.ViewComponents

{
    public class ProjectsViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }



    }
}
