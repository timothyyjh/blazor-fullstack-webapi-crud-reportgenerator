﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BlazorReportingTools.Models
{   
    public class PurchaseOrderModel
    {        

        [Key]        
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        // [Editable(true)] NOT WORKING
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a {0}")]
        public int Code { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public DateTime Date { get; set; } = DateTime.Now;
        
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a {0}")]
        public int DocNumber { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage="Please enter a {0}")]
        public int Supplier { get; set; }

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
