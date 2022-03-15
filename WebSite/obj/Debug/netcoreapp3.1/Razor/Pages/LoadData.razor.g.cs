#pragma checksum "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\LoadData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88456654e8d7e725a1f6280f338e6dfcc0133be8"
// <auto-generated/>
#pragma warning disable 1591
namespace WebSite.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\_Imports.razor"
using WebSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\_Imports.razor"
using WebSite.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\LoadData.razor"
using CommonStructures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\LoadData.razor"
using WebAPI_1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\LoadData.razor"
using WebAPI_2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\LoadData.razor"
using WebAPI_3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\LoadData.razor"
using WebAPI_4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\LoadData.razor"
using WebSite.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/loaddata")]
    public partial class LoadData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Load Data</h3>\r\n\r\n");
#nullable restore
#line 22 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\LoadData.razor"
 if (TC_Data == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<h4>loading...</h4>\r\n");
#nullable restore
#line 25 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\LoadData.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\LoadData.razor"
     if (TC_Data.Any())
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "        ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, @"<thead>
            <tr>
                <th>Recall Number</th>
                <th>Manufacture Name</th>
                <th>Make Name</th>
                <th>Model Name</th>
                <th>Recall Year</th>
                <th>Manufacturer Recall Number</th>
                <th>Category - English</th>
                <th>Category - French</th>
                <th>System Type - English</th>
                <th>System Type - French</th>
                <th>Notification Type - English</th>
                <th>Notification Type - French</th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 48 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\LoadData.razor"
             foreach (var item in TC_Data)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
#nullable restore
#line 51 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\LoadData.razor"
__builder.AddContent(14, item.RecallNumber.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
#nullable restore
#line 52 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\LoadData.razor"
__builder.AddContent(17, item.ManufactureName.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
#nullable restore
#line 53 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\LoadData.razor"
__builder.AddContent(20, item.MakeName.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
#nullable restore
#line 54 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\LoadData.razor"
__builder.AddContent(23, item.ModelName.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "td");
#nullable restore
#line 55 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\LoadData.razor"
__builder.AddContent(26, item.RecallYear.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "td");
#nullable restore
#line 56 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\LoadData.razor"
__builder.AddContent(29, item.ManufacturerRecallNumber.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.OpenElement(31, "td");
#nullable restore
#line 57 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\LoadData.razor"
__builder.AddContent(32, item.CategoryETXT.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.OpenElement(34, "td");
#nullable restore
#line 58 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\LoadData.razor"
__builder.AddContent(35, item.CategoryFTXT.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.OpenElement(37, "td");
#nullable restore
#line 59 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\LoadData.razor"
__builder.AddContent(38, item.SystemTypeETXT.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.OpenElement(40, "td");
#nullable restore
#line 60 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\LoadData.razor"
__builder.AddContent(41, item.SystemTypeFTXT.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.OpenElement(43, "td");
#nullable restore
#line 61 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\LoadData.razor"
__builder.AddContent(44, item?.NotificationTypeETXT?.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                    ");
            __builder.OpenElement(46, "td");
#nullable restore
#line 62 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\LoadData.razor"
__builder.AddContent(47, item?.NotificationTypeFTXT?.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n");
#nullable restore
#line 64 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\LoadData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(50, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
#nullable restore
#line 67 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\LoadData.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\LoadData.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\LoadData.razor"
       
    private IEnumerable<TC_Data> TC_Data = null;

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        TC_Data = await _api3Service.LoadData();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebApi3Service _api3Service { get; set; }
    }
}
#pragma warning restore 1591
