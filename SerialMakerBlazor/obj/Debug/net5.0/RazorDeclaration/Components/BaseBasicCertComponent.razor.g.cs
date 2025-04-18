// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SerialMakerBlazor.Components
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
#nullable restore
#line 6 "E:\SharedApps\GitHub\SerialMakerBlazor\Components\BaseBasicCertComponent.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\SharedApps\GitHub\SerialMakerBlazor\Components\BaseBasicCertComponent.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    public partial class BaseBasicCertComponent<TItem, ShowItem> : BlazorGenericComponents.Components.BaseBasicGenericCertComponent<TItem, ShowItem>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "E:\SharedApps\GitHub\SerialMakerBlazor\Components\BaseBasicCertComponent.razor"
       



    protected Repositories.IGenericRepo<TItem> CurrentService => currentService;
    protected Repositories.IGenericRepo<ShowItem> CurrentShowService => currentShowService;


    protected async Task GoToBackPageAsync()
    {
        await JSRuntime.InvokeVoidAsync("goBack");
    }

    protected virtual async Task AddAsync(TItem item)
    {
        try
        {
            await currentService.AddAsync(item);
            isModalVisible = false; // Hide the modal
            await RefreshListAsync();
        }
        catch (Exception ex)
        {
            AddErrorLog(ex);
            validationMessage = ex?.Message;
        }
    }
    protected virtual async Task UpdateAsync(object primaryKey, TItem item)
    {
        try
        {
            var iseditAlloed = IsEditAllowed();
            if (!iseditAlloed.val)
            {
                if (!string.IsNullOrEmpty(iseditAlloed.msg))
                    validationMessage = iseditAlloed.msg;
                else
                    validationMessage = Tralnslate?.GetTranslation("the edit Operation is Not Allowed");
            }
            else
            {
                await currentService.UpdateAsync(primaryKey, item);
                isModalVisible = false; // Hide the modal
                await RefreshListAsync();
            }
        }
        catch (Exception ex)
        {
            AddErrorLog(ex);
            validationMessage = ex?.Message;
        }
    }

    protected virtual async Task DeleteItem()
    {
        try
        {
            // Your logic to delete the item using itemToDeleteId
            // For example: await itemService.DeleteItemAsync(itemToDeleteId);
            var isdeletAllowed = IsDeleteAllowed();
            if (!isdeletAllowed.val)
            {
                if (!string.IsNullOrEmpty(isdeletAllowed.msg))
                    validationMessage = isdeletAllowed.msg;
                else
                    validationMessage = Tralnslate?.GetTranslation("the Delete Operation is Not Allowed");
                MessageType = BlazorGenericComponents.Helpers.MessageType.Warning;
                //return;
            }
            else
            {
                if (!string.IsNullOrEmpty(itemGuidToDeleteId))
                    await DeleteItemAsync(itemGuidToDeleteId);
                else
                    await DeleteItemAsync(itemToDeleteId);
            }
            showConfirmation = false; // Close the dialog after deletion
        }
        catch (Exception ex)
        {
            AddErrorLog(ex);
        }

    }
    protected virtual (bool val, string msg) IsDeleteAllowed()
    {
        return (true, "");
    }
    protected virtual (bool val, string msg) IsEditAllowed()
    {
        return (true, "");
    }
    protected virtual async Task<(bool val, string msg)> IsEditAllowedAsync()
    {
        return await Task.FromResult((true, ""));
    }
    protected virtual async Task DeleteItemAsync(object id)
    {
        await currentService.DeleteAsync(id);
        await RefreshListAsync();
    }

    protected virtual void CancelDelete()
    {
        showConfirmation = false; // Close the dialog without deleting
    }
    protected override void ShowConfirmation(int itemId)
    {
        itemToDeleteId = itemId;
        showConfirmation = true;
        StateHasChanged();
    }
    protected override void ShowConfirmation(ShowItem item)
    {
        Deleting(item);
        var isDeleteAllowed = IsDeleteAllowed();
        if (!isDeleteAllowed.val)
        {
            if (!string.IsNullOrEmpty(isDeleteAllowed.msg))
                validationMessage = isDeleteAllowed.msg;
            else
                validationMessage = Tralnslate?.GetTranslation("the delete Operation is Not Allowed");
            MessageType = BlazorGenericComponents.Helpers.MessageType.Warning;
            StateHasChanged();
            return;
        }
        else
        {
            showConfirmation = true;
        }
        StateHasChanged();
    }
    protected override void ShowConfirmation(long itemId)
    {
        itemToDeleteId = itemId;
        showConfirmation = true;
        StateHasChanged();
    }
    protected override void ShowConfirmation(string itemId)
    {
        itemGuidToDeleteId = itemId;
        showConfirmation = true;
        StateHasChanged();
    }

    /// <summary>
    /// this method will invoked befor show the Add popup
    /// </summary>
    protected virtual void AddingNew()
    {
        modalTitle = "Add";
        modalButtonText = "Add";
    }
    protected virtual void AddingNew(TItem item)
    {
        modalTitle = "Add";
        modalButtonText = "Add";
    }
    protected override void ShowAddModal()
    {
        //CurrentObject = new TItem; // Reset for new item
        validationMessage = "";
        AddingNew();

        isModalVisible = true;
        modalClass = "show"; // Show the modal
    }
    protected override void ShowAddModal(TItem item)
    {
        validationMessage = "";
        //CurrentObject = new TItem; // Reset for new item
        AddingNew(item);

        isModalVisible = true;
        modalClass = "show"; // Show the modal
        StateHasChanged();
    }
    protected override void HideModal()
    {
        isModalVisible = false;
    }
    protected virtual void Deleting(ShowItem obj)
    {
        modalTitle = "Edit";
        modalButtonText = "Update";
    }
    /// <summary>
    /// this method will invoked befor show the edit popup
    /// </summary>

    protected virtual void Editing(ShowItem obj)
    {
        modalTitle = "Edit";
        modalButtonText = "Update";
    }
    protected override void ShowEditModal(ShowItem obj)
    {
        validationMessage = "";
        Editing(obj);
        //CurrentObject = obj;
        var iseditAllowed = IsEditAllowed();
        if (!iseditAllowed.val)
        {
            if (!string.IsNullOrEmpty(iseditAllowed.msg))
                validationMessage = iseditAllowed.msg;
            else
                validationMessage = "the edit Operation is Not Allowed";
            MessageType = BlazorGenericComponents.Helpers.MessageType.Warning;
            StateHasChanged();
            return;
        }
        else
        {
            isModalVisible = true;
            modalClass = "show"; // Show the modal
        }
        StateHasChanged();
    }
    protected virtual void RefreshAfterExecuteQuery()
    {

    }
    //for builder query
    protected override async Task ExecuteQuery()
    {
        try
        {
            IsLoading = true;
            //await SearchData();
            await base.ExecuteQuery();
            RefreshAfterExecuteQuery();
            StateHasChanged();
            IsLoading = false;
        }
        catch (Exception ex)
        {
            AddErrorLog(ex);
        }

    }
    // private IEnumerable<Na> FilteredItems => items?.OrderBy(p => ascending ? p.GetType().GetProperty(sortColumn)?.GetValue(p, null) : null)
    //    .ThenByDescending(p => !ascending ? p.GetType().GetProperty(sortColumn)?.GetValue(p, null) : null);


    protected override void ToggleQueryBuilder()
    {
        showQueryBuilder = !showQueryBuilder; // Toggle visibility
    }


    protected override async Task ClearFilters()
    {
        IsLoading = true;
        await base.ClearFilters();
        RefreshAfterExecuteQuery();
        StateHasChanged();
        IsLoading = false;
    }
    //end build query

    protected async Task<Data.AppUser> GetUserDataAsync()
    {
        var user = await _userManager.GetUserAsync(HttpContextAccessor.HttpContext.User);

        return user;
    }
    protected async Task<string> GetUserIdAsync()
    {
        var user = await _userManager.GetUserAsync(HttpContextAccessor.HttpContext.User);

        return user?.Id;
    }
    //protected bool IsInRole(string roleName)
    //{
    //    var rtv = HttpContextAccessor.HttpContext.User.IsInRole(roleName);
    //    return rtv;
    //}

    //protected bool IsAdimin => IsInRole("Admin");
    //protected bool IsManager => IsInRole("Manager");
    //protected bool IsAccountant => IsInRole("Accountant");


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<Data.AppUser> _userManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor HttpContextAccessor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Repositories.IGenericRepo<ShowItem> currentShowService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Repositories.IGenericRepo<TItem> currentService { get; set; }
    }
}
#pragma warning restore 1591
