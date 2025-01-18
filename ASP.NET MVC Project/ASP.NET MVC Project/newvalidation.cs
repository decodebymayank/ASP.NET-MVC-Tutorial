using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace ASP.NET_MVC_Project
{
    public class newvalidation :ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string message = value.ToString();
                if (message.Contains("Omkara"))
                {
                    return ValidationResult.Success;
                }
               
            }

            return new ValidationResult("Some Error is there");
        }
    }
}