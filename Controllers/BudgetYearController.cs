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
    public class BudgetYearController : ControllerBase
    {

        private readonly AppDbContext _appDbContext;

        public BudgetYearController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<BudgetYearModel>>> GetBudgetYear()
        {
            var entity = await _appDbContext.BudgetYears.ToListAsync();
            return Ok(entity);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<BudgetYearModel>>> GetBudgetYearId(int id)
        {
            var entity = await _appDbContext.BudgetYears.FirstOrDefaultAsync(e => e.Code == id);
            if (entity == null)
                return NotFound("Sorry, BudgetYear not found.");
            return Ok(entity);
        }

        [HttpPost]
        public async Task<ActionResult<List<BudgetYearModel>>> CreateBudgetYear(BudgetYearModel entity)
        {
            _appDbContext.BudgetYears.Add(entity);
            await _appDbContext.SaveChangesAsync();

            return Ok(await GetBudgetYear());            
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<BudgetYearModel>>> UpdateBudgetYear(BudgetYearModel entity, int id)
        {
            var dbEntity = await _appDbContext.BudgetYears.FirstOrDefaultAsync(e => e.Code == id);
            if (dbEntity == null)
                return NotFound("Sorry, BudgetYear not found.");

            dbEntity.Code = entity.Code;
            dbEntity.Description = entity.Description;
            
            await _appDbContext.SaveChangesAsync();

            return Ok(await GetBudgetYear());
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<List<BudgetYearModel>>> DeleteBudgetYear(int id)
        {
            var dbEntity = await _appDbContext.BudgetYears.FirstOrDefaultAsync(e => e.Code == id);
            if (dbEntity == null)
                return NotFound("Sorry, BudgetYear not found.");

            _appDbContext.BudgetYears.Remove(dbEntity);
            await _appDbContext.SaveChangesAsync();

            return Ok(await GetBudgetYear());
        }
    }
}
