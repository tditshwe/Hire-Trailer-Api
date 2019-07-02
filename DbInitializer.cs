using System.Collections.Generic;
using HireTrailer.Models;
using System;

namespace HireTrailer
{
    public class DbInitializer : System.Data.Entity.CreateDatabaseIfNotExists<AppContext>
    {
        protected override void Seed(AppContext ctx)
        {
            var clients = new List<Client>
            {
                new Client
                {
                    Name = "Kutlwano",
                    Email = "ktl@domain.com",
                    Lastname = "Motho",
                    IsRenting = false,
                    DateCreated = DateTime.Now,
                    LastRented = new DateTime(2000, 1, 1)
                },
                new Client
                {
                    Name = "Client2",
                    Email = "cl2@domain.com",
                    Lastname = "Lastname",
                    IsRenting = false,
                    DateCreated = DateTime.Now,
                    LastRented = new DateTime(2000, 1, 1)
                }
            };

            clients.ForEach(s => ctx.Clients.Add(s));

            var trailers = new List<Trailer>
            {
                new Trailer { Registration = "CSW 06L GP", IsBooked = false, IsHired = false },
                new Trailer { Registration = "CP 55 VV GP", IsBooked = false, IsHired = false },
            };

            trailers.ForEach(t => ctx.Trailers.Add(t));

            ctx.SaveChanges();
        }
    }
}