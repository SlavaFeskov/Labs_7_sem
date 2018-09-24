using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bank_System.Models
{
    public class ClientModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string MiddleName { get; set; }
        public DateTime BirthDate { get; set; }
        public Sex Sex { get; set; }
        public string IdNumber { get; set; }
        public string BirthPlace { get; set; }
        public string AddressFact { get; set; }
        public string HomeNumber { get; set; }
        public string WorkNumber { get; set; }
        public string EMail { get; set; }
        public string Address { get; set; }
        public bool Pensioner { get; set; }
        public double MonthlyIncome { get; set; }
        public bool WarBound { get; set; }
        public MaritalStatusModel MaritalStatus { get; set; }
        public CityModel City { get; set; }
        public DisabilityModel Disability { get; set; }
        public PassportModel Passport { get; set; }
        public CitizenshipModel Citizenship { get; set; }
    }
}