﻿using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace HZI.CMS12.Models.Pages.ViewModels
{
    public abstract class PageViewModel
    {
        public string? PageTitle { get; set; }
    }

    public class PageViewModel<T> : PageViewModel
    {
        public PageViewModel(T page)
        {
            Page = page;
        }

        public T Page { get; }
    }
}
