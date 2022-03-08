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
        public int Code { get; set; }

        [Required]
        public int Qty { get; set; }

        [Required]
        public int Price { get; set; }        
    }
}
