using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BlazorReportingTools.Models
{      
    public class ItemListModel
    {
        public ItemListModel() { }

        [Key]       
        public int Id { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a {0}")]
        public int Code { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a {0}")]
        public int Qty { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a {0}")]
        public int Price { get; set; }

        //FOREIGN KEY
        [ForeignKey("PurchaseOrderModel")]
        public int POCode { get; set; }
        public PurchaseOrderModel PurchaseOrderModel { get; set; }
    }
}
