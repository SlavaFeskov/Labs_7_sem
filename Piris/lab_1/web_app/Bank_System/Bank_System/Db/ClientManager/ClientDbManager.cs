using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bank_System.Domain.DbModels;
using test_app;

namespace Bank_System.Db.ClientManager
{
    public class ClientDbManager
    {
        private DbManager dbManager = DbManager.GetInstanse();

        public List<ClientDbModel> GetAllClients()
        {
            var clients = new List<ClientDbModel>();
            if (dbManager.Status)
            {
                dbManager.SendQuery(@"
                    select * 
                    form Client as C 
                    join Marital_Status as M
                    on C.Marital_Status_Id = M.Id
                    join City as Ct
                    on C.");
            }

            return clients;
        }
    }
}