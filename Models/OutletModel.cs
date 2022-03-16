using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorReportingTools.Models
{
    public class OutletModel
    {        
        [Key]
        public int OutletCode { get; set; }

        public string Description { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }
        public bool IsActivated { get; set; }
        public string createdUserID { get; set; }
        public DateTime createdDateTime { get; set; }
        public string lastModifiedUserID { get; set; }
        public Nullable<DateTime> lastModifiedDateTime { get; set; }
        
    }
}
