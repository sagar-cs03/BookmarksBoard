#pragma checksum "C:\Users\i506670\source\repos\Pinboard\Pinboard\Views\Search\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ced2dad334dc0d465b67f6ee5e1b235439344a98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_Index), @"mvc.1.0.view", @"/Views/Search/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Search/Index.cshtml", typeof(AspNetCore.Views_Search_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\i506670\source\repos\Pinboard\Pinboard\Views\_ViewImports.cshtml"
using Pinboard;

#line default
#line hidden
#line 2 "C:\Users\i506670\source\repos\Pinboard\Pinboard\Views\_ViewImports.cshtml"
using Pinboard.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ced2dad334dc0d465b67f6ee5e1b235439344a98", @"/Views/Search/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8ce5dafe345297623cdeb93572a69d4d18ebbff", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Pinboard.Models.Bookmark>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\i506670\source\repos\Pinboard\Pinboard\Views\Search\Index.cshtml"
  
    ViewData["Title"] = "Search By Tag";

#line default
#line hidden
            BeginContext(97, 27, true);
            WriteLiteral("\r\n\r\n<div id=\"search\">\r\n    ");
            EndContext();
            BeginContext(124, 660, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ced2dad334dc0d465b67f6ee5e1b235439344a984535", async() => {
                BeginContext(186, 591, true);
                WriteLiteral(@"
        <input type=""text"" id=""SearchBox"" name=""Tags"" value="""" placeholder=""Tags here"" />
        <input type=""submit"" name=""SearchInAction"" value=""Search Page"" />
        <br />

        <p>
           
                <input type=""submit"" class=""btn btn-link"" name=""SearchInAll"" value=""All"" />
           
            
                <input type=""submit"" class =""btn btn-link"" name=""SearchInUnread"" value=""Unread"" />
           
           
                <input type=""submit"" class=""btn btn-link"" name=""SearchInStarred"" value=""Starred"" />
          

        </p>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(784, 106, true);
            WriteLiteral("\r\n</div>\r\n\r\n<br />\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(891, 39, false);
#line 35 "C:\Users\i506670\source\repos\Pinboard\Pinboard\Views\Search\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.URL));

#line default
#line hidden
            EndContext();
            BeginContext(930, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(986, 41, false);
#line 38 "C:\Users\i506670\source\repos\Pinboard\Pinboard\Views\Search\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1027, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1083, 47, false);
#line 41 "C:\Users\i506670\source\repos\Pinboard\Pinboard\Views\Search\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1130, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1186, 40, false);
#line 44 "C:\Users\i506670\source\repos\Pinboard\Pinboard\Views\Search\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Tags));

#line default
#line hidden
            EndContext();
            BeginContext(1226, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1282, 47, false);
#line 47 "C:\Users\i506670\source\repos\Pinboard\Pinboard\Views\Search\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsReadLater));

#line default
#line hidden
            EndContext();
            BeginContext(1329, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1385, 45, false);
#line 50 "C:\Users\i506670\source\repos\Pinboard\Pinboard\Views\Search\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsStarred));

#line default
#line hidden
            EndContext();
            BeginContext(1430, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1486, 44, false);
#line 53 "C:\Users\i506670\source\repos\Pinboard\Pinboard\Views\Search\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsTagged));

#line default
#line hidden
            EndContext();
            BeginContext(1530, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1586, 54, false);
#line 56 "C:\Users\i506670\source\repos\Pinboard\Pinboard\Views\Search\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DateAndTimeCreated));

#line default
#line hidden
            EndContext();
            BeginContext(1640, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 62 "C:\Users\i506670\source\repos\Pinboard\Pinboard\Views\Search\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1775, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1836, 38, false);
#line 66 "C:\Users\i506670\source\repos\Pinboard\Pinboard\Views\Search\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.URL));

#line default
#line hidden
            EndContext();
            BeginContext(1874, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1942, 40, false);
#line 69 "C:\Users\i506670\source\repos\Pinboard\Pinboard\Views\Search\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1982, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2050, 46, false);
#line 72 "C:\Users\i506670\source\repos\Pinboard\Pinboard\Views\Search\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2096, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2164, 39, false);
#line 75 "C:\Users\i506670\source\repos\Pinboard\Pinboard\Views\Search\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Tags));

#line default
#line hidden
            EndContext();
            BeginContext(2203, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2271, 46, false);
#line 78 "C:\Users\i506670\source\repos\Pinboard\Pinboard\Views\Search\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.IsReadLater));

#line default
#line hidden
            EndContext();
            BeginContext(2317, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2385, 44, false);
#line 81 "C:\Users\i506670\source\repos\Pinboard\Pinboard\Views\Search\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.IsStarred));

#line default
#line hidden
            EndContext();
            BeginContext(2429, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2497, 43, false);
#line 84 "C:\Users\i506670\source\repos\Pinboard\Pinboard\Views\Search\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.IsTagged));

#line default
#line hidden
            EndContext();
            BeginContext(2540, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2608, 53, false);
#line 87 "C:\Users\i506670\source\repos\Pinboard\Pinboard\Views\Search\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DateAndTimeCreated));

#line default
#line hidden
            EndContext();
            BeginContext(2661, 62, true);
            WriteLiteral("\r\n                </td>\r\n                \r\n            </tr>\r\n");
            EndContext();
#line 91 "C:\Users\i506670\source\repos\Pinboard\Pinboard\Views\Search\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2734, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Pinboard.Models.Bookmark>> Html { get; private set; }
    }
}
#pragma warning restore 1591
