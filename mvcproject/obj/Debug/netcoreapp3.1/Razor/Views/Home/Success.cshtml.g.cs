#pragma checksum "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpOct2020\CSharp_Oct2020_GitHub\mvcproject\Views\Home\Success.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcb3005b4ddb8b4389d12de79532a896ed6c9196"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Success), @"mvc.1.0.view", @"/Views/Home/Success.cshtml")]
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
#line 1 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpOct2020\CSharp_Oct2020_GitHub\mvcproject\Views\_ViewImports.cshtml"
using mvcproject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpOct2020\CSharp_Oct2020_GitHub\mvcproject\Views\_ViewImports.cshtml"
using mvcproject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcb3005b4ddb8b4389d12de79532a896ed6c9196", @"/Views/Home/Success.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"899233e96cc852233039d0981f740e8b0d2d7dc6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Success : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Welcome ");
#nullable restore
#line 3 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpOct2020\CSharp_Oct2020_GitHub\mvcproject\Views\Home\Success.cshtml"
       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h2>Your email: ");
#nullable restore
#line 4 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpOct2020\CSharp_Oct2020_GitHub\mvcproject\Views\Home\Success.cshtml"
           Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h3>Your hidden value is: ");
#nullable restore
#line 5 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpOct2020\CSharp_Oct2020_GitHub\mvcproject\Views\Home\Success.cshtml"
                     Write(Model.hiddenValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
