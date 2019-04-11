using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Views_Section3.Views.TagHelpers
{
    public class EmailTaghelper : TagHelper 
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";//tagname
            
            var content = (await output.GetChildContentAsync()).GetContent();
            output.Attributes.Add("href", "mailto:" + content);
            output.Content.SetContent(content);
        }
    }
}
