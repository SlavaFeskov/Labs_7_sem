using System;
using System.ComponentModel.DataAnnotations;
using Bank_System.Utils.Attributes;

namespace Bank_System.Models
{
    public class ClientModel
    {
        public int Id { get; set; }
        [Updatable]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Updatable]
        [Display(Name = "Second Name")]
        public string SecondName { get; set; }
        [Updatable]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }
        [Updatable]
        [Display(Name = "Birth Date")]
        public DateTime BirthDate { get; set; }
        [Updatable]
        [Display(Name = "Sex")]
        public Sex Sex { get; set; }
        [Updatable]
        [Display(Name = "Id number")]
        public string IdNumber { get; set; }
        [Updatable]
        [Display(Name = "Birth Place")]
        public string BirthPlace { get; set; }
        [Updatable]
        [Display(Name = "Actual address of residence")]
        public string AddressFact { get; set; }
        [Updatable]
        [Display(Name = "Home phone number")]
        public string HomeNumber { get; set; }
        [Updatable]
        [Display(Name = "Work phone number")]
        public string WorkNumber { get; set; }
        [Updatable]
        [Display(Name = "E-mail")]
        public string EMail { get; set; }
        [Updatable]
        [Display(Name = "Residence address")]
        public string Address { get; set; }
        [Updatable]
        [Display(Name = "Pensioner")]
        public bool Pensioner { get; set; }
        [Updatable]
        [Display(Name = "Monthly income")]
        public double MonthlyIncome { get; set; }
        [Updatable]
        [Display(Name = "Was bound")]
        public bool WarBound { get; set; }
        [Updatable]
        public int MaritalStatusId { get; set; }
        [Updatable]
        public int CityId { get; set; }
        [Updatable]
        public int DisabilityId { get; set; }
        [Updatable]
        public int PassportId { get; set; }
        [Updatable]
        public int CitizenshipId { get; set; }

        public MaritalStatusModel MaritalStatus { get; set; }
        public CityModel City { get; set; }
        public DisabilityModel Disability { get; set; }
        public PassportModel Passport { get; set; }
        public CitizenshipModel Citizenship { get; set; }
    }
}