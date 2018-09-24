using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bank_System.Models;
using test_app;

namespace Bank_System.Controllers
{
    public class ClientsController : Controller
    {
        public DbManager DbManager { get; set; } = DbManager.GetInstanse();

        // GET: Clients
        public ActionResult Index()
        {
            var clients = new List<ClientModel>();
            if (DbManager.Status)
            {                
                var rows = DbManager.SendQuery("select * form client");
                
            }            
            return View();
        }
    }
}