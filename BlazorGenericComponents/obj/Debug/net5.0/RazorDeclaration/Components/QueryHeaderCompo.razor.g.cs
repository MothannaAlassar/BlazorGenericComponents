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
#nullable restore
#line 3 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\QueryHeaderCompo.razor"
using System.Reflection;

#line default
#line hidden
#nullable disable
    public partial class QueryHeaderCompo<TItem> : Components.BaseComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\QueryHeaderCompo.razor"
       
    //[Parameter] public QueryBuilder<TItem> QueryBuilder { get; set; }
    [Parameter] public EventCallback<bool> OnClearFilter { get; set; }
    [Parameter] public EventCallback<bool> OnExecuteFilter { get; set; }
    private void ExecuteFilter() => OnExecuteFilter.InvokeAsync(true);
    private void ClearFilter() => OnClearFilter.InvokeAsync(false);

    private bool showQueryBuilder = false;



    //here copy code from Query builder
    private string les = "<";
    public class QueryF
    {
        public string Field { get; set; } = string.Empty;
        public string Operator { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
    }


    private List<QueryF> queries = new List<QueryF>();

    private void AddQuery()
    {
        queries.Add(new QueryF());
    }
    private void RemoveQuery(QueryF query)
    {
        queries.Remove(query);
    }
    public IEnumerable<QueryF> GetQueries() => queries;

    public void ClearQueries() // Method to clear all queries
    {
        queries.Clear();
    }

    private IEnumerable<string> GetPropertyNames()
    {

        return typeof(TItem).GetProperties(BindingFlags.Public | BindingFlags.Instance)
        .Select(prop => prop.Name);
    }
    private Type GetType(string name)
    {
        var t = typeof(TItem).GetProperties(BindingFlags.Public | BindingFlags.Instance)?.Where(a => a.Name == name)
        .Select(prop => prop.PropertyType)?.FirstOrDefault();
        return t;
    }
    //end copy code from Query builder



    private void ToggleQueryBuilder()
    {
        showQueryBuilder = !showQueryBuilder; // Toggle visibility
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
