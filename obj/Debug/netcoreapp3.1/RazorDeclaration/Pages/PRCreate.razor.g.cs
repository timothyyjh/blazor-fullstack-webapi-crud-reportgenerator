// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/prcreate")]
    public partial class PRCreate : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 112 "C:\Users\Timothy Yeo\source\repos\blazor-presoft\Pages\PRCreate.razor"
       
    [Parameter]
    public int? Id { get; set; }

    string btnText = string.Empty;

    PurchaseOrderModel newPurchaseOrderModel = new PurchaseOrderModel();
    ItemModel newItem = new ItemModel();
    SupplierModel newSupplier = new SupplierModel();

    protected override async Task OnParametersSetAsync()
    {
        if (Id == null)
        { }
        else
            newPurchaseOrderModel = await ePRService.GetPurchaseOrderModelId((int)Id);
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

    protected override async Task OnInitializedAsync()
    {
        btnText = Id == null ? "Save New Item" : "Update Item";
        await ePRService.GetSupplier();
        await ePRService.GetPurchaseOrderItemList();
    }

    private void HandleSave()
    {
        ePRService.CreatePurchaseOrderModel(newPurchaseOrderModel);
        NavigationManager.NavigateTo("/purchaseorder", true);
    }

    private void Cancel()
    {
        NavigationManager.NavigateTo("/purchaseorder");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IePRService ePRService { get; set; }
    }
}
#pragma warning restore 1591
