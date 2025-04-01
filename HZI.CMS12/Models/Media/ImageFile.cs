using EPiServer.Framework.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace HZI.CMS12.Models.Media
{
    [ContentType(
        DisplayName = "Image",
        GUID = "552f45f4-dbfc-4305-954a-b52ec7a22d79"
        )]

    [MediaDescriptor(ExtensionString = "jpg, jpeg, png")]
    public class ImageFile : ImageData
    {
        [Display(
            Name = "Alternate Text"
            )]
        public virtual string? AltText { get; set; }
    }
}
