using EPiServer.Web.Mvc;
using HZI.CMS12.Models.Pages;
using HZI.CMS12.Models.Pages.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HZI.CMS12.Controllers.Pages
{
    public abstract class BasePageController<T> : PageController<T> where T : AbstractContentPage
    {
        public IActionResult PageView(T model)
        {
            var viewModel = new PageViewModel<T>(model);
            return PageView(viewModel);
        }

        protected IActionResult PageView(PageViewModel<T> viewModel)
        {
            viewModel.PageTitle ??= string.IsNullOrEmpty(viewModel.Page.PageTitle) ? viewModel.Page.Name : viewModel.Page.PageTitle;
            return View($"~/Views/Pages/{typeof(T).Name}.cshtml", viewModel);

        }
    }
}
