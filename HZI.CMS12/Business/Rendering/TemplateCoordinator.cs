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
            RegisterBlock<SectionMediaBlock>(viewTemplateModelRegistrator);
            RegisterBlock<LinkGridBlock>(viewTemplateModelRegistrator);

            RegisterPartial<AbstractContentPage>(viewTemplateModelRegistrator, "LinkGrid");
            RegisterPartial<AbstractContentPage>(viewTemplateModelRegistrator, "ArticlePartial");
        }

        private void RegisterBlock<T>(TemplateModelCollection viewTemplateModelRegistrator) where T : BlockData
        {
            viewTemplateModelRegistrator.Add(typeof(T), new TemplateModel
            {
                Name = $"{typeof(T).Name}-Default",
                AvailableWithoutTag = true,
                TemplateTypeCategory = EPiServer.Framework.Web.TemplateTypeCategories.MvcPartialView,
                Path = $"~/Views/Blocks/{typeof(T).Name}.cshtml"
            });
        }

        private void RegisterPartial<T>(TemplateModelCollection viewTemplateModelRegistrator, string tagName) where T : AbstractContentPage
        {
            viewTemplateModelRegistrator.Add(typeof(T), new TemplateModel
            {
                Name = $"{typeof(T).Name}-{tagName}",
                AvailableWithoutTag = false,
                Tags = [tagName],
                Inherit = true,
                TemplateTypeCategory = EPiServer.Framework.Web.TemplateTypeCategories.MvcPartialView,
                Path = $"~/Views/{typeof(T).Name}/{tagName}.cshtml"
            });
        }
    }
}
