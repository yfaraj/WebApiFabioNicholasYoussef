#pragma checksum "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi3.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62615fbf1f77bf35c64efb3df0aeda838834021f"
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
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\_Imports.razor"
using WebSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\_Imports.razor"
using WebSite.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\_Imports.razor"
using WebSite.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\_Imports.razor"
using CommonStructures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\_Imports.razor"
using WebAPI_1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\_Imports.razor"
using WebAPI_2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\_Imports.razor"
using WebAPI_3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\_Imports.razor"
using WebAPI_4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/webapi3")]
    public partial class WebApi3 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Select the input file from WebApi 2</h3>\r\n");
            __builder.OpenComponent<BlazorInputFile.InputFile>(1);
            __builder.AddAttribute(2, "OnChange", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 6 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi3.razor"
                     HandleFileSelected

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n<br>\r\n<br>\r\n\r\n");
#nullable restore
#line 10 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi3.razor"
 if (file != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "p");
            __builder.AddContent(6, "Name: ");
#nullable restore
#line 12 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi3.razor"
__builder.AddContent(7, file.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "p");
            __builder.AddContent(10, "Size in Bytes: ");
#nullable restore
#line 13 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi3.razor"
__builder.AddContent(11, file.Size);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "p");
            __builder.AddContent(14, "File type: ");
#nullable restore
#line 14 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi3.razor"
__builder.AddContent(15, file.Type);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 15 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi3.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(17, "<br>\r\n<br>\r\n\r\n");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi3.razor"
                  PostData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(20, "Post to API 3");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n<br>\r\n");
            __builder.AddMarkupContent(22, "<h3>Response from API 2</h3>\r\n");
#nullable restore
#line 22 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi3.razor"
 if (string.IsNullOrWhiteSpace(postDataResponse))
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "    ");
            __builder.AddMarkupContent(24, "<h5>loading data...</h5>\r\n");
#nullable restore
#line 25 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi3.razor"
} else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(25, "    ");
            __builder.OpenElement(26, "h5");
            __builder.AddAttribute(27, "style", "color:red");
#nullable restore
#line 27 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi3.razor"
__builder.AddContent(28, postDataResponse);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 28 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi3.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(30, "<br>\r\n<br>\r\n");
            __builder.AddMarkupContent(31, "<h3>Search by Manufacturer Recall Number</h3>\r\n");
            __builder.OpenElement(32, "input");
            __builder.AddAttribute(33, "type", "text");
            __builder.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi3.razor"
                                 searchItem

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchItem = __value, searchItem));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
            __builder.OpenElement(37, "input");
            __builder.AddAttribute(38, "type", "button");
            __builder.AddAttribute(39, "value", "Search");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi3.razor"
                                               SearchItem

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n\r\n<br>\r\n<br>\r\n<br>\r\n");
            __builder.AddMarkupContent(42, "<h3>Load all data</h3>\r\n");
            __builder.OpenElement(43, "button");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi3.razor"
                  LoadData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(45, "Load Data");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n<br>\r\n");
#nullable restore
#line 41 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi3.razor"
 if (tc_Data == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(47, "    ");
            __builder.AddMarkupContent(48, "<h5>loading data...</h5>\r\n");
#nullable restore
#line 44 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi3.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi3.razor"
     if (tc_Data.Any())
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(49, "        ");
            __builder.OpenElement(50, "table");
            __builder.AddAttribute(51, "class", "table");
            __builder.AddMarkupContent(52, "\r\n        ");
            __builder.AddMarkupContent(53, @"<thead>
            <tr>
                <th>Recall Number</th>
                <th>Manufacture Name</th>
                <th>Make Name</th>
                <th>Model Name</th>
                <th>Recall Year</th>
                <th>Manufacturer Recall Number</th>
                <th>Category (En)</th>
                <th>Category (Fr)</th>
                <th>System Type (En)</th>
                <th>System Type (Fr)</th>
                <th>Notification Type (En)</th>
                <th>Notification Type (Fr)</th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(54, "tbody");
            __builder.AddMarkupContent(55, "\r\n");
#nullable restore
#line 67 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi3.razor"
             foreach (var item in tc_Data)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(56, "                ");
            __builder.OpenElement(57, "tr");
            __builder.AddMarkupContent(58, "\r\n                    ");
            __builder.OpenElement(59, "td");
#nullable restore
#line 70 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi3.razor"
__builder.AddContent(60, item?.RecallNumber?.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                    ");
            __builder.OpenElement(62, "td");
#nullable restore
#line 71 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi3.razor"
__builder.AddContent(63, item?.ManufactureName?.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                    ");
            __builder.OpenElement(65, "td");
#nullable restore
#line 72 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi3.razor"
__builder.AddContent(66, item?.MakeName?.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                    ");
            __builder.OpenElement(68, "td");
#nullable restore
#line 73 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi3.razor"
__builder.AddContent(69, item?.ModelName?.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                    ");
            __builder.OpenElement(71, "td");
#nullable restore
#line 74 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi3.razor"
__builder.AddContent(72, item?.RecallYear?.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                    ");
            __builder.OpenElement(74, "td");
#nullable restore
#line 75 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi3.razor"
__builder.AddContent(75, item?.ManufacturerRecallNumber?.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                    ");
            __builder.OpenElement(77, "td");
#nullable restore
#line 76 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi3.razor"
__builder.AddContent(78, item?.CategoryETXT?.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                    ");
            __builder.OpenElement(80, "td");
#nullable restore
#line 77 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi3.razor"
__builder.AddContent(81, item?.CategoryFTXT?.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                    ");
            __builder.OpenElement(83, "td");
#nullable restore
#line 78 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi3.razor"
__builder.AddContent(84, item?.SystemTypeETXT?.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                    ");
            __builder.OpenElement(86, "td");
#nullable restore
#line 79 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi3.razor"
__builder.AddContent(87, item?.SystemTypeFTXT?.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                    ");
            __builder.OpenElement(89, "td");
#nullable restore
#line 80 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi3.razor"
__builder.AddContent(90, item?.NotificationTypeETXT?.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                    ");
            __builder.OpenElement(92, "td");
#nullable restore
#line 81 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi3.razor"
__builder.AddContent(93, item?.NotificationTypeFTXT?.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n");
#nullable restore
#line 83 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi3.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(96, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n");
#nullable restore
#line 86 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi3.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi3.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 89 "C:\01-LAB\TC\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi3.razor"
       
    private IEnumerable<TC_Data> tc_Data = null;
    private string postDataResponse = string.Empty;
    private string searchItem;

    IFileListEntry file;

    async Task HandleFileSelected(IFileListEntry[] files)
    {
        file = files.FirstOrDefault();
        if (file != null)
        {
            await fileUpload.UploadAsync(file);                        
        }
    }

    async Task PostData()
    {
        postDataResponse = await _webApi3Service.PostData();
    }
    
    async Task LoadData()
    {
        tc_Data = await _webApi3Service.LoadData();        
    }

    async Task SearchItem()
    {
        tc_Data = await _webApi3Service.Search(searchItem);
    }

    //protected override async Task OnInitializedAsync()
    //{
    //    await base.OnInitializedAsync();
    //    TC_Data = await _webApi1Service.LoadData();
    //}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload fileUpload { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebApi3Service _webApi3Service { get; set; }
    }
}
#pragma warning restore 1591
