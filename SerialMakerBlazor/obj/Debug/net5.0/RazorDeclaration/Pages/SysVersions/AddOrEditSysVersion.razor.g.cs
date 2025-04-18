// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SerialMakerBlazor.Pages.SysVersions
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\SharedApps\GitHub\SerialMakerBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\SharedApps\GitHub\SerialMakerBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\SharedApps\GitHub\SerialMakerBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\SharedApps\GitHub\SerialMakerBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\SharedApps\GitHub\SerialMakerBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\SharedApps\GitHub\SerialMakerBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\SharedApps\GitHub\SerialMakerBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\SharedApps\GitHub\SerialMakerBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\SharedApps\GitHub\SerialMakerBlazor\_Imports.razor"
using SerialMakerBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\SharedApps\GitHub\SerialMakerBlazor\_Imports.razor"
using SerialMakerBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\SharedApps\GitHub\SerialMakerBlazor\_Imports.razor"
using SerialMakerBlazor.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\SharedApps\GitHub\SerialMakerBlazor\_Imports.razor"
using BlazorGenericComponents.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\SharedApps\GitHub\SerialMakerBlazor\_Imports.razor"
using BlazorGenericComponents.Helpers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addeditsysversion/{Id:int}")]
    public partial class AddOrEditSysVersion : Components.BaseBasicCertComponent<Models.SysVersion, Models.SysVersion>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 86 "E:\SharedApps\GitHub\SerialMakerBlazor\Pages\SysVersions\AddOrEditSysVersion.razor"
       
    [Parameter] public int Id { get; set; }
    private List<Models.SystemType> systemTypes = new();
    protected async override Task OnInitializedAsync()
    {
        try
        {
            if (Id > 0)
                CurrentObject = await CurrentService.GetByIdAsync(Id);
            if (CurrentObject == null)
            {
                CurrentObject = new Models.SysVersion();
                AddingNew();
            }
            if (CurrentObject.ID > 0)
            {
                Editing(CurrentObject);
            }
            var sys = await systemTypeService.GetAllAsync();
            systemTypes = sys?.ToList();
            isModalVisible = true;
        }
        catch (Exception ex)
        {
            AddErrorLog(ex);
        }
        IsLoading = false;
    }
    protected override void AddingNew()
    {
        CurrentObject = new Models.SysVersion();
        modalTitle = Tralnslate?.GetTranslation("Add System Version");
        modalButtonText = Tralnslate?.GetTranslation("Add");
    }
    protected override void Editing(Models.SysVersion obj)
    {
        base.Editing(obj);
        CurrentObject = obj;
        modalTitle = Tralnslate?.GetTranslation("Edit System Version");
        modalButtonText = Tralnslate?.GetTranslation("Update");
    }
    private bool IsProcessing = false;
    private async Task SaveData()
    {
        try
        {
            IsLoading = true;
            var prvname = CurrentService.GetAll()?.Where(a => a.VersionName.Trim() == CurrentObject.VersionName.Trim() && a.ID != CurrentObject.ID)?.FirstOrDefault();
            if (prvname != null && prvname.ID > 0)
            {
                validationMessage = Tralnslate?.GetTranslation("this name of this record is already exist try another name ");
                return;
            }
            else
            {
                validationMessage = "";
            }
            if (CurrentObject.ID == 0)
            {
                CurrentObject.CreatedDate = GetSystemDate();
                CurrentObject.CreatedUser = await GetUserIdAsync();
                await CurrentService.AddAsync(CurrentObject);
            }
            else
            {
                CurrentObject.UpdatedDate = GetSystemDate();
                CurrentObject.UpdatedUser = await GetUserIdAsync();
                await CurrentService.UpdateAsync(CurrentObject.ID, CurrentObject);
            }
            isModalVisible = false; // Hide the modal
            IsLoading = true;

            await GoToBackPageAsync();
        }
        catch (Exception ex)
        {
            AddErrorLog(ex);
            validationMessage = ex?.Message;
        }
        IsProcessing = false;
        IsLoading = false;
    }
    private void HandleInvalidSubmit()
    {
        // This will trigger if the form validation fails.
        Console.WriteLine("Form submission is invalid.");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Repositories.IGenericRepo<Models.SystemType> systemTypeService { get; set; }
    }
}
#pragma warning restore 1591
