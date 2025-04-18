#pragma checksum "E:\SharedApps\GitHub\BlazorGenericComponents\Components\StatisticsCardRow.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bbaeb23787287cfbf8a042285ef8a90c72a9e12"
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
    public partial class StatisticsCardRow : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "statistics-card-row");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "statistics-card-heading");
            __builder.OpenElement(4, "h4");
            __builder.AddContent(5, 
#nullable restore
#line 6 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\StatisticsCardRow.razor"
             Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row");
#nullable restore
#line 9 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\StatisticsCardRow.razor"
         if (CardItems != null && CardItems.Count > 0)
        {
            int cont = 1;
            
            foreach (var itm in CardItems)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-lg-3 col-xs-6");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "statistics-card-box");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "statistics-bg-" + (
#nullable restore
#line 17 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\StatisticsCardRow.razor"
                                               cont

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 18 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\StatisticsCardRow.razor"
                         if (!string.IsNullOrEmpty(itm.Link))
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "small-box small-box-custom");
            __builder.AddAttribute(17, "style", "cursor:pointer;");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\StatisticsCardRow.razor"
                                                                                                        ()=>{navigat.NavigateTo(itm.Link);}

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 21 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\StatisticsCardRow.razor"
                                 if (!string.IsNullOrEmpty(itm.FontSize))
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "style", "font-size:" + (
#nullable restore
#line 23 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\StatisticsCardRow.razor"
                                                           itm.FontSize

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "class", "static-counter-title");
            __builder.AddContent(22, 
#nullable restore
#line 24 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\StatisticsCardRow.razor"
                                         itm.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 26 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\StatisticsCardRow.razor"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "static-counter-title");
            __builder.AddContent(25, 
#nullable restore
#line 30 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\StatisticsCardRow.razor"
                                         itm.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 32 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\StatisticsCardRow.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "static-counter-num");
            __builder.AddContent(28, 
#nullable restore
#line 35 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\StatisticsCardRow.razor"
                                                                 itm.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\StatisticsCardRow.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "small-box small-box-custom");
#nullable restore
#line 41 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\StatisticsCardRow.razor"
                                 if (!string.IsNullOrEmpty(itm.FontSize))
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "style", "font-size:" + (
#nullable restore
#line 43 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\StatisticsCardRow.razor"
                                                           itm.FontSize

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "class", "static-counter-title");
            __builder.AddContent(34, 
#nullable restore
#line 44 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\StatisticsCardRow.razor"
                                         itm.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 46 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\StatisticsCardRow.razor"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "static-counter-title");
            __builder.AddContent(37, 
#nullable restore
#line 50 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\StatisticsCardRow.razor"
                                         itm.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 52 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\StatisticsCardRow.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "static-counter-num");
            __builder.AddContent(40, 
#nullable restore
#line 55 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\StatisticsCardRow.razor"
                                                                 itm.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 57 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\StatisticsCardRow.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 62 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\StatisticsCardRow.razor"
                if(cont>=3)
                {
                    cont = 0;
                }
                cont++;
            }
           
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\StatisticsCardRow.razor"
       
    [Parameter] public List<ViewModels.CardViewModel> CardItems { get; set; }
    [Parameter] public string Title { get; set; }

   

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigat { get; set; }
    }
}
#pragma warning restore 1591
