using HZI.CMS12.Models.Blocks;
using System.ComponentModel.DataAnnotations;

namespace HZI.CMS12.Models.Pages
{
    public class AbstractContentPage : PageData
    {
        [Display(
            Name = "Page Title",
            GroupName = "SEO",
            Order = 10)]
        public virtual string? PageTitle { get; set; }

        [Display(
            Name = "Meta Description",
            GroupName = "SEO",
            Order = 20)]
        public virtual string? MetaDescription { get; set; }

        [Display(
            Name = "Headline", 
            GroupName = SystemTabNames.Content, 
            Order = 10)]
        public virtual string? Headline { get; set; }
 
        [Display(
           Name = "Headline Slug",
           GroupName = SystemTabNames.Content,
           Order = 20)]
        public virtual string?  HeadlineSlug { get; set; }

        [Display(
           Name = "Body",
           GroupName = SystemTabNames.Content,
           Order = 30)]
        public virtual XhtmlString? Body { get; set; }

        [Display(
           Name = "Bottom Content Area",
           GroupName = SystemTabNames.Content,
           Order = 40)]
        [AllowedTypes(AllowedTypes = [typeof(SectionMediaBlock), typeof(LinkGridBlock)])]
        public virtual ContentArea? BottomContentArea { get; set; }
    }
}
