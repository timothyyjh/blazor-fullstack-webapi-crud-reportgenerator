#pragma checksum "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\BudgetYear.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfb8e91c2c94c0dfeb4bc06061b7244b0d3f8bad"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorReportingTools.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\_Imports.razor"
using BlazorReportingTools;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\_Imports.razor"
using BlazorReportingTools.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\_Imports.razor"
using BlazorReportingTools.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\_Imports.razor"
using BlazorReportingTools.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/budgetyear")]
    public partial class BudgetYear : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>BudgetYear</h3>\r\n\r\n");
            __builder.OpenElement(1, "body");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary mb-3");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\BudgetYear.razor"
                                                       CreateNewBudgetYear

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Create New BudgetYear");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "table");
            __builder.AddAttribute(11, "class", "table table-bordered table-hover");
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.AddMarkupContent(13, "<thead class=\"thead-dark\">\r\n                <tr>\r\n                    <th>Code</th>\r\n                    <th>Description</th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            ");
            __builder.OpenElement(14, "tbody");
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 19 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\BudgetYear.razor"
                 foreach (var item in ePRService.BudgetYears)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "                    ");
            __builder.OpenElement(17, "tr");
            __builder.AddMarkupContent(18, "\r\n                        ");
            __builder.OpenElement(19, "td");
#nullable restore
#line 22 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\BudgetYear.razor"
__builder.AddContent(20, item.Code);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                        ");
            __builder.OpenElement(22, "td");
#nullable restore
#line 23 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\BudgetYear.razor"
__builder.AddContent(23, item.Description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "                        \r\n                        ");
            __builder.OpenElement(25, "td");
            __builder.AddMarkupContent(26, "\r\n                            ");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "class", "btn btn-primary");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\BudgetYear.razor"
                                                                      (() => ShowBudgetYear(item.Code))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(30, "<i class=\"oi oi-pencil\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 28 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\BudgetYear.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\BudgetYear.razor"
       

    protected override async Task OnInitializedAsync()
    {
        await ePRService.GetBudgetYear();
    }

    void ShowBudgetYear(int id)
    {
        NavigationManager.NavigateTo($"editcreatebudgetyear/{id}");
    }

    private void CreateNewBudgetYear()
    {
        NavigationManager.NavigateTo("/editcreatebudgetyear");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IePRService ePRService { get; set; }
    }
}
#pragma warning restore 1591
