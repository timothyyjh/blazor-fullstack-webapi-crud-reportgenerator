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
            await _http.PutAsJsonAsync($"http://localhost:51885/api/supplier/{supplier.Code}", supplier);
            _navigationManager.NavigateTo("supplier");
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

        // PurchaseOrderModel Services
        
        public List<PurchaseOrderModel> PurchaseOrders { get; set; } = new List<PurchaseOrderModel>();

        public async Task CreatePurchaseOrderModel(PurchaseOrderModel purchaseordermodel)
        {
            var result = await _http.PostAsJsonAsync("http://localhost:51885/api/purchaseorder", purchaseordermodel);
        }

        public async Task DeletePurchaseOrderModel(int id)
        {
            var result = await _http.DeleteAsync($"http://localhost:51885/api/purchaseorder/{id}");            
        }

        public async Task GetPurchaseOrderModel()
        {
            var result = await _http.GetFromJsonAsync<List<PurchaseOrderModel>>("http://localhost:51885/api/purchaseorder");
            if (result != null)
                PurchaseOrders = result;
        }

        public async Task<PurchaseOrderModel> GetPurchaseOrderModelId(int id)
        {
            var result = await _http.GetFromJsonAsync<PurchaseOrderModel>($"http://localhost:51885/api/purchaseorder/{id}");
            if (result != null)
                return result;
            throw new Exception("PurchaseOrderModel Not Found");
        }

        public async Task UpdatePurchaseOrderModel(PurchaseOrderModel purchaseordermodel)
        {
                await _http.PutAsJsonAsync($"http://localhost:51885/api/purchaseorder/{purchaseordermodel.Code}", purchaseordermodel);
        }

        // ItemListModel Services
        public List<ItemListModel> PurchaseOrderItemLists { get; set; } = new List<ItemListModel>();

        public List<ItemListModel> ItemLists { get; set; } = new List<ItemListModel>();
        
        public async Task GetPurchaseOrderItemList()
        {
            var result = await _http.GetFromJsonAsync<List<ItemListModel>>($"http://localhost:51885/api/itemlist");
            if (result != null)
                ItemLists = result;
        }

        public async Task<ItemListModel> GetPurchaseOrderItemListID(int id)
        {
            var result = await _http.GetFromJsonAsync<ItemListModel>($"http://localhost:51885/api/itemlist/{id}");
            if (result != null)
                return result;
            throw new Exception("Item List Not Found");
        }

        public async Task CreatePurchaseOrderItemList(ItemListModel itemlist)
        {
            var result = await _http.PostAsJsonAsync("http://localhost:51885/api/itemlist", itemlist);           
        }

        public Task UpdatePurchaseOrderItemList(ItemListModel supplier)
        {
            throw new NotImplementedException();
        }

        public Task DeletePurchaseOrderItemList(int id)
        {
            throw new NotImplementedException();
        }
    }
}
