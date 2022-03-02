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
    public class PRItemSelectController : ControllerBase
    {

        private readonly AppDbContext _appDbContext;

        public PRItemSelectController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<PRItemSelectModel>>> GetPRItemSelect()
        {
            var entity = await _appDbContext.PRItemSelectModels.ToListAsync();
            return Ok(entity);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<PRItemSelectModel>>> GetPRItemSelectId(int id)
        {
            var entity = await _appDbContext.PRItemSelectModels.FirstOrDefaultAsync(e => e.Code == id);
            if (entity == null)
                return NotFound("Sorry, PRItemSelect not found.");
            return Ok(entity);
        }

        [HttpPost]
        public async Task<ActionResult<List<PRItemSelectModel>>> CreatePRItemSelect(PRItemSelectModel entity)
        {
            _appDbContext.PRItemSelectModels.Add(entity);
            await _appDbContext.SaveChangesAsync();

            return Ok(await GetPRItemSelect());            
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<PRItemSelectModel>>> UpdatePRItemSelect(PRItemSelectModel entity, int id)
        {
            var dbEntity = await _appDbContext.PRItemSelectModels.FirstOrDefaultAsync(e => e.Code == id);
            if (dbEntity == null)
                return NotFound("Sorry, PRItemSelect not found.");

            dbEntity.Code = entity.Code;
            dbEntity.DocNumber = entity.DocNumber;
            dbEntity.Supplier = entity.Supplier;
            dbEntity.AddressLine1 = entity.AddressLine1;
            dbEntity.AddressLine2 = entity.AddressLine2;
            dbEntity.AddressLine3 = entity.AddressLine3;
            dbEntity.AddressLine4 = entity.AddressLine4;
            dbEntity.Date = entity.Date;

            await _appDbContext.SaveChangesAsync();

            return Ok(await GetPRItemSelect());
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<List<PRItemSelectModel>>> DeletePRItemSelect(int id)
        {
            var dbEntity = await _appDbContext.PRItemSelectModels.FirstOrDefaultAsync(e => e.Code == id);
            if (dbEntity == null)
                return NotFound("Sorry, PRItemSelect not found.");

            _appDbContext.PRItemSelectModels.Remove(dbEntity);
            await _appDbContext.SaveChangesAsync();

            return Ok(await GetPRItemSelect());
        }
    }
}
