// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SerialMakerBlazor.Pages.ClientVersions
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/clientversions")]
    public partial class Index : Components.BaseBasicCertComponent<Models.ClientVersion, Models.Views.VClientVersion>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "E:\SharedApps\GitHub\SerialMakerBlazor\Pages\ClientVersions\Index.razor"
       

    private async Task LoadingDataAsync()
    {
        Items = await CurrentShowService.GetAllAsync();

    }
    private void SetIntialData()
    {
        Columns = new List<GridColumn<Models.Views.VClientVersion>>();
        Columns.Add(new GridColumn<Models.Views.VClientVersion>
        {
            Title = Tralnslate?.GetTranslation("ID"),
            Name = nameof(Models.Views.VClientVersion.ID),
            PropertySelector = p => p.ID,

        });
        Columns.Add(
        new GridColumn<Models.Views.VClientVersion>
        {
            Title = Tralnslate?.GetTranslation("ClientName"),
            Name = nameof(Models.Views.VClientVersion.ClientName),
            PropertySelector = p => p.ClientName,
        });

        Columns.Add(new GridColumn<Models.Views.VClientVersion>
        {
            Title = Tralnslate?.GetTranslation("SysName"),
            Name = nameof(Models.Views.VClientVersion.SysName),
            PropertySelector = p => p.SysName,
        });
        Columns.Add(new GridColumn<Models.Views.VClientVersion>
        {
            Title = Tralnslate?.GetTranslation("VersionName"),
            Name = nameof(Models.Views.VClientVersion.VersionName),
            PropertySelector = p => p.VersionName,
        });
        Columns.Add(new GridColumn<Models.Views.VClientVersion>
        {
            Title = Tralnslate?.GetTranslation("VersionNumber"),
            Name = nameof(Models.Views.VClientVersion.VersionNumber),
            PropertySelector = p => p.VersionNumber,
        });
        Columns.Add(new GridColumn<Models.Views.VClientVersion>
        {
            Title = Tralnslate?.GetTranslation("TypeInstallation"),
            Name = nameof(Models.Views.VClientVersion.TypeInstallation),
            PropertySelector = p => p.TypeInstallation,
        });
        Columns.Add(new GridColumn<Models.Views.VClientVersion>
        {
            Title = Tralnslate?.GetTranslation("TypeLicence"),
            Name = nameof(Models.Views.VClientVersion.TypeLicence),
            PropertySelector = p => p.TypeLicence,
        });
        Columns.Add(new GridColumn<Models.Views.VClientVersion>
        {
            Title = Tralnslate?.GetTranslation("CreatedDate"),
            Name = nameof(Models.Views.VClientVersion.CreatedDate),
            PropertySelector = p => p.CreatedDate,
        });
        TableActions = new List<TableAction<Models.Views.VClientVersion>>
{

            new TableAction<Models.Views.VClientVersion>
            {
                Name = "Edit",
                Title = "Edit",
                Action = item => { NavigateToWithBaseUrl($"addeditclientversion/{item.ID}"); /*ShowEditModal(item);*/ return Task.CompletedTask; }, // Call void function
                IsVisible = true // Set visibility based on your logic
            },
            new TableAction<Models.Views.VClientVersion>
            {
                Name = "Delete",
                Title = "Delete",
                Action = item =>{ShowConfirmation(item.ID); return Task.CompletedTask; },
                IsVisible = true // Change to false if you want to hide this action
            }

        };
    }
    protected async override Task OnInitializedAsync()
    {
        try
        {
            CurrentObject = new Models.ClientVersion();
            IsLoading = true;
            // await Task.Delay(5000);
            await LoadingDataAsync();
            SetIntialData();
            await ExecuteQuery();
        }
        catch (Exception ex)
        {

            AddErrorLog(ex);
        }
        IsLoading = false;
    }
    protected override void AddingNew()
    {
        CurrentObject = new Models.ClientVersion();
        modalTitle = Tralnslate?.GetTranslation("Add Version");
        modalButtonText = Tralnslate?.GetTranslation("Add");
    }
    protected override void Editing(Models.Views.VClientVersion obj)
    {
        base.Editing(obj);
        var crnt = CurrentService.GetAll(a => a.ID == obj.ID)?.FirstOrDefault();
        CurrentObject = crnt;
        modalTitle = Tralnslate?.GetTranslation("Edit Version");
        modalButtonText = Tralnslate?.GetTranslation("Update");
    }
    protected override async Task DeleteItemAsync(object id)
    {
        validationMessage = "";

        try
        {
            var ID = Convert.ToInt32(id);
            var rtv = await CurrentService.GetByIdAsync(ID);

            if (rtv != null)
            {
                await base.DeleteItemAsync(ID);
            }
            await LoadingDataAsync();
            await RefreshListAsync();
        }
        catch (Exception ex)
        {
            AddErrorLog(ex);
        }

        IsLoading = false;
    }
    private bool IsProcessing = false;
    private async Task SaveData()
    {
        try
        {

            //var prvname = CurrentService.GetAll()?.Where(a => a.Name.Trim() == CurrentObject.Name.Trim() && a.ID != CurrentObject.ID)?.FirstOrDefault();
            //if (prvname != null && prvname.ID > 0)
            //{
            //    validationMessage = Tralnslate?.GetTranslation("this name of this record is already exist try another name ");
            //    return;
            //}
            //else
            //{
            //    validationMessage = "";
            //}
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
            await LoadingDataAsync();
            await RefreshListAsync();
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
    }
}
#pragma warning restore 1591
