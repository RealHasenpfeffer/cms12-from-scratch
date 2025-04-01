using HZI.CMS12.Models.Pages;
using HZI.CMS12.Models.Pages.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HZI.CMS12.Controllers.Pages
{
    public class HomepageController : BasePageController<Homepage>
    {
        private readonly IContentLoader contentLoader;

        public HomepageController(IContentLoader contentLoader)
        {
            this.contentLoader = contentLoader;
        }

        public IActionResult Index(Homepage currentContent) 
        {
            var viewModel = new HomepageViewModel(currentContent)
            {
                RelatedContent = contentLoader.GetChildren<AbstractContentPage>(currentContent.ContentLink)
            };
            return PageView(viewModel);
        }
    }
}
