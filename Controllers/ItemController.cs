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
    public class ItemController : ControllerBase
    {

        private readonly AppDbContext _appDbContext;

        public ItemController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<ItemModel>>> GetItem()
        {
            var entity = await _appDbContext.Items.ToListAsync();
            return Ok(entity);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<ItemModel>>> GetItemId(int id)
        {
            var entity = await _appDbContext.Items.FirstOrDefaultAsync(e => e.Code == id);
            if (entity == null)
                return NotFound("Sorry, Item not found.");
            return Ok(entity);
        }

        [HttpPost]
        public async Task<ActionResult<List<ItemModel>>> CreateItem(ItemModel entity)
        {
            _appDbContext.Items.Add(entity);
            await _appDbContext.SaveChangesAsync();

            return Ok(await GetItem());
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<ItemModel>>> UpdateItem(ItemModel entity, int id)
        {
            var dbEntity = await _appDbContext.Items.FirstOrDefaultAsync(e => e.Code == id);
            if (dbEntity == null)
                return NotFound("Sorry, Item not found.");

            dbEntity.Code = entity.Code;
            dbEntity.Name = entity.Name;
            dbEntity.UOM = entity.UOM;
            dbEntity.Description = entity.Description;
            dbEntity.Price = entity.Price;

            await _appDbContext.SaveChangesAsync();

            return Ok(await GetItem());
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<List<ItemModel>>> DeleteItem(int id)
        {
            var dbEntity = await _appDbContext.Items.FirstOrDefaultAsync(e => e.Code == id);
            if (dbEntity == null)
                return NotFound("Sorry, Item not found.");

            _appDbContext.Items.Remove(dbEntity);
            await _appDbContext.SaveChangesAsync();

            return Ok(await GetItem());
        }
    }
}
