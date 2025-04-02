using HZI.CMS12.Models.Blocks;
using HZI.CMS12.Models.Pages;
using Microsoft.AspNetCore.Mvc;

namespace HZI.CMS12.Controllers.Pages
{
    public class GeneralPageController : BasePageController<GeneralPage>
    {
        public readonly IContentLoader contentLoader;

        public GeneralPageController(IContentLoader contentLoader)
        {
            this.contentLoader = contentLoader;
        }

        public IActionResult Index(GeneralPage currentContent)
        {
            if (currentContent.BottomContentArea != null)
            {
                var blockReference = currentContent.BottomContentArea.FilteredItems;
                foreach (var reference in blockReference)
                {
                    var block = contentLoader.Get<BlockData>(reference.ContentLink);

                    if (block is SectionMediaBlock sectionMedia)
                    {
                    }
                    else if (block is LinkGridBlock linkGrid)
                    {
                    }

                    /*
                    var blockType = block.GetOriginalType();

                    if(blockType == typeof(SectionMediaBlock))
                    {

                    }else if(blockType == typeof(LinkGridBlock))
                    {

                    }
                    */
                }

            }
            return PageView(currentContent);
        }
    }
}
