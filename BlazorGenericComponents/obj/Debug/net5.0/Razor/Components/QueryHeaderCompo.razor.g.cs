#pragma checksum "E:\SharedApps\GitHub\BlazorGenericComponents\Components\QueryHeaderCompo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e56abdd4c41b9d3ea02f7d181599eb96ac0fd755"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card-header d-flex justify-content-between align-items-center");
            __builder.OpenElement(4, "h5");
            __builder.AddContent(5, 
#nullable restore
#line 7 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\QueryHeaderCompo.razor"
             Tralnslate?.GetTranslation("Filter Items")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "class", "btn btn-outline-secondary");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\QueryHeaderCompo.razor"
                                                            ToggleQueryBuilder

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 9 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\QueryHeaderCompo.razor"
             if (showQueryBuilder)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "span");
            __builder.AddContent(11, 
#nullable restore
#line 11 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\QueryHeaderCompo.razor"
                        Tralnslate?.GetTranslation("Hide")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 12 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\QueryHeaderCompo.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "span");
            __builder.AddContent(13, 
#nullable restore
#line 15 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\QueryHeaderCompo.razor"
                       Tralnslate?.GetTranslation("Show")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 16 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\QueryHeaderCompo.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 19 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\QueryHeaderCompo.razor"
     if (showQueryBuilder)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "card-body");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "query-builder-container");
            __builder.OpenElement(18, "h3");
            __builder.AddContent(19, 
#nullable restore
#line 23 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\QueryHeaderCompo.razor"
                     Tralnslate?.GetTranslation("Query Builder")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 24 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\QueryHeaderCompo.razor"
                 foreach (var query in queries)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "input-group");
            __builder.OpenElement(22, "select");
            __builder.AddAttribute(23, "class", "form-select");
            __builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\QueryHeaderCompo.razor"
                                       query.Field

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => query.Field = __value, query.Field));
            __builder.SetUpdatesAttributeName("value");
#nullable restore
#line 28 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\QueryHeaderCompo.razor"
                             foreach (var field in GetPropertyNames())
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "option");
            __builder.AddAttribute(27, "value", 
#nullable restore
#line 30 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\QueryHeaderCompo.razor"
                                                field

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(28, 
#nullable restore
#line 30 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\QueryHeaderCompo.razor"
                                                        Tralnslate?.GetTranslation(field)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 31 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\QueryHeaderCompo.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                        ");
            __builder.OpenElement(30, "select");
            __builder.AddAttribute(31, "class", "form-select");
            __builder.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\QueryHeaderCompo.razor"
                                       query.Operator

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => query.Operator = __value, query.Operator));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(34, "option");
            __builder.AddAttribute(35, "value", "=");
            __builder.AddContent(36, "=");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                            ");
            __builder.OpenElement(38, "option");
            __builder.AddAttribute(39, "value", "!=");
            __builder.AddContent(40, "!=");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                            ");
            __builder.OpenElement(42, "option");
            __builder.AddAttribute(43, "value", ">");
            __builder.AddContent(44, ">");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                            ");
            __builder.OpenElement(46, "option");
            __builder.AddAttribute(47, "value", "<");
            __builder.AddContent(48, 
#nullable restore
#line 37 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\QueryHeaderCompo.razor"
                                               les

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                            ");
            __builder.OpenElement(50, "option");
            __builder.AddAttribute(51, "value", "LIKE");
            __builder.AddContent(52, "LIKE");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\QueryHeaderCompo.razor"
                         if (GetType(query.Field) == typeof(DateTime?) || GetType(query.Field) == typeof(DateTime))
                        {
                            query.Value = DateTime.Now.ToString();

#line default
#line hidden
#nullable disable
            __builder.OpenElement(53, "input");
            __builder.AddAttribute(54, "type", "datetime");
            __builder.AddAttribute(55, "class", "form-control");
            __builder.AddAttribute(56, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 43 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\QueryHeaderCompo.razor"
                                                          query.Value

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => query.Value = __value, query.Value));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
#nullable restore
#line 44 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\QueryHeaderCompo.razor"

                        }
                        else if (GetType(query.Field) == typeof(int?) || GetType(query.Field) == typeof(int))
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(58, "input");
            __builder.AddAttribute(59, "type", "number");
            __builder.AddAttribute(60, "placeholder", "Value");
            __builder.AddAttribute(61, "class", "form-control");
            __builder.AddAttribute(62, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 48 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\QueryHeaderCompo.razor"
                                                                            query.Value

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(63, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => query.Value = __value, query.Value, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
#nullable restore
#line 49 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\QueryHeaderCompo.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(64, "input");
            __builder.AddAttribute(65, "placeholder", "Value");
            __builder.AddAttribute(66, "class", "form-control");
            __builder.AddAttribute(67, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 52 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\QueryHeaderCompo.razor"
                                                              query.Value

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(68, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => query.Value = __value, query.Value));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
#nullable restore
#line 53 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\QueryHeaderCompo.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(69, "button");
            __builder.AddAttribute(70, "class", "btn btn-danger");
            __builder.AddAttribute(71, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\QueryHeaderCompo.razor"
                                                                 () => RemoveQuery(query)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(72, 
#nullable restore
#line 55 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\QueryHeaderCompo.razor"
                                                                                            Tralnslate?.GetTranslation("Remove")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 57 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\QueryHeaderCompo.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "d-flex justify-content-between mt-3");
            __builder.OpenElement(75, "button");
            __builder.AddAttribute(76, "class", "btn btn-primary");
            __builder.AddAttribute(77, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\QueryHeaderCompo.razor"
                                                              AddQuery

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(78, 
#nullable restore
#line 59 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\QueryHeaderCompo.razor"
                                                                         Tralnslate?.GetTranslation("Add Query")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n\r\n            ");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "d-flex justify-content-between mt-3");
            __builder.OpenElement(82, "button");
            __builder.AddAttribute(83, "class", "btn btn-success");
            __builder.AddAttribute(84, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 64 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\QueryHeaderCompo.razor"
                                                          ExecuteFilter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(85, 
#nullable restore
#line 64 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\QueryHeaderCompo.razor"
                                                                          Tralnslate?.GetTranslation("Execute Query")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                ");
            __builder.OpenElement(87, "button");
            __builder.AddAttribute(88, "class", "btn btn-warning");
            __builder.AddAttribute(89, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\QueryHeaderCompo.razor"
                                                          ClearFilter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(90, 
#nullable restore
#line 65 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\QueryHeaderCompo.razor"
                                                                        Tralnslate?.GetTranslation("Clear Filter")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 68 "E:\SharedApps\GitHub\BlazorGenericComponents\Components\QueryHeaderCompo.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
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
