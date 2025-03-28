using HZI.CMS12.Models.Pages;
using System.ComponentModel.DataAnnotations;

namespace HZI.CMS12.Models.Blocks
{
    [ContentType(
        DisplayName = "Link Grid Block",
        GUID = "8538736b-bbfc-475a-a760-c1fa8705f15d"
        )]
    public class LinkGridBlock : BlockData
    {
        [Display(
            Name = "Links",
            GroupName = SystemTabNames.Content,
            Order = 10
            )]
        [AllowedTypes(AllowedTypes = [typeof(AbstractContentPage)])]
        public virtual ContentArea? Links { get; set; }
    }
}
