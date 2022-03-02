using BlazorReportingTools.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorReportingTools.Services
{
    public class ePRService : IePRService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;

        public ePRService(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;
        }

        // SUPPLIER SERVICES
        public List<SupplierModel> Suppliers { get; set; } = new List<SupplierModel>();

        public async Task CreateSupplier(SupplierModel supplier)
        {
            var result = await _http.PostAsJsonAsync("http://localhost:51885/api/supplier", supplier);
            _navigationManager.NavigateTo("supplier");

        }

        public async Task DeleteSupplier(int id)
        {
            var result = await _http.DeleteAsync($"http://localhost:51885/api/supplier/{id}");
            _navigationManager.NavigateTo("supplier");
        }

        public async Task GetSupplier()
        {
            var result = await _http.GetFromJsonAsync<List<SupplierModel>>("http://localhost:51885/api/supplier");
            if (result != null)
                Suppliers = result;
        }

        public async Task<SupplierModel> GetSupplierId(int id)
        {
            var result = await _http.GetFromJsonAsync<SupplierModel>($"http://localhost:51885/api/supplier/{id}");
            if (result != null)
                return result;
            throw new Exception("Supplier Not Found");
        }

        public async Task UpdateSupplier(SupplierModel supplier)
        {
            if (GetSupplierId(supplier.Code) == null)
            {
                await _http.PutAsJsonAsync($"http://localhost:51885/api/supplier/{supplier.Code}", supplier);
                _navigationManager.NavigateTo("supplier");
            }
            else
            {
                _navigationManager.NavigateTo("supplier");
                
            }
        }

        // ITEM SERVICES
        public List<ItemModel> Items { get; set; } = new List<ItemModel>();

        public async Task CreateItem(ItemModel item)
        {
            var result = await _http.PostAsJsonAsync("http://localhost:51885/api/item", item);
            _navigationManager.NavigateTo("item");

        }

        public async Task DeleteItem(int id)
        {
            var result = await _http.DeleteAsync($"http://localhost:51885/api/item/{id}");
            _navigationManager.NavigateTo("item");
        }

        public async Task GetItem()
        {
            var result = await _http.GetFromJsonAsync<List<ItemModel>>("http://localhost:51885/api/item");
            if (result != null)
                Items = result;
        }

        public async Task<ItemModel> GetItemId(int id)
        {
            var result = await _http.GetFromJsonAsync<ItemModel>($"http://localhost:51885/api/item/{id}");
            if (result != null)
                return result;
            throw new Exception("Item Not Found");
        }

        public async Task UpdateItem(ItemModel item)
        {
            await _http.PutAsJsonAsync($"http://localhost:51885/api/item/{item.Code}", item);
            _navigationManager.NavigateTo("item");
        }       

        // BUDGET YEAR SERVICES
        public List<BudgetYearModel> BudgetYears { get; set; } = new List<BudgetYearModel>();

        public async Task CreateBudgetYear(BudgetYearModel budgetyear)
        {
            var result = await _http.PostAsJsonAsync("http://localhost:51885/api/budgetyear", budgetyear);
            _navigationManager.NavigateTo("budgetyear");

        }

        public async Task DeleteBudgetYear(int id)
        {
            var result = await _http.DeleteAsync($"http://localhost:51885/api/budgetyear/{id}");
            _navigationManager.NavigateTo("budgetyear");
        }

        public async Task GetBudgetYear()
        {
            var result = await _http.GetFromJsonAsync<List<BudgetYearModel>>("http://localhost:51885/api/budgetyear");
            if (result != null)
                BudgetYears = result;
        }

        public async Task<BudgetYearModel> GetBudgetYearId(int id)
        {
            var result = await _http.GetFromJsonAsync<BudgetYearModel>($"http://localhost:51885/api/budgetyear/{id}");
            if (result != null)
                return result;
            throw new Exception("Budget Year Not Found");
        }

        public async Task UpdateBudgetYear(BudgetYearModel budgetyear)
        {      
            await _http.PutAsJsonAsync($"http://localhost:51885/api/budgetyear/{budgetyear.Code}", budgetyear);
            _navigationManager.NavigateTo("budgetyear");
        }

        // PRItemSelectModel Services
        public List<PRItemSelectModel> PRItemSelectModels { get; set; } = new List<PRItemSelectModel>();

        public async Task CreatePRItemSelectModel(PRItemSelectModel pritemselectmodel)
        {
            var result = await _http.PostAsJsonAsync("http://localhost:51885/api/pritemselectmodel", pritemselectmodel);
            _navigationManager.NavigateTo("pritemselectmodel");

        }

        public async Task DeletePRItemSelectModel(int id)
        {
            var result = await _http.DeleteAsync($"http://localhost:51885/api/pritemselectmodel/{id}");
            _navigationManager.NavigateTo("pritemselectmodel");
        }

        public async Task GetPRItemSelectModel()
        {
            var result = await _http.GetFromJsonAsync<List<PRItemSelectModel>>("http://localhost:51885/api/pritemselectmodel");
            if (result != null)
                PRItemSelectModels = result;
        }

        public async Task<PRItemSelectModel> GetPRItemSelectModelId(int id)
        {
            var result = await _http.GetFromJsonAsync<PRItemSelectModel>($"http://localhost:51885/api/pritemselectmodel/{id}");
            if (result != null)
                return result;
            throw new Exception("PRItemSelectModel Not Found");
        }

        public async Task UpdatePRItemSelectModel(PRItemSelectModel pritemselectmodel)
        {
            if (GetPRItemSelectModelId(pritemselectmodel.Code) == null)
            {
                await _http.PutAsJsonAsync($"http://localhost:51885/api/pritemselectmodel/{pritemselectmodel.Code}", pritemselectmodel);
                _navigationManager.NavigateTo("pritemselectmodel");
            }
            else
            {
                _navigationManager.NavigateTo("pritemselectmodel");

            }
        }

        // ItemcodeQtyPriceModel Services
        public List<ItemcodeQtyPriceModel> ItemcodeQtyPriceModels { get; set; } = new List<ItemcodeQtyPriceModel>();

        public async Task CreateItemcodeQtyPriceModel(ItemcodeQtyPriceModel itemcodeqtypricemodel)
        {
            var result = await _http.PostAsJsonAsync("http://localhost:51885/api/itemcodeqtyprice", itemcodeqtypricemodel);
            // _navigationManager.NavigateTo("itemcodeqtypricemodel");

        }

        public async Task DeleteItemcodeQtyPriceModel(int id)
        {
            var result = await _http.DeleteAsync($"http://localhost:51885/api/itemcodeqtyprice/{id}");            
        }

        public async Task GetItemcodeQtyPriceModel()
        {
            var result = await _http.GetFromJsonAsync<List<ItemcodeQtyPriceModel>>("http://localhost:51885/api/itemcodeqtyprice");
            if (result != null)
                ItemcodeQtyPriceModels = result;
        }

        public async Task<ItemcodeQtyPriceModel> GetItemcodeQtyPriceModelId(int id)
        {
            var result = await _http.GetFromJsonAsync<ItemcodeQtyPriceModel>($"http://localhost:51885/api/itemcodeqtyprice/{id}");
            if (result != null)
                return result;
            throw new Exception("ItemcodeQtyPriceModel Not Found");
        }

        public async Task UpdateItemcodeQtyPriceModel(ItemcodeQtyPriceModel itemcodeqtypricemodel)
        {
            if (GetItemcodeQtyPriceModelId(itemcodeqtypricemodel.Code) == null)
            {
                await _http.PutAsJsonAsync($"http://localhost:51885/api/itemcodeqtyprice/{itemcodeqtypricemodel.Code}", itemcodeqtypricemodel);
                _navigationManager.NavigateTo("itemcodeqtypricemodel");
            }
            else
            {
                _navigationManager.NavigateTo("itemcodeqtypricemodel");
            }
        }
    }
}
