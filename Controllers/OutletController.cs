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
    public class OutletController : ControllerBase
    {

        private readonly AppDbContext _appDbContext;

        public OutletController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<OutletModel>>> GetOutlet()
        {
            var entity = await _appDbContext.Outlets.ToListAsync();
            return Ok(entity);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<OutletModel>>> GetOutletId(int id)
        {
            var entity = await _appDbContext.Outlets.FirstOrDefaultAsync(e => e.OutletCode == id);
            if (entity == null)
                return NotFound("Sorry, Outlet not found.");
            return Ok(entity);
        }

        [HttpPost]
        public async Task<ActionResult<List<OutletModel>>> CreateOutlet(OutletModel entity)
        {
            _appDbContext.Outlets.Add(entity);
            await _appDbContext.SaveChangesAsync();

            return Ok(await GetOutlet());
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<OutletModel>>> UpdateOutlet(OutletModel entity, int id)
        {
            var dbEntity = await _appDbContext.Outlets.FirstOrDefaultAsync(e => e.OutletCode == id);
            if (dbEntity == null)
                return NotFound("Sorry, Outlet not found.");

            //dbEntity. = entity.;


            await _appDbContext.SaveChangesAsync();

            return Ok(await GetOutlet());
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<List<OutletModel>>> DeleteOutlet(int id)
        {
            var dbEntity = await _appDbContext.Outlets.FirstOrDefaultAsync(e => e.OutletCode == id);
            if (dbEntity == null)
                return NotFound("Sorry, Outlet not found.");

            _appDbContext.Outlets.Remove(dbEntity);
            await _appDbContext.SaveChangesAsync();

            return Ok(await GetOutlet());
        }
    }
}
