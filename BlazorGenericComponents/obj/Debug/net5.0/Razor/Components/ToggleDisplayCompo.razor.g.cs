#pragma checksum "E:\SharedApps\GitHub\BlazorGenericComponents\Components\ToggleDisplayCompo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c337dd2f9e780cc75cd904aa8149a55ff025fc5a"
// <auto-generated/>
#pragma warning disable 1591
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
    public partial class ToggleDisplayCompo : Components.BaseComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card mb-3");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card-header d-flex justify-content-between align-items-center");
            __builder.OpenElement(4, "h5");
            __builder.AddContent(5, 
#nullable restore
#line 5 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\ToggleDisplayCompo.razor"
             Tralnslate?.GetTranslation("Global Sumry")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\n        ");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "class", "btn btn-outline-secondary");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\ToggleDisplayCompo.razor"
                                                            ToggleGlobalSumry

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 7 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\ToggleDisplayCompo.razor"
             if (ShowGlobalSumry)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(10, "<span class=\"oi oi-minus\"></span>");
#nullable restore
#line 9 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\ToggleDisplayCompo.razor"
                                                              }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(11, "<span class=\"oi oi-plus\"></span>");
#nullable restore
#line 12 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\ToggleDisplayCompo.razor"
                                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 15 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\ToggleDisplayCompo.razor"
     if (ShowGlobalSumry)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, 
#nullable restore
#line 17 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\ToggleDisplayCompo.razor"
         Content

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 17 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\ToggleDisplayCompo.razor"
                
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\ToggleDisplayCompo.razor"
       private bool ShowGlobalSumry = false;
            [Parameter]
            public RenderFragment Content { get; set; }
            private void ToggleGlobalSumry()
            {
                ShowGlobalSumry = !ShowGlobalSumry; // Toggle visibility
            } 

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
