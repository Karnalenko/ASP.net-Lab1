﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Core
{
   public static class RozkladDbContexExtension
    {
        public static void Seed(this ModelBuilder builder)
        {
            string ADMIN_ROLE_ID = Guid.NewGuid().ToString();
            string USER_ROLE_ID = Guid.NewGuid().ToString();

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = ADMIN_ROLE_ID,
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                     new IdentityRole
                     {
                         Id = USER_ROLE_ID,
                         Name = "User",
                         NormalizedName = "USER"
                     });

                 string ADMIN_ID = Guid.NewGuid().ToString();
            string USER_ID = Guid.NewGuid().ToString();

            var admin = new User
            {
                Id = ADMIN_ID,
                UserName = "admin@rozklad.com",
                Email = "admin@rozklad.com",
                EmailConfirmed = true,
                NormalizedEmail = "admin@rozklad.com".ToUpper(),
                NormalizedUserName = "admin@rozklad.com".ToUpper()
            };
            var user = new User
            {
                Id = USER_ID,
                UserName = "user@rozklad.com",
                Email = "user@rozklad.com",
                EmailConfirmed = true,
                NormalizedEmail = "user@rozklad.com".ToUpper(),
                NormalizedUserName = "user@rozklad.com".ToUpper()
            };

            PasswordHasher<User> hasher = new PasswordHasher<User>();
            admin.PasswordHash = hasher.HashPassword(admin, "admin$Pass1");
            user.PasswordHash = hasher.HashPassword(user, "user$Pass1");

            builder.Entity<User>().HasData(admin, user);

            builder.Entity<IdentityUserRole<string>>().HasData(
               new IdentityUserRole<string>
               {
                   RoleId = ADMIN_ROLE_ID,
                   UserId = ADMIN_ID
               },
                  new IdentityUserRole<string>
                  {
                      RoleId = USER_ROLE_ID,
                      UserId = ADMIN_ID
                  },
                     new IdentityUserRole<string>
                     {
                         RoleId = USER_ROLE_ID,
                         UserId = USER_ID
                     });

            
            builder.Entity<BusRoute>().HasData(
             new BusRoute
             {
                 BusrouteId = 1,
                 PlaceOfDeparture = "Острог",
                 IntermediateStops = "gremzc",
                 PlaceOfArrival = "Рівне"
             });
          

builder.Entity<BusShedule>().HasData(
new BusShedule
{
Id = 1,
     //DepartureTime = 00.00.2022, 
  BusrouteId = 1,
Seats = 30,
    carrierId =1, 
    statusId = 1, 
    //ArrivalTime 
Cost = 75

});

             builder.Entity<Carrier>().HasData(
   new Carrier
   {
       carrierId = 1,
       Name="Ilias",
       Transport = "autobus"

   });
             builder.Entity<Status>().HasData(
   new Status
   {
       statusId = 1,
       StatusValue = "В дорозі"
   });

        }
    }
}
