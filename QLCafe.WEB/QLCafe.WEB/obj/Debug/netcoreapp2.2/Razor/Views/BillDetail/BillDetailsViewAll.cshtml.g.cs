#pragma checksum "C:\CaseStudy3\QLCafe.WEB\QLCafe.WEB\Views\BillDetail\BillDetailsViewAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee479735918602ac46510c435b44051813d4b1b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BillDetail_BillDetailsViewAll), @"mvc.1.0.view", @"/Views/BillDetail/BillDetailsViewAll.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BillDetail/BillDetailsViewAll.cshtml", typeof(AspNetCore.Views_BillDetail_BillDetailsViewAll))]
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
#line 1 "C:\CaseStudy3\QLCafe.WEB\QLCafe.WEB\Views\_ViewImports.cshtml"
using QLCafe.WEB;

#line default
#line hidden
#line 2 "C:\CaseStudy3\QLCafe.WEB\QLCafe.WEB\Views\_ViewImports.cshtml"
using QLCafe.WEB.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee479735918602ac46510c435b44051813d4b1b6", @"/Views/BillDetail/BillDetailsViewAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60d74ec3a4c109ea01f59e0f563e33cea5e11222", @"/Views/_ViewImports.cshtml")]
    public class Views_BillDetail_BillDetailsViewAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<QLCafe.WEB.Models.BillDetail.BillDetailsViewAll>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(69, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\CaseStudy3\QLCafe.WEB\QLCafe.WEB\Views\BillDetail\BillDetailsViewAll.cshtml"
  
    ViewData["Title"] = "BillDetailsViewAll";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(172, 41, true);
            WriteLiteral("\r\n<h1 style=\"color:red\">Chi Tiết Hóa Đơn ");
            EndContext();
            BeginContext(214, 17, false);
#line 8 "C:\CaseStudy3\QLCafe.WEB\QLCafe.WEB\Views\BillDetail\BillDetailsViewAll.cshtml"
                                  Write(ViewBag.NameTable);

#line default
#line hidden
            EndContext();
            BeginContext(231, 104, true);
            WriteLiteral("</h1>\r\n\r\n<div>\r\n    <dl class=\"row\" style=\"color:darkblue\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(336, 38, false);
#line 13 "C:\CaseStudy3\QLCafe.WEB\QLCafe.WEB\Views\BillDetail\BillDetailsViewAll.cshtml"
       Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(374, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(436, 25, false);
#line 16 "C:\CaseStudy3\QLCafe.WEB\QLCafe.WEB\Views\BillDetail\BillDetailsViewAll.cshtml"
       Write(Model.FirstOrDefault().ID);

#line default
#line hidden
            EndContext();
            BeginContext(461, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(522, 51, false);
#line 19 "C:\CaseStudy3\QLCafe.WEB\QLCafe.WEB\Views\BillDetail\BillDetailsViewAll.cshtml"
       Write(Html.DisplayNameFor(model => model.DateTimeCheckIn));

#line default
#line hidden
            EndContext();
            BeginContext(573, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(635, 38, false);
#line 22 "C:\CaseStudy3\QLCafe.WEB\QLCafe.WEB\Views\BillDetail\BillDetailsViewAll.cshtml"
       Write(Model.FirstOrDefault().DateTimeCheckIn);

#line default
#line hidden
            EndContext();
            BeginContext(673, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(734, 52, false);
#line 25 "C:\CaseStudy3\QLCafe.WEB\QLCafe.WEB\Views\BillDetail\BillDetailsViewAll.cshtml"
       Write(Html.DisplayNameFor(model => model.DateTimeCheckOut));

#line default
#line hidden
            EndContext();
            BeginContext(786, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(848, 39, false);
#line 28 "C:\CaseStudy3\QLCafe.WEB\QLCafe.WEB\Views\BillDetail\BillDetailsViewAll.cshtml"
       Write(Model.FirstOrDefault().DateTimeCheckOut);

#line default
#line hidden
            EndContext();
            BeginContext(887, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(948, 45, false);
#line 31 "C:\CaseStudy3\QLCafe.WEB\QLCafe.WEB\Views\BillDetail\BillDetailsViewAll.cshtml"
       Write(Html.DisplayNameFor(model => model.StrStatus));

#line default
#line hidden
            EndContext();
            BeginContext(993, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1055, 32, false);
#line 34 "C:\CaseStudy3\QLCafe.WEB\QLCafe.WEB\Views\BillDetail\BillDetailsViewAll.cshtml"
       Write(Model.FirstOrDefault().StrStatus);

#line default
#line hidden
            EndContext();
            BeginContext(1087, 185, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n<div>\r\n    <table class=\"table\" style=\"color:darkblue\" border=\"1\">\r\n        <thead>\r\n            <tr>\r\n\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1273, 40, false);
#line 45 "C:\CaseStudy3\QLCafe.WEB\QLCafe.WEB\Views\BillDetail\BillDetailsViewAll.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1313, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1381, 42, false);
#line 48 "C:\CaseStudy3\QLCafe.WEB\QLCafe.WEB\Views\BillDetail\BillDetailsViewAll.cshtml"
               Write(Html.DisplayNameFor(model => model.Number));

#line default
#line hidden
            EndContext();
            BeginContext(1423, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1491, 41, false);
#line 51 "C:\CaseStudy3\QLCafe.WEB\QLCafe.WEB\Views\BillDetail\BillDetailsViewAll.cshtml"
               Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1532, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1600, 41, false);
#line 54 "C:\CaseStudy3\QLCafe.WEB\QLCafe.WEB\Views\BillDetail\BillDetailsViewAll.cshtml"
               Write(Html.DisplayNameFor(model => model.Total));

#line default
#line hidden
            EndContext();
            BeginContext(1641, 149, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    Xóa\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 62 "C:\CaseStudy3\QLCafe.WEB\QLCafe.WEB\Views\BillDetail\BillDetailsViewAll.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1847, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1920, 39, false);
#line 66 "C:\CaseStudy3\QLCafe.WEB\QLCafe.WEB\Views\BillDetail\BillDetailsViewAll.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1959, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2039, 41, false);
#line 69 "C:\CaseStudy3\QLCafe.WEB\QLCafe.WEB\Views\BillDetail\BillDetailsViewAll.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Number));

#line default
#line hidden
            EndContext();
            BeginContext(2080, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2160, 40, false);
#line 72 "C:\CaseStudy3\QLCafe.WEB\QLCafe.WEB\Views\BillDetail\BillDetailsViewAll.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(2200, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2280, 40, false);
#line 75 "C:\CaseStudy3\QLCafe.WEB\QLCafe.WEB\Views\BillDetail\BillDetailsViewAll.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Total));

#line default
#line hidden
            EndContext();
            BeginContext(2320, 94, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td align=\"center\">\r\n                        ");
            EndContext();
            BeginContext(2415, 202, false);
#line 78 "C:\CaseStudy3\QLCafe.WEB\QLCafe.WEB\Views\BillDetail\BillDetailsViewAll.cshtml"
                   Write(Html.ActionLink("Delete", "BillDetailDelete", "BillDetail", new { id = item.BillsDetailID }, new { @class = "btn btn-outline-danger btn-sm", onClick = "return confirm('Bạn có chắc chắn muốn xóa?' ) " }));

#line default
#line hidden
            EndContext();
            BeginContext(2617, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 81 "C:\CaseStudy3\QLCafe.WEB\QLCafe.WEB\Views\BillDetail\BillDetailsViewAll.cshtml"
            }

#line default
#line hidden
            BeginContext(2684, 135, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n<div>\r\n    <dl class=\"row\" style=\"color:darkblue\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2820, 44, false);
#line 88 "C:\CaseStudy3\QLCafe.WEB\QLCafe.WEB\Views\BillDetail\BillDetailsViewAll.cshtml"
       Write(Html.DisplayNameFor(model => model.SumTotal));

#line default
#line hidden
            EndContext();
            BeginContext(2864, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2926, 31, false);
#line 91 "C:\CaseStudy3\QLCafe.WEB\QLCafe.WEB\Views\BillDetail\BillDetailsViewAll.cshtml"
       Write(Model.FirstOrDefault().SumTotal);

#line default
#line hidden
            EndContext();
            BeginContext(2957, 132, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <dl class=\"row\" style=\"color:darkblue\">\r\n        <dt class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3090, 141, false);
#line 98 "C:\CaseStudy3\QLCafe.WEB\QLCafe.WEB\Views\BillDetail\BillDetailsViewAll.cshtml"
       Write(Html.ActionLink("Thêm Món", "BillDetailAdd", "BillDetail", new { id = Model.FirstOrDefault().ID }, new { @class = "btn btn-primary btn-sm" }));

#line default
#line hidden
            EndContext();
            BeginContext(3231, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3292, 137, false);
#line 101 "C:\CaseStudy3\QLCafe.WEB\QLCafe.WEB\Views\BillDetail\BillDetailsViewAll.cshtml"
       Write(Html.ActionLink("Thanh Toán", "Pay", "BillDetail", new { id = Model.FirstOrDefault().TableID}, new { @class = "btn btn-primary btn-sm" }));

#line default
#line hidden
            EndContext();
            BeginContext(3429, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<QLCafe.WEB.Models.BillDetail.BillDetailsViewAll>> Html { get; private set; }
    }
}
#pragma warning restore 1591