using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AR_PROGRESO1.Models;

namespace AR_PROGRESO1.Data
{
    public class AR_PROGRESO1Context : DbContext
    {
        public AR_PROGRESO1Context (DbContextOptions<AR_PROGRESO1Context> options)
            : base(options)
        {
        }

        public DbSet<AR_PROGRESO1.Models.ARAURA> ARAURA { get; set; } = default!;
    }
}
