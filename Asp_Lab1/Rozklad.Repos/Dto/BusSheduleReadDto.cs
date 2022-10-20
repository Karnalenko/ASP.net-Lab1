using Microsoft.AspNetCore.Identity;
using Rozklad.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Repos.Dto
{
    public class BusSheduleReadDto
    {
        public int Id { get; set; }
        public int Seats { get; set; }
        public float Cost { get; set; }

        public List<IdentityRole>? Roles { get; set; }
    }
}
