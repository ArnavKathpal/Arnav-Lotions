using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Arnav_Lotions.Models;

namespace Arnav_Lotions.Data
{
    public class Arnav_LotionsContext : DbContext
    {
        public Arnav_LotionsContext (DbContextOptions<Arnav_LotionsContext> options)
            : base(options)
        {
        }

        public DbSet<Arnav_Lotions.Models.Lotion> Lotion { get; set; }
    }
}
