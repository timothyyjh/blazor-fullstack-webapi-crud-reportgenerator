using BlazorReportingTools.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorReportingTools.Services
{
    public interface IePRService
    {
        // LIST OF MODELS
        List<SupplierModel> Suppliers { get; set; }
        List<ItemModel> Items { get; set; }
        List<BudgetYearModel> BudgetYears { get; set; }
        List<PurchaseOrderModel> PurchaseOrders { get; set; }
        List<ItemListModel> ItemLists { get; set; }

        // SUPPLIER SERVICES
        Task GetSupplier();
        Task<SupplierModel> GetSupplierId(int id);
        Task CreateSupplier(SupplierModel supplier);
        Task UpdateSupplier(SupplierModel supplier);
        Task DeleteSupplier(int id);

        // ITEM SERVICES
        Task GetItem();
        Task<ItemModel> GetItemId(int id);
        Task CreateItem(ItemModel supplier);
        Task UpdateItem(ItemModel supplier);
        Task DeleteItem(int id);

        // BUDGET YEAR SERVICES
        Task GetBudgetYear();
        Task<BudgetYearModel> GetBudgetYearId(int id);
        Task CreateBudgetYear(BudgetYearModel supplier);
        Task UpdateBudgetYear(BudgetYearModel supplier);
        Task DeleteBudgetYear(int id);

        //PurchaseOrderModel SERVICES
        Task GetPurchaseOrderModel();
        Task<PurchaseOrderModel> GetPurchaseOrderModelId(int id);
        Task CreatePurchaseOrderModel(PurchaseOrderModel supplier);
        Task UpdatePurchaseOrderModel(PurchaseOrderModel supplier);
        Task DeletePurchaseOrderModel(int id);

        //ItemListModel SERVICES
        Task GetPurchaseOrderItemList();
        Task<ItemListModel> GetPurchaseOrderItemListID(int id);
        Task CreatePurchaseOrderItemList(ItemListModel supplier);
        Task UpdatePurchaseOrderItemList(ItemListModel supplier);
        Task DeletePurchaseOrderItemList(int id);
    }
}
