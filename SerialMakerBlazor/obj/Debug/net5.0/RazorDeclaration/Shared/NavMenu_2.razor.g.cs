// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SerialMakerBlazor.Shared
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
    public partial class NavMenu_2 : BlazorGenericComponents.Components.BaseComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 495 "E:\SharedApps\GitHub\SerialMakerBlazor\Shared\NavMenu_2.razor"
               

            private bool showIconsOnly = false;
            private string width = "250px";
            private void ToggleIconDisplay()
            {
                showIconsOnly = !showIconsOnly;
            }

            private bool collapseNavMenu = true;
            private List<string>
            menus = new List<string>
                { "Internet Plan", "Network", "Radius", "Service", "Clients", "Reports",
        "Microtik Monitor", "Manage Users","Accounts Inputs","Account Operations","Account Reports","Application settings" };
            private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

            private void ToggleNavMenu()
            {
                collapseNavMenu = !collapseNavMenu;
            }
            private bool isCategory1Expanded;
            private bool isCategory2Expanded;
            private string ExpanderCategory;

            private void ToggleExpandCategory1()
            {
                isCategory1Expanded = !isCategory1Expanded;
            }

            private void ToggleExpandCategory2()
            {
                isCategory2Expanded = !isCategory2Expanded;
            }
            private void ToggleExpand(string title)
            {
                if (title != ExpanderCategory)
                {
                    if (isCategory1Expanded)
                        isCategory1Expanded = !isCategory1Expanded;
                }
                ExpanderCategory = title;
                isCategory1Expanded = !isCategory1Expanded;
                collapseNavMenu = !collapseNavMenu;
            }

        

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
