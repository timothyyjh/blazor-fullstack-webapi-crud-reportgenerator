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
    public class ItemListController : ControllerBase
    {

        private readonly AppDbContext _appDbContext;

        public ItemListController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        // ITEMLIST CONTROLLER

        [HttpGet]
        public async Task<ActionResult<List<ItemListModel>>> GetItemList()
        {
            var entity = await _appDbContext.ItemLists.ToListAsync();
            return Ok(entity);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<ItemListModel>>> GetItemListID(int id)
        {
            var entity = await _appDbContext.ItemLists.FirstOrDefaultAsync(e => e.Code == id);
            if (entity == null)
                return NotFound("Sorry, ItemList not found.");
            return Ok(entity);
        }

        [HttpPost]
        public async Task<ActionResult<List<ItemListModel>>> CreateItemList(ItemListModel entity)
        {
            _appDbContext.ItemLists.Add(entity);
            await _appDbContext.SaveChangesAsync();

            return Ok(await GetItemList());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<ItemListModel>>> DeleteItemList(int id)
        {
            var dbEntity = await _appDbContext.ItemLists.FirstOrDefaultAsync(e => e.Id == id);
            if (dbEntity == null)
                return NotFound("Sorry, Item List not found.");

            _appDbContext.ItemLists.Remove(dbEntity);
            await _appDbContext.SaveChangesAsync();

            return Ok(await GetItemList());
        }
    }
}