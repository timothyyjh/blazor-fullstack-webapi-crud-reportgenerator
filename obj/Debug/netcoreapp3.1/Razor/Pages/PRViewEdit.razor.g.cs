#pragma checksum "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\PRViewEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d23fc9293b0c43866d6a95ee0e8e0fdb6bd2ff95"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/ViewPR/{id:int}")]
    public partial class PRViewEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, "Edit Purchase Order [Code: ");
#nullable restore
#line 5 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\PRViewEdit.razor"
__builder.AddContent(2, newPurchaseOrderModel.Code);

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "]");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "body");
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\PRViewEdit.razor"
                     newPurchaseOrderModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\PRViewEdit.razor"
                                                           HandleSave

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenElement(12, "div");
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(14);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(16);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n            ");
                __builder2.OpenElement(18, "table");
                __builder2.AddAttribute(19, "class", "table table-bordered table-striped table-hover");
                __builder2.AddMarkupContent(20, "\r\n                ");
                __builder2.AddMarkupContent(21, @"<thead class=""thead-dark"">
                    <tr>
                        <th>Code:</th>
                        <th>Date:</th>
                        <th>Name:</th>
                        <th>Doc No:</th>
                        <th>Supplier:</th>
                        <th>Address Line</th>
                    </tr>
                </thead>
                ");
                __builder2.OpenElement(22, "tbody");
                __builder2.AddMarkupContent(23, "\r\n                    ");
                __builder2.OpenElement(24, "tr");
                __builder2.AddMarkupContent(25, "\r\n                        ");
                __builder2.OpenElement(26, "td");
                __builder2.AddMarkupContent(27, "\r\n                            <label for=\"code\"></label>\r\n                            ");
                __builder2.OpenElement(28, "input");
                __builder2.AddAttribute(29, "id", "codeinput");
                __builder2.AddAttribute(30, "readonly", true);
                __builder2.AddAttribute(31, "class", "form-control");
                __builder2.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\PRViewEdit.razor"
                                                                                              newPurchaseOrderModel.Code

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newPurchaseOrderModel.Code = __value, newPurchaseOrderModel.Code));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n                        ");
                __builder2.OpenElement(36, "td");
                __builder2.AddMarkupContent(37, "\r\n                            <label for=\"date\"></label>\r\n                            ");
                __Blazor.BlazorReportingTools.Pages.PRViewEdit.TypeInference.CreateInputDate_0(__builder2, 38, 39, "dateinput", 40, "form-control", 41, 
#nullable restore
#line 32 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\PRViewEdit.razor"
                                                                                        newPurchaseOrderModel.Date

#line default
#line hidden
#nullable disable
                , 42, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPurchaseOrderModel.Date = __value, newPurchaseOrderModel.Date)), 43, () => newPurchaseOrderModel.Date);
                __builder2.AddMarkupContent(44, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                        ");
                __builder2.OpenElement(46, "td");
                __builder2.AddMarkupContent(47, "\r\n                            <label for=\"name\"></label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(48);
                __builder2.AddAttribute(49, "id", "nameinput");
                __builder2.AddAttribute(50, "class", "form-control");
                __builder2.AddAttribute(51, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\PRViewEdit.razor"
                                                                                        newPurchaseOrderModel.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPurchaseOrderModel.Name = __value, newPurchaseOrderModel.Name))));
                __builder2.AddAttribute(53, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newPurchaseOrderModel.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(54, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n                        ");
                __builder2.OpenElement(56, "td");
                __builder2.AddMarkupContent(57, "\r\n                            <label for=\"docno\"></label>\r\n                            ");
                __Blazor.BlazorReportingTools.Pages.PRViewEdit.TypeInference.CreateInputNumber_1(__builder2, 58, 59, "numberinput", 60, "form-control", 61, 
#nullable restore
#line 40 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\PRViewEdit.razor"
                                                                                            newPurchaseOrderModel.DocNumber

#line default
#line hidden
#nullable disable
                , 62, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPurchaseOrderModel.DocNumber = __value, newPurchaseOrderModel.DocNumber)), 63, () => newPurchaseOrderModel.DocNumber);
                __builder2.AddMarkupContent(64, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n                        ");
                __builder2.OpenElement(66, "td");
                __builder2.AddMarkupContent(67, "\r\n                            <label for=\"supplier\"></label>\r\n                            ");
                __Blazor.BlazorReportingTools.Pages.PRViewEdit.TypeInference.CreateInputSelectNumber_2(__builder2, 68, 69, "supplierselect", 70, "form-control", 71, 
#nullable restore
#line 44 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\PRViewEdit.razor"
                                                                                newPurchaseOrderModel.Supplier

#line default
#line hidden
#nullable disable
                , 72, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPurchaseOrderModel.Supplier = __value, newPurchaseOrderModel.Supplier)), 73, () => newPurchaseOrderModel.Supplier, 74, (__builder3) => {
                    __builder3.AddMarkupContent(75, "\r\n");
#nullable restore
#line 45 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\PRViewEdit.razor"
                                 foreach (var supplier in ePRService.Suppliers)
                                {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(76, "                                    ");
                    __builder3.OpenElement(77, "option");
                    __builder3.AddAttribute(78, "value", 
#nullable restore
#line 47 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\PRViewEdit.razor"
                                                    supplier.Code

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 47 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\PRViewEdit.razor"
__builder3.AddContent(79, supplier.Code);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(80, "\r\n");
#nullable restore
#line 48 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\PRViewEdit.razor"
                                }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(81, "                            ");
                }
                );
                __builder2.AddMarkupContent(82, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n                        ");
                __builder2.OpenElement(84, "td");
                __builder2.AddMarkupContent(85, "\r\n                            <label for=\"address\"></label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(86);
                __builder2.AddAttribute(87, "id", "addressinput");
                __builder2.AddAttribute(88, "placeholder", "Address Line 1");
                __builder2.AddAttribute(89, "class", "form-control");
                __builder2.AddAttribute(90, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 53 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\PRViewEdit.razor"
                                                                                                   newPurchaseOrderModel.AddressLine1

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(91, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPurchaseOrderModel.AddressLine1 = __value, newPurchaseOrderModel.AddressLine1))));
                __builder2.AddAttribute(92, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newPurchaseOrderModel.AddressLine1));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(93, "\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(94);
                __builder2.AddAttribute(95, "id", "addressinput");
                __builder2.AddAttribute(96, "placeholder", "Address Line 2");
                __builder2.AddAttribute(97, "class", "form-control");
                __builder2.AddAttribute(98, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 54 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\PRViewEdit.razor"
                                                                                                   newPurchaseOrderModel.AddressLine2

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(99, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPurchaseOrderModel.AddressLine2 = __value, newPurchaseOrderModel.AddressLine2))));
                __builder2.AddAttribute(100, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newPurchaseOrderModel.AddressLine2));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(101, "\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(102);
                __builder2.AddAttribute(103, "id", "addressinput");
                __builder2.AddAttribute(104, "placeholder", "Address Line 3");
                __builder2.AddAttribute(105, "class", "form-control");
                __builder2.AddAttribute(106, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 55 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\PRViewEdit.razor"
                                                                                                   newPurchaseOrderModel.AddressLine3

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(107, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPurchaseOrderModel.AddressLine3 = __value, newPurchaseOrderModel.AddressLine3))));
                __builder2.AddAttribute(108, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newPurchaseOrderModel.AddressLine3));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(109, "\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(110);
                __builder2.AddAttribute(111, "id", "addressinput");
                __builder2.AddAttribute(112, "placeholder", "Address Line 4");
                __builder2.AddAttribute(113, "class", "form-control");
                __builder2.AddAttribute(114, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 56 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\PRViewEdit.razor"
                                                                                                   newPurchaseOrderModel.AddressLine4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(115, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPurchaseOrderModel.AddressLine4 = __value, newPurchaseOrderModel.AddressLine4))));
                __builder2.AddAttribute(116, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newPurchaseOrderModel.AddressLine4));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(117, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(118, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(119, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(120, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(121, "\r\n            <br>\r\n\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(122, "\r\n            \r\n        \r\n        ");
                __builder2.OpenElement(123, "button");
                __builder2.AddAttribute(124, "class", "btn btn-primary mb-3 rounded-pill");
                __builder2.AddAttribute(125, "type", "button");
                __builder2.AddAttribute(126, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\PRViewEdit.razor"
                                                                                  (() => HandleItemReferenceAdd())

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(127, "<i class=\"oi oi-plus\"></i>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(128, "\r\n        ");
                __builder2.OpenElement(129, "table");
                __builder2.AddAttribute(130, "class", "table table-borderless table-striped table-hover");
                __builder2.AddMarkupContent(131, "\r\n            ");
                __builder2.AddMarkupContent(132, @"<thead class=""thead-dark"">
                <tr>
                    <th>POCode</th>
                    <th>Code</th>
                    <th>Qty</th>
                    <th>Price</th>
                    <th></th>
                </tr>
            </thead>
            ");
                __builder2.OpenElement(133, "tbody");
                __builder2.AddMarkupContent(134, "\r\n");
#nullable restore
#line 78 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\PRViewEdit.razor"
                 foreach (var item in ePRService.ItemLists.Where(x => x.POCode == Id))
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(135, "                ");
                __builder2.OpenElement(136, "tr");
                __builder2.AddMarkupContent(137, "\r\n                    ");
                __builder2.OpenElement(138, "td");
#nullable restore
#line 81 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\PRViewEdit.razor"
__builder2.AddContent(139, item.POCode);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(140, "\r\n                    ");
                __builder2.OpenElement(141, "td");
#nullable restore
#line 82 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\PRViewEdit.razor"
__builder2.AddContent(142, item.Code);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(143, "\r\n                    ");
                __builder2.OpenElement(144, "td");
#nullable restore
#line 83 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\PRViewEdit.razor"
__builder2.AddContent(145, item.Qty);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(146, "\r\n                    ");
                __builder2.OpenElement(147, "td");
#nullable restore
#line 84 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\PRViewEdit.razor"
__builder2.AddContent(148, item.Price);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(149, "\r\n                    ");
                __builder2.OpenElement(150, "td");
                __builder2.OpenElement(151, "button");
                __builder2.AddAttribute(152, "class", "btn btn-danger rounded-pill");
                __builder2.AddAttribute(153, "type", "button");
                __builder2.AddAttribute(154, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 85 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\PRViewEdit.razor"
                                                                                            () => DeleteItem(item.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(155, "<i class=\"oi oi-minus\"></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(156, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(157, "\r\n");
#nullable restore
#line 87 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\PRViewEdit.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(158, "            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(159, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(160, "\r\n        ");
                __builder2.OpenElement(161, "div");
                __builder2.AddMarkupContent(162, "\r\n            ");
                __builder2.AddMarkupContent(163, "<button class=\"btn btn-success mb-3\" type=\"submit\">Save</button>\r\n            ");
                __builder2.OpenElement(164, "button");
                __builder2.AddAttribute(165, "class", "btn btn-warning mb-3");
                __builder2.AddAttribute(166, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 92 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\PRViewEdit.razor"
                                                           Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(167, "Cancel");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(168, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(169, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(170, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 98 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\PRViewEdit.razor"
       
    [Parameter]
    public int? Id { get; set; }

    protected override async Task OnParametersSetAsync()
    {
        newPurchaseOrderModel = await ePRService.GetPurchaseOrderModelId((int)Id);
    }

    ItemListModel newItemListModel = new ItemListModel();

    PurchaseOrderModel newPurchaseOrderModel = new PurchaseOrderModel();

    SupplierModel newSupplier = new SupplierModel();

    ItemModel newItem = new ItemModel();

    protected override async Task OnInitializedAsync()
    {
        await ePRService.GetSupplier();
        await ePRService.GetPurchaseOrderItemList();
    }

    private void HandleItemReferenceAdd()
    {
        NavigationManager.NavigateTo($"/ItemList/{Id}");
    }

    private void DeleteItem(int id)
    {
        ePRService.DeletePurchaseOrderItemList(id);
        NavigationManager.NavigateTo($"/ViewPR/{Id}", true);
    }

    private void Cancel()
    {
        NavigationManager.NavigateTo("/purchaseorder");
    }

    async Task HandleSave()
    {
        await ePRService.UpdatePurchaseOrderModel(newPurchaseOrderModel);
        NavigationManager.NavigateTo("/purchaseorder", true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IePRService ePRService { get; set; }
    }
}
namespace __Blazor.BlazorReportingTools.Pages.PRViewEdit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputSelectNumber_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
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
    }
}
#pragma warning restore 1591
