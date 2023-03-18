using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace f1website.Models
{
    public class Result
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } // Example: "Suzuka 2021"

        public string Date { get; set; } // The full date

        public String Driver1 { get; set; }

        public String Driver2 { get; set; }
        
        // The positions that the drivers finished in, e.g 1st place
        public String Position1 { get; set; }

        public String Position2 { get; set; }

        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}