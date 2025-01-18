using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ASP.NET_MVC_Project.Models
{
    public class TemplatedHtmlHelpers
    {
        
        public int num { get; set; }

        /*This will display in view*/
        [Display(Name = "Enter Your Name")]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime newdate { get; set; }   
    }
}