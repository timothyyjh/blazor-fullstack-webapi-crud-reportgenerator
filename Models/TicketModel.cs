using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorReportingTools.Models
{
    public class TicketModel
    {
        public int Id { get; set; }
        public int ReceiptNo { get; set; }
        public DateTime DocDate { get; set; } = DateTime.Now;
        public string  Outlet { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime ExpiryDate { get; set; } = DateTime.Now;
        public string ActivityCode { get; set; }
        public int Quantity { get; set; }
    }
}
