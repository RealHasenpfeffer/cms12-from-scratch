using EPiServer.Web.Mvc;
using HZI.CMS12.Models.Blocks;
using Microsoft.AspNetCore.Mvc;

namespace HZI.CMS12.Controllers.Blocks
{
    public class SectionMediaBlockController : BlockComponent<SectionMediaBlock>
    {
        protected override IViewComponentResult InvokeComponent(SectionMediaBlock currentContent)
        {
            return View("~/Views/SectionMediaBlock/Index.cshtml", currentContent);
        }
    }
}
