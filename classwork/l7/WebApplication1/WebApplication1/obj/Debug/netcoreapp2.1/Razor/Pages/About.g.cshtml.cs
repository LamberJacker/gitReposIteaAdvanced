#pragma checksum "C:\Users\Dasha\source\repos\WebApplication1\WebApplication1\Pages\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49f21164de71e95a6e79e55018fd4eabc37c72d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApplication1.Pages.Pages_About), @"mvc.1.0.razor-page", @"/Pages/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/About.cshtml", typeof(WebApplication1.Pages.Pages_About), null)]
namespace WebApplication1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Dasha\source\repos\WebApplication1\WebApplication1\Pages\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49f21164de71e95a6e79e55018fd4eabc37c72d3", @"/Pages/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd66e6c0b2d0593b97c0d67f6f506054866fe040", @"/Pages/_ViewImports.cshtml")]
    public class Pages_About : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Dasha\source\repos\WebApplication1\WebApplication1\Pages\About.cshtml"
  
    ViewData["Title"] = "About";
    if (HttpContext.Request.Method == "POST")
    {
        string login = Request.Form["name"];
        string pass = Request.Form["password"];
        MyClass c1 = new MyClass();
        string str = (c1.getAut(login, pass));
        string color = str.Equals("Access") ? "green" : "red";

#line default
#line hidden
            BeginContext(362, 11, true);
            WriteLiteral("        <h1");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 373, "\"", 393, 2);
            WriteAttributeValue("", 381, "color:", 381, 6, true);
#line 12 "C:\Users\Dasha\source\repos\WebApplication1\WebApplication1\Pages\About.cshtml"
WriteAttributeValue("", 387, color, 387, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(394, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(396, 3, false);
#line 12 "C:\Users\Dasha\source\repos\WebApplication1\WebApplication1\Pages\About.cshtml"
                            Write(str);

#line default
#line hidden
            EndContext();
            BeginContext(399, 7, true);
            WriteLiteral("</h1>\r\n");
            EndContext();
#line 13 "C:\Users\Dasha\source\repos\WebApplication1\WebApplication1\Pages\About.cshtml"
    }

    

#line default
#line hidden
            BeginContext(422, 8, true);
            WriteLiteral("    <h2>");
            EndContext();
            BeginContext(431, 17, false);
#line 16 "C:\Users\Dasha\source\repos\WebApplication1\WebApplication1\Pages\About.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(448, 15, true);
            WriteLiteral("</h2>\r\n    <h3>");
            EndContext();
            BeginContext(464, 13, false);
#line 17 "C:\Users\Dasha\source\repos\WebApplication1\WebApplication1\Pages\About.cshtml"
   Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(477, 84, true);
            WriteLiteral("</h3>\r\n\r\n    <p>\r\n        Use this area to provide additional information.\r\n        ");
            EndContext();
            BeginContext(561, 342, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3104bdb0027c4a7996aae3b19767ffbb", async() => {
                BeginContext(591, 305, true);
                WriteLiteral(@"
            <table>
                <tr><td>Login</td><td><input type=""text"" name=""name"" /></td></tr>
                <tr><td>Pass</td><td><input type=""password"" name=""password"" /></td></tr>
                <tr><td></td><td><input type=""submit"" value=""OK"" /></td></tr>
            </table>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(903, 14, true);
            WriteLiteral("\r\n\r\n    </p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AboutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AboutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AboutModel>)PageContext?.ViewData;
        public AboutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
