using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Chapter5.TagHelpers
{
    public class BootstrapAlertTagHelper : TagHelper
    {
        public bool Dismissable { get; set; }
        public string Color { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes.Add("class","alert alert-" + Color);
            output.Attributes.Add("role", "attribute");
            if (Dismissable)
                output.PostContent.SetHtmlContent(
                    $"<button type=\"button\" class=\"close\" data-dismiss=\"alert\"><span aria-hidden=\"true\">&times;</span></button>");

            var content = await output.GetChildContentAsync(true);
        }
        
    }
}