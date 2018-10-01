using System.Linq;
using System.Web.Mvc;
using Bank_System.Db;
using Bank_System.Db.AllManagers;
using Bank_System.Models;
using Bank_System.ViewModels;

namespace Bank_System.Controllers
{
    public class ClientsController : Controller
    {        
        private readonly BaseDbManager<ClientModel> _clientDbManager = new ClientDbManager();
        private readonly BaseDbManager<MaritalStatusModel> _maritalStatusDbManager = new MaritalStatusesDbManager();
        private readonly BaseDbManager<DisabilityModel> _disabilitiDbManager = new DisabilityDbManager();
        private readonly BaseDbManager<CityModel> _cityDbManager = new CityDbManager();
        private readonly BaseDbManager<CitizenshipModel> _citizenshipDbManager = new CitizenshipDbManager();
        private readonly BaseDbManager<PassportModel> _passportDbManager = new PassportDbManager();

        // GET: Clients
        public ActionResult Index()
        {                       
            var clients = _clientDbManager.GetEntities("Client");
            return View(clients);
        }

        [HttpGet]
        public ActionResult Form(int? id)
        {
            var clientsData =
                new ClientsDataViewModel
                {
                    MaritalStatuses = _maritalStatusDbManager.GetEntities("Marital_Status"),
                    Cities = _cityDbManager.GetEntities("City"),
                    Disabilities = _disabilitiDbManager.GetEntities("Disability"),
                    Citizenships = _citizenshipDbManager.GetEntities("Citizenship")
                };
            if (id == null)
            {
                return View(clientsData);
            }
            var client = _clientDbManager.GetEntities("Client").SingleOrDefault(c => c.Id == id);
            if (client == null)
            {
                return HttpNotFound();
            }

            clientsData.Client = client;
            clientsData.Passport = _passportDbManager.GetEntities("Passport")
                .SingleOrDefault(p => p.Id == client.PassportId);
            return View(clientsData);
        }
        
        [HttpPost]
        public ActionResult Save(ClientsDataViewModel clientsData)
        {
            if (clientsData.Client.Id == 0)
            {
                _passportDbManager.AddEntity(clientsData.Passport);
                var lastPassportEntryAdded = _passportDbManager.GetLastRowAdded("Passport");
                clientsData.Client.PassportId = lastPassportEntryAdded.Id;
                _clientDbManager.AddEntity(clientsData.Client);
            }
            else
            {
                _clientDbManager.UpdateEntity(clientsData.Client);
                _passportDbManager.UpdateEntity(clientsData.Passport);
            }
            return RedirectToAction("Index");
        }
    }
}