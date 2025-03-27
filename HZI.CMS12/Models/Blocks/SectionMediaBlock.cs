using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace HZI.CMS12.Models.Blocks
{
    [ContentType(
        DisplayName = "Section Media Block",
        GUID = "e479674e-b1f0-4f68-955a-07a065616448"
        )]
    public class SectionMediaBlock : BlockData
    {
        [Display(
            Name = "Headline",
            GroupName = SystemTabNames.Content,
            Order = 10
            )]
        public virtual string? Headline { get; set; }

        [Display(
            Name = "Body",
            GroupName = SystemTabNames.Content,
            Order = 20
            )]
        public virtual XhtmlString? Body { get; set; }

        [Display(
            Name = "Image",
            GroupName = SystemTabNames.Content,
            Order = 10
            )]
        [UIHint(UIHint.Image)]
        public virtual ContentReference? Image { get; set; }
    }
}
