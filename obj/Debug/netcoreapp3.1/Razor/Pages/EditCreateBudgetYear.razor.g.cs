#pragma checksum "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\EditCreateBudgetYear.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "196cfd24eb0cb64f36902bd690f7f1076b6fa7cc"
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
#line 5 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\EditCreateBudgetYear.razor"
using BlazorReportingTools.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editcreatebudgetyear")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/editcreatebudgetyear/{id:int}")]
    public partial class EditCreateBudgetYear : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\EditCreateBudgetYear.razor"
 if (Id == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<h3>Create a New BudgetYear</h3>\r\n");
#nullable restore
#line 10 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\EditCreateBudgetYear.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.OpenElement(3, "h3");
            __builder.AddContent(4, "Edit ");
#nullable restore
#line 13 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\EditCreateBudgetYear.razor"
__builder.AddContent(5, newBudgetYear.Code);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 14 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\EditCreateBudgetYear.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "\r\n");
            __builder.OpenElement(8, "body");
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(10);
            __builder.AddAttribute(11, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 17 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\EditCreateBudgetYear.razor"
                     newBudgetYear

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 17 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\EditCreateBudgetYear.razor"
                                                   HandleSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(14, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(15);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(17);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n        ");
                __builder2.OpenElement(19, "div");
                __builder2.AddMarkupContent(20, "\r\n            ");
                __builder2.AddMarkupContent(21, "<label for=\"code\">Code:</label>\r\n            ");
                __Blazor.BlazorReportingTools.Pages.EditCreateBudgetYear.TypeInference.CreateInputNumber_0(__builder2, 22, 23, "form-control", 24, 
#nullable restore
#line 22 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\EditCreateBudgetYear.razor"
                                      newBudgetYear.Code

#line default
#line hidden
#nullable disable
                , 25, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newBudgetYear.Code = __value, newBudgetYear.Code)), 26, () => newBudgetYear.Code);
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.OpenElement(29, "div");
                __builder2.AddMarkupContent(30, "\r\n            ");
                __builder2.AddMarkupContent(31, "<label for=\"name\">Description:</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(32);
                __builder2.AddAttribute(33, "class", "form-control");
                __builder2.AddAttribute(34, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\EditCreateBudgetYear.razor"
                                    newBudgetYear.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newBudgetYear.Description = __value, newBudgetYear.Description))));
                __builder2.AddAttribute(36, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newBudgetYear.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "        \r\n        <br>\r\n        ");
                __builder2.OpenElement(39, "button");
                __builder2.AddAttribute(40, "type", "submit");
                __builder2.AddAttribute(41, "class", "btn btn-primary");
#nullable restore
#line 29 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\EditCreateBudgetYear.razor"
__builder2.AddContent(42, btnText);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n        ");
                __builder2.OpenElement(44, "button");
                __builder2.AddAttribute(45, "type", "button");
                __builder2.AddAttribute(46, "class", "btn btn-danger");
                __builder2.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\EditCreateBudgetYear.razor"
                                                               Delete

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(48, "Delete");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n        ");
                __builder2.OpenElement(50, "button");
                __builder2.AddAttribute(51, "type", "button");
                __builder2.AddAttribute(52, "class", "btn btn-warning");
                __builder2.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\EditCreateBudgetYear.razor"
                                                                Back

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(54, "Cancel");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(56, "    \r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\EditCreateBudgetYear.razor"
       
    [Parameter]
    public int? Id { get; set; }

    string btnText = string.Empty;

    BudgetYearModel newBudgetYear = new BudgetYearModel();

    protected override async Task OnInitializedAsync()
    {
        btnText = Id == null ? "Save New BudgetYear" : "Update BudgetYear";
        await ePRService.GetBudgetYear();
    }

    protected override async Task OnParametersSetAsync()
    {
        if (Id == null)
        { }
        else
        {
            newBudgetYear = await ePRService.GetBudgetYearId((int)Id);
        }
    }

    async Task HandleSubmit()
    {
        if (Id == null)
        {
            await ePRService.CreateBudgetYear(newBudgetYear);
        }
        else
        {
            await ePRService.UpdateBudgetYear(newBudgetYear);
        }
    }

    async Task Delete()
    {
        await ePRService.DeleteBudgetYear(newBudgetYear.Code);
    }

    void Back()
    {
        NavigationManager.NavigateTo("budgetyear");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IePRService ePRService { get; set; }
    }
}
namespace __Blazor.BlazorReportingTools.Pages.EditCreateBudgetYear
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591