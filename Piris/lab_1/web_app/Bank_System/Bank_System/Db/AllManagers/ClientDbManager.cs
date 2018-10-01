using System.Collections.Generic;
using System.Linq;
using Bank_System.Models;

namespace Bank_System.Db.AllManagers
{
    public class ClientDbManager : BaseDbManager<ClientModel>
    {
        public override List<ClientModel> GetEntities(string tableName)
        {            
            var clients = base.GetEntities(tableName);
            var maritalStaturses = new MaritalStatusesDbManager().GetEntities("Marital_Status");
            var cities = new CityDbManager().GetEntities("City");
            var disabilities = new DisabilityDbManager().GetEntities("Disability");
            var passports = new PassportDbManager().GetEntities("Passport");
            var citizenships = new CitizenshipDbManager().GetEntities("Citizenship");
            foreach (var client in clients)
            {
                client.MaritalStatus = maritalStaturses.Single(m => m.Id == client.MaritalStatusId);
                client.City = cities.Single(c => c.Id == client.CityId);
                client.Disability = disabilities.Single(d => d.Id == client.DisabilityId);
                client.Passport = passports.Single(p => p.Id == client.PassportId);
                client.Citizenship = citizenships.Single(c => c.Id == client.CitizenshipId);
            }            
            return clients;
        }

        public override void UpdateEntity(ClientModel entity)
        {
            var queryString = ComposeUpdateStringStatement(entity);
            dbManager.SendQuery($"update Client set {queryString} where Id={entity.Id}");
        }

        public override void AddEntity(ClientModel entity)
        {
            var data = ComposeAddStringStatement(entity);
            dbManager.SendQuery($"insert into Client {data.Item1} values {data.Item2}");
        }
    }
}