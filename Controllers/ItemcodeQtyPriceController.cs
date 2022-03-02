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
    public class ItemcodeQtyPriceController : ControllerBase
    {

        private readonly AppDbContext _appDbContext;

        public ItemcodeQtyPriceController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<ItemcodeQtyPriceModel>>> GetItemcodeQtyPrice()
        {
            var entity = await _appDbContext.ItemcodeQtyPriceModels.ToListAsync();
            return Ok(entity);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<ItemcodeQtyPriceModel>>> GetItemcodeQtyPriceId(int id)
        {
            var entity = await _appDbContext.ItemcodeQtyPriceModels.FirstOrDefaultAsync(e => e.Code == id);
            if (entity == null)
                return NotFound("Sorry, ItemcodeQtyPrice not found.");
            return Ok(entity);
        }

        [HttpPost]
        public async Task<ActionResult<List<ItemcodeQtyPriceModel>>> CreateItemcodeQtyPrice(ItemcodeQtyPriceModel entity)
        {
            _appDbContext.ItemcodeQtyPriceModels.Add(entity);
            await _appDbContext.SaveChangesAsync();

            return Ok(await GetItemcodeQtyPrice());            
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<ItemcodeQtyPriceModel>>> UpdateItemcodeQtyPrice(ItemcodeQtyPriceModel entity, int id)
        {
            var dbEntity = await _appDbContext.ItemcodeQtyPriceModels.FirstOrDefaultAsync(e => e.Code == id);
            if (dbEntity == null)
                return NotFound("Sorry, ItemcodeQtyPrice not found.");

            dbEntity.Code = entity.Code;
            dbEntity.Qty = entity.Qty;
            dbEntity.Price = entity.Price;

            await _appDbContext.SaveChangesAsync();

            return Ok(await GetItemcodeQtyPrice());
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<List<ItemcodeQtyPriceModel>>> DeleteItemcodeQtyPrice(int id)
        {
            var dbEntity = await _appDbContext.ItemcodeQtyPriceModels.FirstOrDefaultAsync(e => e.Code == id);
            if (dbEntity == null)
                return NotFound("Sorry, ItemcodeQtyPrice not found.");

            _appDbContext.ItemcodeQtyPriceModels.Remove(dbEntity);
            await _appDbContext.SaveChangesAsync();

            return Ok(await GetItemcodeQtyPrice());
        }
    }
}
