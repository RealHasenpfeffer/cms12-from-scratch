﻿namespace HZI.CMS12.Models.Pages.ViewModels
{
    public class HomepageViewModel : PageViewModel<Homepage>
    {
        public HomepageViewModel(Homepage page) : base(page)
        {
        }

        public IEnumerable<AbstractContentPage> RelatedContent { get; internal set; } = [];
    }
}
