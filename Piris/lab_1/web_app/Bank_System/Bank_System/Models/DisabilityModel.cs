using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bank_System.Models
{
    public class DisabilityModel
    {
        public int Id { get; set; }
        [Display(Name = "Disability")]
        public string Name { get; set; }
    }
}