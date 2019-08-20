using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HireTrailerApi.Models;

namespace HireTrailerApi.Controllers
{
    [Route("hiretrailer/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly HireTrailerContext _ctx = new HireTrailerContext();

        [HttpGet]
        public IActionResult GetAll()
        {
            var clients = _ctx.Client;
            var rentals = _ctx.Rental
                .Join(_ctx.Trailer, r => r.TraileRegistration, t => t.Registration,
                (r, t) => new {
                    Client = r.Client.Name,
                    Trailer = t.Registration,
                    Date = r.DateRented
                });

            return Ok(new 
            {
                Clients = clients,
                Trailers = _ctx.Trailer,
                Rentals = rentals
            });
        }

        [HttpGet]
        [Route("available")]
        public ActionResult GetAvailable()
        {
            return Ok(new
            {
                Clients = _ctx.Client.Where(c => !c.IsRenting).ToList(),
                Trailers = _ctx.Trailer.Where(t => !t.IsRented).ToList()
            });
        }
    }
}