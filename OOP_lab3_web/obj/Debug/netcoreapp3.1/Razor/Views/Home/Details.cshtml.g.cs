#pragma checksum "D:\OOP_lab3_web\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5df204f1689f768fd5b5a791b91de4ff85a1d0d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "D:\OOP_lab3_web\Views\_ViewImports.cshtml"
using OOP_lab3_web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\OOP_lab3_web\Views\_ViewImports.cshtml"
using OOP_lab3_web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5df204f1689f768fd5b5a791b91de4ff85a1d0d5", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2d1c91c6474b25c7066469c64967fe4a0da82fb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OOP_lab3_web.Models.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\OOP_lab3_web\Views\Home\Details.cshtml"
  
    ViewBag.Title = Model.name;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Продукт: ");
#nullable restore
#line 6 "D:\OOP_lab3_web\Views\Home\Details.cshtml"
        Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<div>\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>Идентификатор</dt>\r\n        <dd>");
#nullable restore
#line 10 "D:\OOP_lab3_web\Views\Home\Details.cshtml"
       Write(Model.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n        <dt>Количество</dt>\r\n        <dd>");
#nullable restore
#line 13 "D:\OOP_lab3_web\Views\Home\Details.cshtml"
       Write(Model.count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n        <dt>Цена</dt>\r\n        <dd>");
#nullable restore
#line 16 "D:\OOP_lab3_web\Views\Home\Details.cshtml"
       Write(Model.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n    </dl>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OOP_lab3_web.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
