using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ticketapi.Models;

namespace ticketapi.Contexts
{
    public class SeatInfoContext : DbContext
    {
        public SeatInfoContext(DbContextOptions<SeatInfoContext> options): base(options)
        {
        }

        public DbSet<SeatInfo> SeatInfoItems { get; set; }

    }
}