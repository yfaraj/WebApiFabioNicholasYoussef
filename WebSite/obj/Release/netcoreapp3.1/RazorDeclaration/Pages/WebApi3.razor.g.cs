// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/webapi3")]
    public partial class WebApi3 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 111 "C:\Users\Utilisateur\Documents\Transport Canada\WebApiFabioNicholasYoussef\WebSite\Pages\WebApi3.razor"
       
    private IEnumerable<TC_Data> tc_Data = null;
    private bool IsLoadingData = false;
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
        IsLoadingData = true;
        tc_Data = await _webApi3Service.LoadData();        
    }

    async Task SearchItem()
    {
        tc_Data = await _webApi3Service.Search(searchItem);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload fileUpload { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebApi3Service _webApi3Service { get; set; }
    }
}
#pragma warning restore 1591
