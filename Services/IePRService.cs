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
        List<PRItemSelectModel> PRItemSelectModels { get; set; }
        List<ItemcodeQtyPriceModel> ItemcodeQtyPriceModels { get; set; }

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

        //PRItemSelectModel SERVICES
        Task GetPRItemSelectModel();
        Task<PRItemSelectModel> GetPRItemSelectModelId(int id);
        Task CreatePRItemSelectModel(PRItemSelectModel supplier);
        Task UpdatePRItemSelectModel(PRItemSelectModel supplier);
        Task DeletePRItemSelectModel(int id);

        //ItemcodeQtyPriceModel SERVICES
        Task GetItemcodeQtyPriceModel();
        Task<ItemcodeQtyPriceModel> GetItemcodeQtyPriceModelId(int id);
        Task CreateItemcodeQtyPriceModel(ItemcodeQtyPriceModel supplier);
        Task UpdateItemcodeQtyPriceModel(ItemcodeQtyPriceModel supplier);
        Task DeleteItemcodeQtyPriceModel(int id);
    }
}
