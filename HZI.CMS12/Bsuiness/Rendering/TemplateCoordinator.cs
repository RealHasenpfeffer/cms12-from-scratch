using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;
using HZI.CMS12.Models.Blocks;
using HZI.CMS12.Models.Pages;

namespace HZI.CMS12.Bsuiness.Rendering
{
    [ServiceConfiguration]
    public class TemplateCoordinator : IViewTemplateModelRegistrator
    {
        public void Register(TemplateModelCollection viewTemplateModelRegistrator)
        {
            viewTemplateModelRegistrator.Add(typeof(SectionMediaBlock), new EPiServer.DataAbstraction.TemplateModel
            {
                Name = "SectionMediaBlock-Default",
                AvailableWithoutTag = true,
                TemplateTypeCategory = EPiServer.Framework.Web.TemplateTypeCategories.MvcPartialView,
                Path = "~/Views/SectionMediaBlock/Index.cshtml"
            });

            viewTemplateModelRegistrator.Add(typeof(LinkGridBlock), new EPiServer.DataAbstraction.TemplateModel
            {
                Name = "LinkGridBlock-Default",
                AvailableWithoutTag = true,
                TemplateTypeCategory = EPiServer.Framework.Web.TemplateTypeCategories.MvcPartialView,
                Path = "~/Views/LinkGridBlock/Index.cshtml"
            });

            viewTemplateModelRegistrator.Add(typeof(AbstractContentPage), new EPiServer.DataAbstraction.TemplateModel
            {
                Name = "AbstractContentPage-LinkGrid",
                AvailableWithoutTag = false,
                Tags = ["LinkGrid"],
                Inherit = true,
                TemplateTypeCategory = EPiServer.Framework.Web.TemplateTypeCategories.MvcPartialView,
                Path = "~/Views/AbstractContentPage/LinkGrid.cshtml"
            });
        }
    }
}
