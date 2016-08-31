using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Chapter5.Helpers
{
    public static class ButtonExtensions
    {
        public static IHtmlContent BootstrapButton(this IHtmlHelper helper, string caption, Enums.ButtonStyle style, Enums.ButtonSize size)
        {
            if (size != Enums.ButtonSize.Normal)
            {
                return new HtmlString(string.Format("<button type=\"button\" class=\"btn btn-{0} btn-{1}\">{2}</button>", style.ToString().ToLower(), ToBootstrapSize(size), caption));
            }
            return new HtmlString(string.Format("<button type=\"button\" class=\"btn btn-{0}\">{1}</button>", style.ToString().ToLower(), caption));
        }

        private static string ToBootstrapSize(Enums.ButtonSize size)
        {
            string bootstrapSize = string.Empty;
            switch (size)
            {
                case Enums.ButtonSize.Large:
                    bootstrapSize = "lg";
                    break;

                case Enums.ButtonSize.Small:
                    bootstrapSize = "sm";
                    break;

                case Enums.ButtonSize.ExtraSmall:
                    bootstrapSize = "xs";
                    break;
            }
            return bootstrapSize;
        }
    }
}
