#pragma checksum "C:\Snehal\Test project\MyFisrtNetCoreWebApp\MyFisrtNetCoreWebApp\Views\Location\LocationDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c09eab6e47f949f44f5af52aa803a7e683f33a1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Location_LocationDetails), @"mvc.1.0.view", @"/Views/Location/LocationDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c09eab6e47f949f44f5af52aa803a7e683f33a1a", @"/Views/Location/LocationDetails.cshtml")]
    public class Views_Location_LocationDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyFisrtNetCoreWebApp.Models.LocationDetails>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Snehal\Test project\MyFisrtNetCoreWebApp\MyFisrtNetCoreWebApp\Views\Location\LocationDetails.cshtml"
  
    ViewData["Title"] = "LocationDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>LocationDetails</h1>\r\n\r\n<div>\r\n    <h4>LocationDetails</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Snehal\Test project\MyFisrtNetCoreWebApp\MyFisrtNetCoreWebApp\Views\Location\LocationDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Company));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Snehal\Test project\MyFisrtNetCoreWebApp\MyFisrtNetCoreWebApp\Views\Location\LocationDetails.cshtml"
       Write(Html.DisplayFor(model => model.Company));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Snehal\Test project\MyFisrtNetCoreWebApp\MyFisrtNetCoreWebApp\Views\Location\LocationDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Area));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Snehal\Test project\MyFisrtNetCoreWebApp\MyFisrtNetCoreWebApp\Views\Location\LocationDetails.cshtml"
       Write(Html.DisplayFor(model => model.Area));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Snehal\Test project\MyFisrtNetCoreWebApp\MyFisrtNetCoreWebApp\Views\Location\LocationDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Snehal\Test project\MyFisrtNetCoreWebApp\MyFisrtNetCoreWebApp\Views\Location\LocationDetails.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 34 "C:\Snehal\Test project\MyFisrtNetCoreWebApp\MyFisrtNetCoreWebApp\Views\Location\LocationDetails.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyFisrtNetCoreWebApp.Models.LocationDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591