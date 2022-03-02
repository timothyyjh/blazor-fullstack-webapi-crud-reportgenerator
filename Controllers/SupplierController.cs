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
    public class SupplierController : ControllerBase
    {

        private readonly AppDbContext _appDbContext;

        public SupplierController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<SupplierModel>>> GetSupplier()
        {
            var entity = await _appDbContext.Suppliers.ToListAsync();
            return Ok(entity);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<SupplierModel>>> GetSupplierId(int id)
        {
            var entity = await _appDbContext.Suppliers.FirstOrDefaultAsync(e => e.Code == id);
            if (entity == null)
                return NotFound("Sorry, Supplier not found.");
            return Ok(entity);
        }

        [HttpPost]
        public async Task<ActionResult<List<SupplierModel>>> CreateSupplier(SupplierModel entity)
        {
            _appDbContext.Suppliers.Add(entity);
            await _appDbContext.SaveChangesAsync();

            return Ok(await GetSupplier());            
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<SupplierModel>>> UpdateSupplier(SupplierModel entity, int id)
        {
            var dbEntity = await _appDbContext.Suppliers.FirstOrDefaultAsync(e => e.Code == id);
            if (dbEntity == null)
                return NotFound("Sorry, Supplier not found.");

            dbEntity.Code = entity.Code;
            dbEntity.Name = entity.Name;
            dbEntity.AddressLine1 = entity.AddressLine1;
            dbEntity.AddressLine2 = entity.AddressLine2;
            dbEntity.AddressLine3 = entity.AddressLine3;
            dbEntity.AddressLine4 = entity.AddressLine4;

            await _appDbContext.SaveChangesAsync();

            return Ok(await GetSupplier());
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<List<SupplierModel>>> DeleteSupplier(int id)
        {
            var dbEntity = await _appDbContext.Suppliers.FirstOrDefaultAsync(e => e.Code == id);
            if (dbEntity == null)
                return NotFound("Sorry, Supplier not found.");

            _appDbContext.Suppliers.Remove(dbEntity);
            await _appDbContext.SaveChangesAsync();

            return Ok(await GetSupplier());
        }
    }
}
