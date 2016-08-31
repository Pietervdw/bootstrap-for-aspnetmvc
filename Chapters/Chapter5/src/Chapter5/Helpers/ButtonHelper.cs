using Microsoft.AspNetCore.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chapter5.Helpers
{
    public static class ButtonHelper
    {
        public static HtmlString Button(string caption, Enums.ButtonStyle style, Enums.ButtonSize size)
        {
            if (size != Enums.ButtonSize.Normal)
            {
                return new HtmlString(
                    $"<button type=\"button\" class=\"btn btn-{style.ToString().ToLower()} btn-{ToBootstrapSize(size)}\">{caption}</button>");
            }
            return new HtmlString(
                $"<button type=\"button\" class=\"btn btn-{style.ToString().ToLower()}\">{caption}</button>");

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