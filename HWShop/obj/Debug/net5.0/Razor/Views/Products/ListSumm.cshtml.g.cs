#pragma checksum "C:\Users\A.Iskender\source\repos\HWShop\HWShop\Views\Products\ListSumm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd2827b6c4b9cb998e45ddc8e949e1c973428b7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_ListSumm), @"mvc.1.0.view", @"/Views/Products/ListSumm.cshtml")]
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
#line 1 "C:\Users\A.Iskender\source\repos\HWShop\HWShop\Views\_ViewImports.cshtml"
using HWShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\A.Iskender\source\repos\HWShop\HWShop\Views\_ViewImports.cshtml"
using HWShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\A.Iskender\source\repos\HWShop\HWShop\Views\_ViewImports.cshtml"
using HWShop.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\A.Iskender\source\repos\HWShop\HWShop\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\A.Iskender\source\repos\HWShop\HWShop\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd2827b6c4b9cb998e45ddc8e949e1c973428b7b", @"/Views/Products/ListSumm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c154b38042e98a78926af64aa83265ec5529f77a", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_ListSumm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"card card-outline-primary m-1 p-1\">\n    <div class=\"bg-faded p-1\">\n        <h4>\n        ");
#nullable restore
#line 5 "C:\Users\A.Iskender\source\repos\HWShop\HWShop\Views\Products\ListSumm.cshtml"
   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 6 "C:\Users\A.Iskender\source\repos\HWShop\HWShop\Views\Products\ListSumm.cshtml"
         if (Model.Amount > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"badge badge-info badge-secondary\">\n            В наличие\n            </span> \n");
#nullable restore
#line 11 "C:\Users\A.Iskender\source\repos\HWShop\HWShop\Views\Products\ListSumm.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"badge badge-info badge-warning\">\n            Нет в наличии\n            </span>     \n");
#nullable restore
#line 17 "C:\Users\A.Iskender\source\repos\HWShop\HWShop\Views\Products\ListSumm.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"badge badge-pill badge-primary\" style=\"float:right\">\n                <small>");
#nullable restore
#line 19 "C:\Users\A.Iskender\source\repos\HWShop\HWShop\Views\Products\ListSumm.cshtml"
                  Write(Model.Price.ToString("C", new CultureInfo("kg-KG")));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\n            </span>\n        </h4>\n    </div>\n    <div class=\"card-text p-1\">");
#nullable restore
#line 23 "C:\Users\A.Iskender\source\repos\HWShop\HWShop\Views\Products\ListSumm.cshtml"
                          Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
