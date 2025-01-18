using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ASP.NET_MVC_Project.Models
{
    public class Customclas
    {
        [Required]
        public string name { get; set; }
        
        [newvalidation(ErrorMessage ="Rudra is required")]
        public string address { get; set; }
    }
}