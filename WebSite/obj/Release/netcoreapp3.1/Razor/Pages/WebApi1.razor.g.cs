#pragma checksum "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi1.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb6fe26ddf17b3619396ef1e8eab5af69173ed33"
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
#line 1 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\_Imports.razor"
using WebSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\_Imports.razor"
using WebSite.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\_Imports.razor"
using WebSite.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\_Imports.razor"
using CommonStructures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\_Imports.razor"
using WebAPI_1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\_Imports.razor"
using WebAPI_2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\_Imports.razor"
using WebAPI_3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\_Imports.razor"
using WebAPI_4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/webapi1")]
    public partial class WebApi1 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Select the initial TC File Input</h3>\r\n");
            __builder.OpenComponent<BlazorInputFile.InputFile>(1);
            __builder.AddAttribute(2, "OnChange", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 6 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi1.razor"
                     HandleFileSelected

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n<br>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi1.razor"
 if (file != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "p");
            __builder.AddContent(6, "Name: ");
#nullable restore
#line 11 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi1.razor"
__builder.AddContent(7, file.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "p");
            __builder.AddContent(10, "Size in Bytes: ");
#nullable restore
#line 12 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi1.razor"
__builder.AddContent(11, file.Size);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "p");
            __builder.AddContent(14, "File type: ");
#nullable restore
#line 13 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi1.razor"
__builder.AddContent(15, file.Type);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 14 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi1.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(17, "<br>\r\n\r\n\r\n");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi1.razor"
                  PostData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(20, "Post Data to API 1");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n<br>\r\n");
            __builder.AddMarkupContent(22, "<h3>Response from API 1</h3>\r\n");
#nullable restore
#line 51 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi1.razor"
 if (string.IsNullOrWhiteSpace(postDataResponse))
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "    ");
            __builder.AddMarkupContent(24, "<h5>loading data...</h5>\r\n");
#nullable restore
#line 54 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi1.razor"
} else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(25, "    ");
            __builder.OpenElement(26, "h5");
#nullable restore
#line 56 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi1.razor"
__builder.AddContent(27, postDataResponse);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
#nullable restore
#line 57 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi1.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(29, "<br>\r\n\r\n");
            __builder.AddMarkupContent(30, "<h2>Load Data</h2>\r\n<br>\r\n");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi1.razor"
                  LoadData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(33, "Load Data");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n<br>\r\n");
#nullable restore
#line 64 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi1.razor"
 if (TC_Data == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "    ");
            __builder.AddMarkupContent(36, "<h4>loading data...</h4>\r\n");
#nullable restore
#line 67 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi1.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi1.razor"
     if (TC_Data.Any())
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(37, "        ");
            __builder.OpenElement(38, "table");
            __builder.AddAttribute(39, "class", "table");
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.AddMarkupContent(41, @"<thead>
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
            __builder.OpenElement(42, "tbody");
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 90 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi1.razor"
             foreach (var item in TC_Data)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(44, "                ");
            __builder.OpenElement(45, "tr");
            __builder.AddMarkupContent(46, "\r\n                    ");
            __builder.OpenElement(47, "td");
#nullable restore
#line 93 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi1.razor"
__builder.AddContent(48, item?.RecallNumber?.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                    ");
            __builder.OpenElement(50, "td");
#nullable restore
#line 94 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi1.razor"
__builder.AddContent(51, item?.ManufactureName?.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                    ");
            __builder.OpenElement(53, "td");
#nullable restore
#line 95 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi1.razor"
__builder.AddContent(54, item?.MakeName?.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                    ");
            __builder.OpenElement(56, "td");
#nullable restore
#line 96 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi1.razor"
__builder.AddContent(57, item?.ModelName?.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                    ");
            __builder.OpenElement(59, "td");
#nullable restore
#line 97 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi1.razor"
__builder.AddContent(60, item?.RecallYear?.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                    ");
            __builder.OpenElement(62, "td");
#nullable restore
#line 98 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi1.razor"
__builder.AddContent(63, item?.ManufacturerRecallNumber?.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                    ");
            __builder.OpenElement(65, "td");
#nullable restore
#line 99 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi1.razor"
__builder.AddContent(66, item?.CategoryETXT?.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                    ");
            __builder.OpenElement(68, "td");
#nullable restore
#line 100 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi1.razor"
__builder.AddContent(69, item?.CategoryFTXT?.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                    ");
            __builder.OpenElement(71, "td");
#nullable restore
#line 101 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi1.razor"
__builder.AddContent(72, item?.SystemTypeETXT?.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                    ");
            __builder.OpenElement(74, "td");
#nullable restore
#line 102 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi1.razor"
__builder.AddContent(75, item?.SystemTypeFTXT?.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                    ");
            __builder.OpenElement(77, "td");
#nullable restore
#line 103 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi1.razor"
__builder.AddContent(78, item?.NotificationTypeETXT?.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                    ");
            __builder.OpenElement(80, "td");
#nullable restore
#line 104 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi1.razor"
__builder.AddContent(81, item?.NotificationTypeFTXT?.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n");
#nullable restore
#line 106 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi1.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(84, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n");
#nullable restore
#line 109 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi1.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi1.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi1.razor"
       
    private string postDataResponse = string.Empty;
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
        postDataResponse = await _webApi1Service.PostData();
    }

    private IEnumerable<TC_Data> TC_Data = null;

    async Task LoadData()
    {
        TC_Data = await _webApi1Service.LoadData();        
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebApi1Service _webApi1Service { get; set; }
    }
}
#pragma warning restore 1591
