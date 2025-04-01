using HZI.CMS12.Models.Pages;
using Microsoft.AspNetCore.Mvc;

namespace HZI.CMS12.Controllers.Pages
{
    public class GeneralPageController : BasePageController<GeneralPage>
    {
        public IActionResult Index(GeneralPage currentContent)
        {
            return PageView(currentContent);
        }
    }
}
