#pragma checksum "C:\Users\User\source\repos\MVCCoreApplications\Jony2\Views\Shared\_ServicePartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0468cca0f591a56f3f4f03be90632e9d5f86110"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ServicePartialView), @"mvc.1.0.view", @"/Views/Shared/_ServicePartialView.cshtml")]
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
#line 1 "C:\Users\User\source\repos\MVCCoreApplications\Jony2\Views\_ViewImports.cshtml"
using Jony2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\MVCCoreApplications\Jony2\Views\_ViewImports.cshtml"
using Jony2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0468cca0f591a56f3f4f03be90632e9d5f86110", @"/Views/Shared/_ServicePartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d53f0006c921b04981771ef23687985eb48f5df8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ServicePartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Service>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\source\repos\MVCCoreApplications\Jony2\Views\Shared\_ServicePartialView.cshtml"
  
    ViewData["Title"] = "_ServicePartialView";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-lg-4 col-md-6\">\r\n    <div class=\"single_service text-center\">\r\n        <div class=\"icon\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 196, "\"", 226, 2);
            WriteAttributeValue("", 202, "img/svg_icon/", 202, 13, true);
#nullable restore
#line 9 "C:\Users\User\source\repos\MVCCoreApplications\Jony2\Views\Shared\_ServicePartialView.cshtml"
WriteAttributeValue("", 215, Model.Icon, 215, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 227, "\"", 233, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n        <h3>\r\n            ");
#nullable restore
#line 12 "C:\Users\User\source\repos\MVCCoreApplications\Jony2\Views\Shared\_ServicePartialView.cshtml"
       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h3>\r\n        <p>");
#nullable restore
#line 14 "C:\Users\User\source\repos\MVCCoreApplications\Jony2\Views\Shared\_ServicePartialView.cshtml"
      Write(Model.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Service> Html { get; private set; }
    }
}
#pragma warning restore 1591
