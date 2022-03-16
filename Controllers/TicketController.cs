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
    public class TicketController : ControllerBase
    {

        private readonly AppDbContext _appDbContext;

        public TicketController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<TicketModel>>> GetTicket()
        {
            var entity = await _appDbContext.Tickets.ToListAsync();
            return Ok(entity);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<TicketModel>>> GetTicketId(int id)
        {
            var entity = await _appDbContext.Tickets.FirstOrDefaultAsync(e => e.Id == id);
            if (entity == null)
                return NotFound("Sorry, Ticket not found.");
            return Ok(entity);
        }

        [HttpPost]
        public async Task<ActionResult<List<TicketModel>>> CreateTicket(TicketModel entity)
        {
            _appDbContext.Tickets.Add(entity);
            await _appDbContext.SaveChangesAsync();

            return Ok(await GetTicket());
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<TicketModel>>> UpdateTicket(TicketModel entity, int id)
        {
            var dbEntity = await _appDbContext.Tickets.FirstOrDefaultAsync(e => e.Id == id);
            if (dbEntity == null)
                return NotFound("Sorry, Ticket not found.");

            dbEntity.Outlet = entity.Outlet;
            dbEntity.Quantity = entity.Quantity;
            dbEntity.ReceiptNo = entity.ReceiptNo;
            dbEntity.StartDate = entity.StartDate;
            dbEntity.ExpiryDate = entity.ExpiryDate;
            dbEntity.DocDate = entity.DocDate;

            await _appDbContext.SaveChangesAsync();

            return Ok(await GetTicket());
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<List<TicketModel>>> DeleteTicket(int id)
        {
            var dbEntity = await _appDbContext.Tickets.FirstOrDefaultAsync(e => e.Id == id);
            if (dbEntity == null)
                return NotFound("Sorry, Ticket not found.");

            _appDbContext.Tickets.Remove(dbEntity);
            await _appDbContext.SaveChangesAsync();

            return Ok(await GetTicket());
        }
    }
}
