using BankAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BankAPI.Controllers
{
    public class clientController : ApiController
    {
        Client[] allClients = new Client[]{
         new Client { ID = 1, Name = "Mark LALAN", Account = "1215", Password = "123", Balance = 100},
         new Client { ID = 2, Name = "Allan MOMO", Account = "5002", Password = "123", Balance = 500},
         new Client { ID = 3, Name = "Ismail ZAH", Account = "4050", Password = "bvb09", Balance = 30}
        };


        public IEnumerable<Client> GetAllClients()
        {
            return allClients;  
        }

    
        public IHttpActionResult GetEmployee(String id)
        {
            var visitor = allClients.FirstOrDefault((p) => p.Account.Equals(id));
            if (visitor == null)
            {
                return NotFound();
            }
            return Ok(visitor);
        }
    }
}
