#pragma checksum "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\Ticket.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "031a1f37fe7c00d5f52dd60a601976cbe870d8ef"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Ticket")]
    public partial class Ticket : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Ticket</h3>\r\n\r\n");
            __builder.OpenElement(1, "body");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\Ticket.razor"
                     newTicket

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\Ticket.razor"
                                               HandleSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "     \r\n\r\n        ");
                __builder2.OpenElement(12, "table");
                __builder2.AddAttribute(13, "class", "table table-striped");
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.AddMarkupContent(15, @"<thead class=""thead-dark"">
                <tr>
                    <th>Receipt No:</th>                       
                    <th>Doc Date:</th>                            
                    <td>Outlet:</td>                            
                    <td>Start Date:</td>                            
                    <td>Expiry Date:</td>                            
                </tr>
            </thead>
            ");
                __builder2.OpenElement(16, "tbody");
                __builder2.AddMarkupContent(17, "\r\n                ");
                __builder2.OpenElement(18, "tr");
                __builder2.AddMarkupContent(19, "\r\n                    ");
                __builder2.OpenElement(20, "td");
                __Blazor.BlazorReportingTools.Pages.Ticket.TypeInference.CreateInputDate_0(__builder2, 21, 22, "form-control", 23, 
#nullable restore
#line 24 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\Ticket.razor"
                                                newTicket.DocDate

#line default
#line hidden
#nullable disable
                , 24, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newTicket.DocDate = __value, newTicket.DocDate)), 25, () => newTicket.DocDate);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n                    ");
                __builder2.OpenElement(27, "td");
                __Blazor.BlazorReportingTools.Pages.Ticket.TypeInference.CreateInputNumber_1(__builder2, 28, 29, "form-control", 30, 
#nullable restore
#line 25 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\Ticket.razor"
                                                  newTicket.ReceiptNo

#line default
#line hidden
#nullable disable
                , 31, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newTicket.ReceiptNo = __value, newTicket.ReceiptNo)), 32, () => newTicket.ReceiptNo);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                    ");
                __builder2.OpenElement(34, "td");
                __Blazor.BlazorReportingTools.Pages.Ticket.TypeInference.CreateInputSelect_2(__builder2, 35, 36, "form-control", 37, 
#nullable restore
#line 26 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\Ticket.razor"
                                                  newTicket.Outlet

#line default
#line hidden
#nullable disable
                , 38, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newTicket.Outlet = __value, newTicket.Outlet)), 39, () => newTicket.Outlet);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                    ");
                __builder2.OpenElement(41, "td");
                __Blazor.BlazorReportingTools.Pages.Ticket.TypeInference.CreateInputDate_3(__builder2, 42, 43, "form-control", 44, 
#nullable restore
#line 27 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\Ticket.razor"
                                                newTicket.StartDate

#line default
#line hidden
#nullable disable
                , 45, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newTicket.StartDate = __value, newTicket.StartDate)), 46, () => newTicket.StartDate);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n                    ");
                __builder2.OpenElement(48, "td");
                __Blazor.BlazorReportingTools.Pages.Ticket.TypeInference.CreateInputDate_4(__builder2, 49, 50, "form-control", 51, 
#nullable restore
#line 28 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\Ticket.razor"
                                                newTicket.ExpiryDate

#line default
#line hidden
#nullable disable
                , 52, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newTicket.ExpiryDate = __value, newTicket.ExpiryDate)), 53, () => newTicket.ExpiryDate);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n        \r\n        ");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "container-fluid");
                __builder2.AddMarkupContent(60, "\r\n            ");
                __builder2.OpenElement(61, "table");
                __builder2.AddAttribute(62, "class", "table table-striped");
                __builder2.AddMarkupContent(63, "\r\n                ");
                __builder2.AddMarkupContent(64, "<thead class=\"thead-dark\">\r\n                    <tr>\r\n                        <th>Activity Code:</th>\r\n                        <th>Quantity:</th>\r\n                    </tr>\r\n                </thead>\r\n\r\n                ");
                __builder2.OpenElement(65, "tbody");
                __builder2.AddMarkupContent(66, "\r\n                    ");
                __builder2.OpenElement(67, "tr");
                __builder2.AddMarkupContent(68, "\r\n                        ");
                __builder2.OpenElement(69, "td");
                __builder2.AddMarkupContent(70, "\r\n                            ");
                __Blazor.BlazorReportingTools.Pages.Ticket.TypeInference.CreateInputSelect_5(__builder2, 71, 72, "form-control", 73, 
#nullable restore
#line 45 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\Ticket.razor"
                                                      newTicket.ActivityCode

#line default
#line hidden
#nullable disable
                , 74, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newTicket.ActivityCode = __value, newTicket.ActivityCode)), 75, () => newTicket.ActivityCode, 76, (__builder3) => {
                    __builder3.AddMarkupContent(77, "\r\n");
#nullable restore
#line 46 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\Ticket.razor"
                                 foreach (var item in ePRService.Tickets)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\Ticket.razor"
__builder3.AddContent(78, item.ActivityCode);

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\Ticket.razor"
                                                      
                                }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(79, "                            ");
                }
                );
                __builder2.AddMarkupContent(80, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n                        ");
                __builder2.OpenElement(82, "td");
                __builder2.AddMarkupContent(83, "\r\n                            ");
                __Blazor.BlazorReportingTools.Pages.Ticket.TypeInference.CreateInputNumber_6(__builder2, 84, 85, "form-control", 86, 
#nullable restore
#line 53 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\Ticket.razor"
                                                      newTicket.Quantity

#line default
#line hidden
#nullable disable
                , 87, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newTicket.Quantity = __value, newTicket.Quantity)), 88, () => newTicket.Quantity);
                __builder2.AddMarkupContent(89, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "                        \r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(95, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\Ticket.razor"
       
    TicketModel newTicket = new TicketModel();

    private void HandleSubmit()
    {

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IePRService ePRService { get; set; }
    }
}
namespace __Blazor.BlazorReportingTools.Pages.Ticket
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
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
