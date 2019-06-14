using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using HireTrailer.Models;
using System.Web.Http.Cors;

namespace HireTrailer.Controllers
{
    //[Produces("application/json")]
    //[Route("trailerhire/[Controller]/")]
    [EnableCors(origins: "http://localhost:8000", headers: "*", methods: "*")]
    public class ClientController : ApiController
    {
        private readonly AppContext Context;

        public ClientController()
        {
            Context = new AppContext();
        }

        [HttpGet]
        public IHttpActionResult GetClients()
        {
            var clients = Context.Clients;

            return Ok(clients);
        }

        [ResponseType(typeof(Client))]
        public IHttpActionResult GetClient(int id)
        {
            Client client = Context.Clients.Find(id);

            if (client == null)
            {
                return NotFound();
            }

            return Ok(client);
        }

        [HttpPost]
        public IHttpActionResult CreateClient([FromBody] Client c)
        {
            DateTime lastRented = new DateTime(2000, 1, 1, 0, 0, 0);
            DateTime now = DateTime.Now;

            c.DateCreated = now;
            c.LastRented = lastRented;
            c.IsRenting = false;

            Context.Clients.Add(c);
            Context.SaveChanges();

            return Ok("Client Created");
        }
    }
}
