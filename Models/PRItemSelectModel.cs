using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BlazorReportingTools.Models
{   
    public class PRItemSelectModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int Code { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;
        
        [Required]
        public int DocNumber { get; set; }
        
        [Required]
        public string Supplier { get; set; }

        [Required]
        public string Item { get; set; }


        [Required]
        public string AddressLine1 { get; set; }

        [Required]
        public string AddressLine2 { get; set; }

        [Required]
        public string AddressLine3 { get; set; }

        [Required]
        public string AddressLine4 { get; set; }      
    }
}
