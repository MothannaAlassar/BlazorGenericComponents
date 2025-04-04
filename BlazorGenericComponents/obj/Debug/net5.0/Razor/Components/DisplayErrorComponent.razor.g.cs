#pragma checksum "E:\SharedApps\GitHub\BlazorGenericComponents\Components\DisplayErrorComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42b77030be9129c66ee4a01d1dc8fb6e959ed3ef"
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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(Shared.BaseGenericCustomLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/error")]
    public partial class DisplayErrorComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<img src=\"Imgs/error-404.png\" alt=\"nasServerApp\" style=\"height:160px;\">\r\n    ");
            __builder.AddMarkupContent(1, "<h1>Oops! Something Went Wrong</h1>\r\n    ");
            __builder.AddMarkupContent(2, "<p>We are sorry for the inconvenience. Please try again later or contact support.</p>\r\n    ");
            __builder.OpenElement(3, "a");
            __builder.AddAttribute(4, "href", 
#nullable restore
#line 8 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\DisplayErrorComponent.razor"
              baseUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(5, "Go Back Home");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "a");
            __builder.AddAttribute(8, "style", "color:blue");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\DisplayErrorComponent.razor"
                                    Reload

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(10, "Reload");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\DisplayErrorComponent.razor"
           

        private string baseUrl;
        protected override void OnInitialized()
        {
            baseUrl = navigation.BaseUri.TrimEnd('/');
            base.OnInitialized();
        }
        private void Reload()
        {
            try
            {

                navigation.NavigateTo(navigation.Uri, true);
            }
            catch (Exception)
            {

            }
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
    }
}
#pragma warning restore 1591
