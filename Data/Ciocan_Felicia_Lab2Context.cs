using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ciocan_Felicia_Lab2.Models;

namespace Ciocan_Felicia_Lab2.Data
{
    public class Ciocan_Felicia_Lab2Context : DbContext
    {
        public Ciocan_Felicia_Lab2Context (DbContextOptions<Ciocan_Felicia_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Ciocan_Felicia_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Ciocan_Felicia_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    }
}
