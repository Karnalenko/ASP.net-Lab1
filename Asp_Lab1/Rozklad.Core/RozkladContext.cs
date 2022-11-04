﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Rozklad.Core
{
    public class RozkladContext : IdentityDbContext<User>
    {
        public RozkladContext(DbContextOptions<RozkladContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Seed();
            base.OnModelCreating(builder);
        }

        public DbSet<BusShedule>? BusShedules { get; set; }       
        public DbSet<BusRoute>? BusRoutes { get; set; }
        public DbSet<Carrier>? Carriers { get; set; }
        public DbSet<Status>? Statuses { get; set; }
        public DbSet<BuyTicket>? BuyTickets { get; set; }
        public DbSet<Card>? Cards { get; set; }
        public DbSet<MapsRoute>? MapsRoutes { get; set; }
       

    }
}