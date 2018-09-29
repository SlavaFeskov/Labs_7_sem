using System.ComponentModel.DataAnnotations;

namespace Bank_System.Models
{
    public class MaritalStatusModel
    {
        public int Id { get; set; }
        [Display(Name = "Marital Status")]
        public string Name { get; set; }
    }
}