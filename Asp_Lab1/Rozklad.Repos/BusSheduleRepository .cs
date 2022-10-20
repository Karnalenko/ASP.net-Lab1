using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Rozklad.Core;
using Rozklad.Repos.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Repos
{
    public class BusSheduleRepository
    {
        private readonly RozkladContext _ctx;
       
        public BusSheduleRepository(RozkladContext ctx)
        {
            _ctx = ctx;
           
        }
      

         public async Task<IEnumerable<BusSheduleReadDto>> GetBusSheduleAsync()
         {
            int id =1;
            var n = await _ctx.BusShedules.FirstAsync(x => x.Id == id);

            var shedules = new List<BusSheduleReadDto>();

             foreach (var u in  _ctx.BusShedules.ToList())
             {
                 var busDto = new BusSheduleReadDto
                 {
                    
                     Seats = u.Seats,
                     Cost = u.Cost,
                     //LastName = u.LastName,
                     //IsConfirmed = u.EmailConfirmed,
                   
                 };                 
                 shedules.Add(busDto);
             }
             return  shedules;
         }

        /* public async Task<BusSheduleReadDto> GetBusSheduleAsync(int id)
          {
              var u = await _ctx.BusShedules.FirstAsync(x => x.Id == id);


                  var busDto = new BusSheduleReadDto
                  {
                      Id = u.Id,
                      Seats = u.Seats,
                      Cost = u.Cost,
                      //LastName = u.LastName,
                     // IsConfirmed = u.EmailConfirmed,
                  };

                  /*foreach (var role in await userManager.GetRolesAsync(u))
                  {
                      userDto.Roles.Add(await _ctx.Roles.FirstAsync(x => x.Name.ToLower() == role.ToLower()));

                  }
              return busDto;
              }*/


    }
}
