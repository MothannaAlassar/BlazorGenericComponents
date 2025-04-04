// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorGenericComponents.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\SharedApps\GitHub\BlazorGenericComponents\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\SharedApps\GitHub\BlazorGenericComponents\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\SharedApps\GitHub\BlazorGenericComponents\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\SharedApps\GitHub\BlazorGenericComponents\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\SharedApps\GitHub\BlazorGenericComponents\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\SharedApps\GitHub\BlazorGenericComponents\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\SharedApps\GitHub\BlazorGenericComponents\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\SharedApps\GitHub\BlazorGenericComponents\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\SharedApps\GitHub\BlazorGenericComponents\_Imports.razor"
using BlazorGenericComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\SharedApps\GitHub\BlazorGenericComponents\_Imports.razor"
using BlazorGenericComponents.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\SharedApps\GitHub\BlazorGenericComponents\_Imports.razor"
using BlazorGenericComponents.Helpers;

#line default
#line hidden
#nullable disable
    public partial class GenericChart : BaseComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\GenericChart.razor"
       
    [Parameter] public string ChartType { get; set; } = "bar";
    [Parameter] public string ChartTitle { get; set; } = "";
    [Parameter] public List<ViewModels.ChartViewModel> Data { get; set; } = new List<ViewModels.ChartViewModel>();
    //private string[] backgroundColors = {
    //    "rgba(255, 99, 132, 0.2)", // Color for the first bar
    //    "rgba(54, 162, 235, 0.2)", // Color for the second bar
    //    "rgba(255, 206, 86, 0.2)", // Color for the third bar
    //    "rgba(75, 192, 192, 0.2)", // Color for the fourth bar
    //    "rgba(153, 102, 255, 0.2)" // Color for the fifth bar
    //};
    //private string[] labels = { "January", "February", "March", "April", "May" };

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            try
            {
                if (Data != null && Data.Count > 0)
                {
                    //int cnt = 92;
                    foreach (var d in Data?.Where(a => string.IsNullOrEmpty(a.BackgroundColor)))
                    {
                        var r = new Random().Next(99, 255);
                        d.BackgroundColor = $"rgba(255, {r}, 132, 0.9)";
                    }

                    await JSRuntime.InvokeVoidAsync("createChart", Data?.Select(a => a.Label)?.ToArray(), Data?.Select(a => a.Value)?.ToArray(), ChartType, Data?.Select(a => a.BackgroundColor)?.ToArray(), ChartTitle);
                }
            }
            catch (Exception ex)
            {
                AddErrorLog(ex);
            }

        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
