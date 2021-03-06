using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BlazorReportingTools.Models
{   
    public class ItemModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int Code { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string UOM { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int Price{ get; set; }     
    }
}
