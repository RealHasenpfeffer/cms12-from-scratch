using EPiServer.Web.Mvc;
using HZI.CMS12.Models.Pages;
using Microsoft.AspNetCore.Mvc;

namespace HZI.CMS12.Controllers.Pages
{
    public class HomepageController : PageController<Homepage>
    {
        public IActionResult Index(Homepage currentContent) 
        { 
            return View(currentContent);
        }
    }
}
