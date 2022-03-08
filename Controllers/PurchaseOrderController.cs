using BlazorReportingTools.DataContext;
using BlazorReportingTools.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorReportingTools.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseOrderController : ControllerBase
    {

        private readonly AppDbContext _appDbContext;

        public PurchaseOrderController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<PurchaseOrderModel>>> GetPurchaseOrder()
        {
            var entity = await _appDbContext.PurchaseOrders.ToListAsync();
            return Ok(entity);
        }



        [HttpGet("{id}")]
        public async Task<ActionResult<List<PurchaseOrderModel>>> GetPurchaseOrderId(int id)
        {
            var entity = await _appDbContext.PurchaseOrders.FirstOrDefaultAsync(e => e.Code == id);
            if (entity == null)
                return NotFound("Sorry, PurchaseOrder not found.");
            return Ok(entity);
        }

        [HttpPost]
        public async Task<ActionResult<List<PurchaseOrderModel>>> CreatePurchaseOrder(PurchaseOrderModel entity)
        {
            _appDbContext.PurchaseOrders.Add(entity);
            await _appDbContext.SaveChangesAsync();

            return Ok(await GetPurchaseOrder());
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<PurchaseOrderModel>>> UpdatePurchaseOrder(PurchaseOrderModel entity, int id)
        {
            var dbEntity = await _appDbContext.PurchaseOrders.FirstOrDefaultAsync(e => e.Code == id);
            if (dbEntity == null)
                return NotFound("Sorry, PurchaseOrder not found.");

            dbEntity.Code = entity.Code;
            dbEntity.Name = entity.Name;
            dbEntity.DocNumber = entity.DocNumber;
            dbEntity.Supplier = entity.Supplier;
            dbEntity.AddressLine1 = entity.AddressLine1;
            dbEntity.AddressLine2 = entity.AddressLine2;
            dbEntity.AddressLine3 = entity.AddressLine3;
            dbEntity.AddressLine4 = entity.AddressLine4;
            dbEntity.Date = entity.Date;

            await _appDbContext.SaveChangesAsync();

            return Ok(await GetPurchaseOrder());
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<List<PurchaseOrderModel>>> DeletePurchaseOrder(int id)
        {
            var dbEntity = await _appDbContext.PurchaseOrders.FirstOrDefaultAsync(e => e.Code == id);
            if (dbEntity == null)
                return NotFound("Sorry, PurchaseOrder not found.");

            _appDbContext.PurchaseOrders.Remove(dbEntity);
            await _appDbContext.SaveChangesAsync();

            return Ok(await GetPurchaseOrder());
        }

        // ITEMLIST CONTROLLER

        [HttpGet("ItemList")]
        public async Task<ActionResult<List<PurchaseOrderModel>>> GetPurchaseOrderItemList()
        {
            var entity = await _appDbContext.ItemLists.ToListAsync();
            return Ok(entity);
        }

        //[HttpGet("ItemList/{id}")]
        //public async Task<ActionResult<List<PurchaseOrderModel>>> GetPurchaseOrderItemListID(int id)
        //{
        //    var entity = await _appDbContext.ItemLists.LoadAsync(e => e.Code == id);
        //    if (entity == null)
        //        return NotFound("Sorry, ItemList not found.");
        //    return Ok(entity);
        //}

        [HttpPost]
        public async Task<ActionResult<List<PurchaseOrderModel>>> CreatePurchaseOrderItemList(ItemListModel entity)
        {
            _appDbContext.PurchaseOrders.ItemList.Add(entity);
            await _appDbContext.SaveChangesAsync();

            return Ok(await GetPurchaseOrderItemList());
        }
        dc

    }
}