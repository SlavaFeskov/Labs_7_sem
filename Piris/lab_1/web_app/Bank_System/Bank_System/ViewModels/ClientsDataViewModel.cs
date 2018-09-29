using System.Collections.Generic;
using Bank_System.Models;

namespace Bank_System.ViewModels
{
    public class ClientsDataViewModel
    {
        public ClientModel Client { get; set; }
        public List<MaritalStatusModel> MaritalStatuses { get; set; }
        public List<CityModel> Cities { get; set; }
        public List<DisabilityModel> Disabilities { get; set; }
        public List<CitizenshipModel> Citizenships { get; set; }
        public PassportModel Passport { get; set; }
    }
}