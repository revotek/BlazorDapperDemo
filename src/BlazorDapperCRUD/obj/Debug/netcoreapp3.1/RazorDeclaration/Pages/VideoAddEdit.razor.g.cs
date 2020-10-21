#pragma checksum "C:\Projects\BlazorDapperCRUD\BlazorDapperCRUD\Pages\VideoAddEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e9c4755bbd0416b077cc7ba82b78533713a1d4c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorDapperCRUD.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Projects\BlazorDapperCRUD\BlazorDapperCRUD\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\BlazorDapperCRUD\BlazorDapperCRUD\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\BlazorDapperCRUD\BlazorDapperCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projects\BlazorDapperCRUD\BlazorDapperCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Projects\BlazorDapperCRUD\BlazorDapperCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Projects\BlazorDapperCRUD\BlazorDapperCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Projects\BlazorDapperCRUD\BlazorDapperCRUD\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Projects\BlazorDapperCRUD\BlazorDapperCRUD\_Imports.razor"
using BlazorDapperCRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Projects\BlazorDapperCRUD\BlazorDapperCRUD\_Imports.razor"
using BlazorDapperCRUD.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Projects\BlazorDapperCRUD\BlazorDapperCRUD\Pages\VideoAddEdit.razor"
using BlazorDapperCRUD.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/videoaddedit/{id:int}")]
    public partial class VideoAddEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Projects\BlazorDapperCRUD\BlazorDapperCRUD\Pages\VideoAddEdit.razor"
       
    Video video = new Video();

    [Parameter] public int id { get; set; }

    public string pagetitle = "Add a video";
    public string buttontext = "Add";

    protected override async Task OnInitializedAsync()
    {
        if (id == 0)
        {
            DateTime defaultDate = new DateTime(2000, 12, 31);
            video.DatePublished = defaultDate;
            video.IsActive = true;
        }
        else
        {
            video = await VideoService.Video_GetOne(id);
            pagetitle = "Edit Video";
            buttontext = "Update";

        }
    }
    protected async Task VideoSave()
    {
        if (video.VideoID == 0)
        {
            await VideoService.VideoInsert(video);

        }
        else
        {
            await VideoService.VideoUpdate(video);

        }
        NavigationManager.NavigateTo("/videolist");
    }

    void Cancel()
    {
        NavigationManager.NavigateTo("/videolist");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IVideoService VideoService { get; set; }
    }
}
#pragma warning restore 1591