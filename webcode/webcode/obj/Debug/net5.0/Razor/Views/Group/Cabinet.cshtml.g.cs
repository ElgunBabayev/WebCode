#pragma checksum "C:\Users\MSI\source\repos\webcode\webcode\Views\Group\Cabinet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d293ceb53aa9b5747d6bcc3e8938465b8a7b1871"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Group_Cabinet), @"mvc.1.0.view", @"/Views/Group/Cabinet.cshtml")]
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
#nullable restore
#line 1 "C:\Users\MSI\source\repos\webcode\webcode\Views\_ViewImports.cshtml"
using webcode;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MSI\source\repos\webcode\webcode\Views\_ViewImports.cshtml"
using webcode.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d293ceb53aa9b5747d6bcc3e8938465b8a7b1871", @"/Views/Group/Cabinet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3219487375709b78cdc3d07587f985a228390908", @"/Views/_ViewImports.cshtml")]
    public class Views_Group_Cabinet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Student>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<section id=\"student\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-6\">\r\n                <div class=\"stu-img col-12\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d293ceb53aa9b5747d6bcc3e8938465b8a7b18713255", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 205, "~/img/", 205, 6, true);
#nullable restore
#line 7 "C:\Users\MSI\source\repos\webcode\webcode\Views\Group\Cabinet.cshtml"
AddHtmlAttributeValue("", 211, Model.Photo, 211, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"about col-6\">\r\n                <h1>");
#nullable restore
#line 11 "C:\Users\MSI\source\repos\webcode\webcode\Views\Group\Cabinet.cshtml"
               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                <h6>CAP:");
#nullable restore
#line 12 "C:\Users\MSI\source\repos\webcode\webcode\Views\Group\Cabinet.cshtml"
                   Write(Model.Cap);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <p>Qrup:");
#nullable restore
#line 13 "C:\Users\MSI\source\repos\webcode\webcode\Views\Group\Cabinet.cshtml"
                   Write(Model.Group);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Muellim:");
#nullable restore
#line 14 "C:\Users\MSI\source\repos\webcode\webcode\Views\Group\Cabinet.cshtml"
                      Write(Model.Group.Teacher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Qrup sahesi:");
#nullable restore
#line 15 "C:\Users\MSI\source\repos\webcode\webcode\Views\Group\Cabinet.cshtml"
                          Write(Model.Group.GroupCats.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Email:");
#nullable restore
#line 16 "C:\Users\MSI\source\repos\webcode\webcode\Views\Group\Cabinet.cshtml"
                    Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Telefon:");
#nullable restore
#line 17 "C:\Users\MSI\source\repos\webcode\webcode\Views\Group\Cabinet.cshtml"
                      Write(Model.PhNum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Student> Html { get; private set; }
    }
}
#pragma warning restore 1591