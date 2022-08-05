using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GencayExample.Extensions
{
    static public  class Extensions
    {
        public static IHtmlContent CustomTextBox(this IHtmlHelper htmlHelper,string name,string value="",string placeHolder=null)
        {
            return htmlHelper.TextBox(name, value, new
            {
                style="background-color:green;color-white;font-size:11px;",
                @class="form-input",
                placeholder=placeHolder
            });
        }
    }
}
