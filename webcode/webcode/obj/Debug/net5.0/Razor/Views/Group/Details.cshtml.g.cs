#pragma checksum "C:\Users\MSI\source\repos\webcode\webcode\Views\Group\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88cf9d58450c9dc707978b4fe8abbca73760f936"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Group_Details), @"mvc.1.0.view", @"/Views/Group/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88cf9d58450c9dc707978b4fe8abbca73760f936", @"/Views/Group/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3219487375709b78cdc3d07587f985a228390908", @"/Views/_ViewImports.cshtml")]
    public class Views_Group_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Group>
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
            WriteLiteral("<header>\r\n    <div class=\"container\">\r\n        <h1 class=\"title\">");
#nullable restore
#line 4 "C:\Users\MSI\source\repos\webcode\webcode\Views\Group\Details.cshtml"
                     Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <p>Muellim:");
#nullable restore
#line 5 "C:\Users\MSI\source\repos\webcode\webcode\Views\Group\Details.cshtml"
              Write(Model.Teacher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Telebe sayi:");
#nullable restore
#line 6 "C:\Users\MSI\source\repos\webcode\webcode\Views\Group\Details.cshtml"
                  Write(Model.Students.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Qrup sahesi: ");
#nullable restore
#line 7 "C:\Users\MSI\source\repos\webcode\webcode\Views\Group\Details.cshtml"
                   Write(Model.GroupCats.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</header>\r\n\r\n<section id=\"stview\">\r\n    <div class=\"container\">\r\n        <p>Telebeler:</p>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 15 "C:\Users\MSI\source\repos\webcode\webcode\Views\Group\Details.cshtml"
             foreach (Student item in Model.Students )
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-4 mb-4\">\r\n                    <div class=\"student-img\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "88cf9d58450c9dc707978b4fe8abbca73760f9364645", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 562, "~/img/", 562, 6, true);
#nullable restore
#line 19 "C:\Users\MSI\source\repos\webcode\webcode\Views\Group\Details.cshtml"
AddHtmlAttributeValue("", 568, item.Photo, 568, 11, false);

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
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"student-item\">\r\n                        <h3>");
#nullable restore
#line 22 "C:\Users\MSI\source\repos\webcode\webcode\Views\Group\Details.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <p>");
#nullable restore
#line 23 "C:\Users\MSI\source\repos\webcode\webcode\Views\Group\Details.cshtml"
                      Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <div><a");
            BeginWriteAttribute("href", " href=\"", 781, "\"", 811, 2);
            WriteAttributeValue("", 788, "/group/cabinet/", 788, 15, true);
#nullable restore
#line 24 "C:\Users\MSI\source\repos\webcode\webcode\Views\Group\Details.cshtml"
WriteAttributeValue("", 803, item.Id, 803, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Etrafli</a></div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 27 "C:\Users\MSI\source\repos\webcode\webcode\Views\Group\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Group> Html { get; private set; }
    }
}
#pragma warning restore 1591
