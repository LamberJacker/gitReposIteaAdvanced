#pragma checksum "D:\itea\homework\webregistration\lasthomework\Pages\EditRegistration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e618f76b8462bf13055be1f32cc511718d8f170"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(lasthomework.Pages.Pages_EditRegistration), @"mvc.1.0.razor-page", @"/Pages/EditRegistration.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/EditRegistration.cshtml", typeof(lasthomework.Pages.Pages_EditRegistration), null)]
namespace lasthomework.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\itea\homework\webregistration\lasthomework\Pages\_ViewImports.cshtml"
using lasthomework;

#line default
#line hidden
#line 3 "D:\itea\homework\webregistration\lasthomework\Pages\EditRegistration.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e618f76b8462bf13055be1f32cc511718d8f170", @"/Pages/EditRegistration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b17698b9ccbb910181af76969d78d52de8f9e421", @"/Pages/_ViewImports.cshtml")]
    public class Pages_EditRegistration : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "D:\itea\homework\webregistration\lasthomework\Pages\EditRegistration.cshtml"
  
    if (HttpContext.Request.Method == "POST")
    {
        string login = Request.Form["login"];
        string password = Request.Form["password"];
        string name = Request.Form["name"];
        string address = Request.Form["address"];
        string age = Request.Form["age"];
        UserControler uc = new UserControler();
        string resultEdit = uc.EditUser(login, password, name, address, age);

#line default
#line hidden
            BeginContext(487, 29, true);
            WriteLiteral("        <h2>New info about : ");
            EndContext();
            BeginContext(517, 5, false);
#line 14 "D:\itea\homework\webregistration\lasthomework\Pages\EditRegistration.cshtml"
                        Write(login);

#line default
#line hidden
            EndContext();
            BeginContext(522, 19, true);
            WriteLiteral("</h2>\r\n        <h2>");
            EndContext();
            BeginContext(542, 10, false);
#line 15 "D:\itea\homework\webregistration\lasthomework\Pages\EditRegistration.cshtml"
       Write(resultEdit);

#line default
#line hidden
            EndContext();
            BeginContext(552, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
#line 16 "D:\itea\homework\webregistration\lasthomework\Pages\EditRegistration.cshtml"
    }

#line default
#line hidden
            BeginContext(569, 128, true);
            WriteLiteral("<div class=\"profile\">\r\n    <h1>EDIT INFO ABOUT USER</h1>\r\n    <h2>EMAIL IS A KEY THEN YOU CAN`T CHANGE THIS FIELD</h2>\r\n</div>\r\n");
            EndContext();
            BeginContext(697, 670, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "618a4fa4bc0e496695de62f4dae5d2f8", async() => {
                BeginContext(727, 633, true);
                WriteLiteral(@"
    <div>
        <label for=""login"">Login (email)</label>
        <input type=""email"" name=""login"" required>
    </div>
    <div>
        <label for=""password"">NEW Password</label>
        <input type=""password"" class=""pass"" name=""password"">
    </div>
    <div>
        <label for=""name"">NEW Name</label>
        <input type=""text"" name=""name"">
    </div>
    <div>
        <label for=""address"">NEW Address</label>
        <input type=""text"" name=""address"">
    </div>
    <div>
        <label for=""age"">NEW Age</label>
        <input type=""text"" name=""age"">
    </div>
    <button type=""submit"">OK</button>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContactModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContactModel>)PageContext?.ViewData;
        public ContactModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
