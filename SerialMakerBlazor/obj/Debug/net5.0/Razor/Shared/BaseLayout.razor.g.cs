#pragma checksum "E:\SharedApps\GitHub\SerialMakerBlazor\Shared\BaseLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99f866a01c134dd57bd00b8d9a60e9b1e8f629df"
// <auto-generated/>
#pragma warning disable 1591
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
    public partial class BaseLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<!DOCTYPE html>\r\n");
            __builder.OpenElement(1, "html");
            __builder.AddAttribute(2, "lang", "en");
            __builder.AddMarkupContent(3, @"<head><meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Access Denied</title>
    <style>
        .container {
            text-align: center;
            margin-top: 100px;
        }

        h1 {
            font-size: 5rem;
            color: #dc3545; /* Bootstrap danger color */
        }

        p {
            font-size: 1.25rem;
        }
    </style></head>
");
            __builder.OpenElement(4, "body");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "container");
            __builder.AddContent(7, 
#nullable restore
#line 28 "E:\SharedApps\GitHub\SerialMakerBlazor\Shared\BaseLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
