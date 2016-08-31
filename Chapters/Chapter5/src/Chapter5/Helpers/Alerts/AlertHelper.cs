using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Html;

namespace Chapter5.Helpers.Alerts
{
    public static class AlertHelper
    {
        public static Alert Alert(this IHtmlHelper html, string title, Enums.AlertStyle style = Enums.AlertStyle.Success)
        {
            return new Alert(html, title, style);
        }
    }
}
