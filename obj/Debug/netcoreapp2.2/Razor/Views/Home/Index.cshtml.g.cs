#pragma checksum "C:\Users\Armando\Desktop\DEVELOPER\.NET Core Projects\EFC-1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e0d1015a74a8b5ce95d54830b323f038bc102b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Armando\Desktop\DEVELOPER\.NET Core Projects\EFC-1\Views\_ViewImports.cshtml"
using EFC_1;

#line default
#line hidden
#line 2 "C:\Users\Armando\Desktop\DEVELOPER\.NET Core Projects\EFC-1\Views\_ViewImports.cshtml"
using EFC_1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e0d1015a74a8b5ce95d54830b323f038bc102b2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65ee17295302658348e350bca439ccd0e81aed55", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EFC_1.Models.Cliente>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Armando\Desktop\DEVELOPER\.NET Core Projects\EFC-1\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(84, 267, true);
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">ASP.NET Core 2.2.6</h1>
    <p>Pomelo.EntityFrameworkCore.Mysql</p>
</div>

<table class=""table"">
<thead>
<tr>
<th>Nombre</th>
<th>Email</th>
<th>Telefono</th>
<th>Sexo</th>
<tr>
</thead>

<tbody>
");
            EndContext();
#line 24 "C:\Users\Armando\Desktop\DEVELOPER\.NET Core Projects\EFC-1\Views\Home\Index.cshtml"
 foreach(var item in Model )
{

#line default
#line hidden
            BeginContext(384, 24, true);
            WriteLiteral("    <tr>\r\n    <td>\r\n    ");
            EndContext();
            BeginContext(409, 11, false);
#line 28 "C:\Users\Armando\Desktop\DEVELOPER\.NET Core Projects\EFC-1\Views\Home\Index.cshtml"
Write(item.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(420, 28, true);
            WriteLiteral(" \r\n    </td>\r\n    <td>\r\n    ");
            EndContext();
            BeginContext(449, 10, false);
#line 31 "C:\Users\Armando\Desktop\DEVELOPER\.NET Core Projects\EFC-1\Views\Home\Index.cshtml"
Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(459, 27, true);
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n    ");
            EndContext();
            BeginContext(487, 13, false);
#line 34 "C:\Users\Armando\Desktop\DEVELOPER\.NET Core Projects\EFC-1\Views\Home\Index.cshtml"
Write(item.Telefono);

#line default
#line hidden
            EndContext();
            BeginContext(500, 27, true);
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n    ");
            EndContext();
            BeginContext(528, 9, false);
#line 37 "C:\Users\Armando\Desktop\DEVELOPER\.NET Core Projects\EFC-1\Views\Home\Index.cshtml"
Write(item.Sexo);

#line default
#line hidden
            EndContext();
            BeginContext(537, 24, true);
            WriteLiteral("\r\n    </td>\r\n    </tr>\r\n");
            EndContext();
#line 40 "C:\Users\Armando\Desktop\DEVELOPER\.NET Core Projects\EFC-1\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(564, 20, true);
            WriteLiteral("</tbody>\r\n\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EFC_1.Models.Cliente>> Html { get; private set; }
    }
}
#pragma warning restore 1591
