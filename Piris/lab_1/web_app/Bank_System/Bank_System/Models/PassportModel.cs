using System;
using System.ComponentModel.DataAnnotations;
using Bank_System.Utils.Attributes;

namespace Bank_System.Models
{
    public class PassportModel
    {
        public int Id { get; set; }
        [Updatable]
        [Display(Name = "Series")]
        public string Series { get; set; }
        [Updatable]
        [Display(Name = "Number")]
        public string Number { get; set; }
        [Updatable]
        [Display(Name = "Was given by")]
        public string WasGivenBy { get; set; }
        [Updatable]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
    }
}