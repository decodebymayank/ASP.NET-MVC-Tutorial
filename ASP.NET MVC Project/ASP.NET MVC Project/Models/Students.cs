using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ASP.NET_MVC_Project.Models
{
    public class Students
    {
        public int Age { get; set; }
        public int Id { get; set; }

        public string Name { get; set; }

        [Required(ErrorMessage ="Email Address sahi nahi hai")]
        [EmailAddress]
        public string EmailId { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
    }
}