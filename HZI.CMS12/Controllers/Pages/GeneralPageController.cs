using EPiServer.Web.Mvc;
using HZI.CMS12.Models.Pages;
using Microsoft.AspNetCore.Mvc;

namespace HZI.CMS12.Controllers.Pages
{
    public class GeneralPageController : PageController<GeneralPage>
    {
        public IActionResult Index(GeneralPage currentContent)
        {
            return View(currentContent);
        }
    }
}
