#pragma checksum "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\ItemList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51dc627e545d65aab46aa342eb51bb60f5fbeae5"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/ItemList/{id:int}")]
    public partial class ItemList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, "Item Selector for Purchase Order [Code: ");
#nullable restore
#line 5 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\ItemList.razor"
__builder.AddContent(2, newPurchaseOrderModel.Code);

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, " ]");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "body");
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\ItemList.razor"
                     newItemListModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\ItemList.razor"
                                                      HandleSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(14);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n        ");
                __builder2.OpenElement(16, "div");
                __builder2.AddMarkupContent(17, "\r\n            ");
                __builder2.OpenElement(18, "table");
                __builder2.AddAttribute(19, "class", "table table-borderless table-striped table-hover");
                __builder2.AddMarkupContent(20, "\r\n                ");
                __builder2.AddMarkupContent(21, @"<thead class=""thead-dark"">
                    <tr>
                        <th>Page ID bind to POCode</th>
                        <th>Item Code</th>
                        <th>Qty</th>
                        <th>Price</th>
                    </tr>
                </thead>

                ");
                __builder2.OpenElement(22, "tbody");
                __builder2.AddMarkupContent(23, "\r\n                    ");
                __builder2.OpenElement(24, "tr");
                __builder2.AddMarkupContent(25, "\r\n                        ");
                __builder2.OpenElement(26, "td");
                __builder2.AddMarkupContent(27, "\r\n                            ");
                __Blazor.BlazorReportingTools.Pages.ItemList.TypeInference.CreateInputSelectNumber_0(__builder2, 28, 29, "form-control", 30, 
#nullable restore
#line 26 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\ItemList.razor"
                                                            newItemListModel.POCode

#line default
#line hidden
#nullable disable
                , 31, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newItemListModel.POCode = __value, newItemListModel.POCode)), 32, () => newItemListModel.POCode, 33, (__builder3) => {
                    __builder3.AddMarkupContent(34, "\r\n                                ");
                    __builder3.OpenElement(35, "option");
                    __builder3.AddAttribute(36, "value", 
#nullable restore
#line 27 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\ItemList.razor"
                                                Id

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 27 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\ItemList.razor"
__builder3.AddContent(37, Id);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(38, "\r\n                            ");
                }
                );
                __builder2.AddMarkupContent(39, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n\r\n                        ");
                __builder2.OpenElement(41, "td");
                __builder2.AddMarkupContent(42, "\r\n                            ");
                __Blazor.BlazorReportingTools.Pages.ItemList.TypeInference.CreateInputSelectNumber_1(__builder2, 43, 44, "codeselect", 45, "form-control", 46, 
#nullable restore
#line 32 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\ItemList.razor"
                                                                            newItemListModel.Code

#line default
#line hidden
#nullable disable
                , 47, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newItemListModel.Code = __value, newItemListModel.Code)), 48, () => newItemListModel.Code, 49, (__builder3) => {
                    __builder3.AddMarkupContent(50, "\r\n");
#nullable restore
#line 33 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\ItemList.razor"
                                 foreach (var item in ePRService.Items)
                                {

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(51, "                                    <option value selected disabled hidden></option>\r\n                                    ");
                    __builder3.OpenElement(52, "option");
                    __builder3.AddAttribute(53, "value", 
#nullable restore
#line 36 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\ItemList.razor"
                                                    item.Code

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 36 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\ItemList.razor"
__builder3.AddContent(54, item.Code);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(55, "\r\n");
#nullable restore
#line 37 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\ItemList.razor"
                                }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(56, "                            ");
                }
                );
                __builder2.AddMarkupContent(57, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n                        ");
                __builder2.OpenElement(59, "td");
                __builder2.AddMarkupContent(60, "\r\n                            ");
                __Blazor.BlazorReportingTools.Pages.ItemList.TypeInference.CreateInputNumber_2(__builder2, 61, 62, "qtyselect", 63, "form-control", 64, 
#nullable restore
#line 41 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\ItemList.razor"
                                                                     newItemListModel.Qty

#line default
#line hidden
#nullable disable
                , 65, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newItemListModel.Qty = __value, newItemListModel.Qty)), 66, () => newItemListModel.Qty);
                __builder2.AddMarkupContent(67, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n                        ");
                __builder2.OpenElement(69, "td");
                __builder2.AddMarkupContent(70, "\r\n                            ");
                __Blazor.BlazorReportingTools.Pages.ItemList.TypeInference.CreateInputNumber_3(__builder2, 71, 72, "priceselect", 73, "form-control", 74, 
#nullable restore
#line 44 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\ItemList.razor"
                                                                       newItemListModel.Price

#line default
#line hidden
#nullable disable
                , 75, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newItemListModel.Price = __value, newItemListModel.Price)), 76, () => newItemListModel.Price);
                __builder2.AddMarkupContent(77, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n            ");
                __builder2.AddMarkupContent(82, "<button id=\"addbutton\" class=\"btn btn-success mb-3 rounded-pill\" type=\"submit\"><i class=\"oi oi-check\"></i></button>\r\n            ");
                __builder2.OpenElement(83, "button");
                __builder2.AddAttribute(84, "id", "cancelbutton");
                __builder2.AddAttribute(85, "class", "btn btn-warning mb-3 rounded-pill");
                __builder2.AddAttribute(86, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\ItemList.razor"
                                                                                          Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(87, "Cancel");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(90, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\ItemList.razor"
       
    [Parameter]
    public int? Id { get; set; }

    ItemListModel newItemListModel = new ItemListModel();
    PurchaseOrderModel newPurchaseOrderModel = new PurchaseOrderModel();

    protected override async Task OnParametersSetAsync()
    {
        newPurchaseOrderModel = await ePRService.GetPurchaseOrderModelId((int)Id);
        // newItemListModel = await ePRService.GetPurchaseOrderItemListID((int)Id);
    }

    protected override async Task OnInitializedAsync()
    {
        await ePRService.GetItem();
    }

    async Task HandleSubmit()
    {
        await ePRService.CreatePurchaseOrderItemList(newItemListModel);
        NavigationManager.NavigateTo($"/ViewPR/{Id}");
    }

    private void Cancel()
    {
        NavigationManager.NavigateTo($"/ViewPR/{Id}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IePRService ePRService { get; set; }
    }
}
namespace __Blazor.BlazorReportingTools.Pages.ItemList
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelectNumber_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, T __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::BlazorReportingTools.Models.InputSelectNumber<T>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputSelectNumber_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::BlazorReportingTools.Models.InputSelectNumber<T>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
