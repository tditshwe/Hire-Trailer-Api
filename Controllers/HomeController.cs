using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using HireTrailer;
using HireTrailer.Models;
using System.Web.Http.Cors;
using Newtonsoft.Json.Linq;

namespace HireTrailer.Controllers
{
    [EnableCors(origins: "http://localhost:8000", headers: "*", methods: "*")]
    public class HomeController : ApiController
    {
        class ListCollection
        {
            public List<Trailer> Trailers { get; set; }
            public List<Client> Clients { get; set; }
            public List<RentalRetrieve> Rentals { get; set; }
        }

        private readonly AppContext Context;

        public HomeController()
        {
            Context = new AppContext();
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            List<RentalRetrieve> rentals = new List<RentalRetrieve>();
            List<Client> clients = Context.Clients.ToList();

            clients.ForEach(c => c.Rental = new Rental
            {

            });

            Context.Rentals.ToList().ForEach(r => rentals.Add(new RentalRetrieve
            {
                Client = r.Client.Name,
                TraileRegistration = r.TraileRegistration,
                DateRented = r.DateRented                
            }));


            return Ok(new ListCollection
            {
                Clients = ,
                Trailers = Context.Trailers.ToList(),
                Rentals = rentals
            });
        }

        [HttpGet]
        [ActionName("available")]
        public IHttpActionResult GetAvailable()
        {
            return Ok(new ListCollection
            {
                Clients = Context.Clients.Where(c => !c.IsRenting).ToList(),
                Trailers = Context.Trailers.Where(t => !t.IsHired).ToList()
            });
        }
    }
}