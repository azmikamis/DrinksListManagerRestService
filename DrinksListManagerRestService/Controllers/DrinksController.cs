using DrinksListManagerRestService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DrinksListManagerRestService.Controllers
{
    public class DrinksController : ApiController
    {
        IDrinksRepository drinks = new DrinksRepository();

        // GET: api/Drinks
        public IEnumerable<DrinkRecord> Get()
        {
            return drinks.GetAll();
        }

        // GET: api/Drinks/Pepsi
        public DrinkRecord Get(string id)
        {
            return drinks.Find(id);
        }

        // POST: api/Drinks
        public HttpResponseMessage Post(string id)
        {
            drinks.Add(id);
            return Request.CreateResponse(HttpStatusCode.Created);
        }

        // PUT: api/Drinks/Pepsi
        public void Put(string id, [FromBody]int value)
        {
            drinks.Update(id, value);
        }

        // DELETE: api/Drinks/Pepsi
        public void Delete(string id)
        {
            drinks.Remove(id);
        }
    }
}
