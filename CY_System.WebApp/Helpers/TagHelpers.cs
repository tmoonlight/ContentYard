using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CY_System.WebApp.Helpers
{
    public class InputPlaceholderTagHelper : InputTagHelper
    {
        public InputPlaceholderTagHelper(IHtmlGenerator generator) : base(generator)
        {

        }


        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            base.Process(context, output);
        }
    }
}
