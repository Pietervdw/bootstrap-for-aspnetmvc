using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;
using static Chapter5.Helpers.Enums;

namespace Chapter5.TagHelpers
{


    public class BootstrapButtonTagHelper : TagHelper
    {
        public string Color { get; set; }
        public string Size { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "button";
            output.Attributes.Clear();
            output.Attributes.Add("class", "btn btn-" + Color + " btn-" + Size);
        }

    }
}
