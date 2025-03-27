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
            Name = "Sub Headline",
            GroupName = SystemTabNames.Content,
            Order = 20
            )]
        public virtual string? SubHeadline { get; set; }

        [Display(
            Name = "Body",
            GroupName = SystemTabNames.Content,
            Order = 30
            )]
        public virtual XhtmlString? Body { get; set; }

        [Display(
            Name = "Image on Left or Right",
            GroupName = SystemTabNames.Content,
            Order = 40
            )]
        [AllowedValues(["Left", "Right"], ErrorMessage = "Invalid")]
        public virtual string? ImagePosition { get; set; }

        [Display(
            Name = "Image",
            GroupName = SystemTabNames.Content,
            Order = 50
            )]
        [UIHint(UIHint.Image)]
        public virtual ContentReference? Image { get; set; }
    }
}
