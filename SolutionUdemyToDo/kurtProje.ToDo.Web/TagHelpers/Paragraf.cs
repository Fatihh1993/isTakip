using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurtProje.ToDo.Web.TagHelpers
{
    [HtmlTargetElement("fatih")]
    public class Paragraf : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //tagbuilder
            //stringbuilder
            //string data

            //var tagBuilder = new TagBuilder("p");
            //tagBuilder.InnerHtml.AppendHtml("<b>fatih Kurt</b>");
            //output.Content.SetHtmlContent(tagBuilder);

            //var stringBuilder = new StringBuilder();
            //stringBuilder.AppendFormat("<p> <b> {0} </b> </p>", "Fatih Kurt");
            //output.Content.SetHtmlContent(stringBuilder.ToString());


            string data = string.Empty;
            data = "<p> <b>" + " Fatih Kurt" + " </b> </p>";
            output.Content.SetHtmlContent(data);

        }
    }
}
