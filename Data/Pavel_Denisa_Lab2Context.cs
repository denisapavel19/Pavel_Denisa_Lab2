using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pavel_Denisa_Lab2.Models;

namespace Pavel_Denisa_Lab2.Data
{
    public class Pavel_Denisa_Lab2Context : DbContext
    {
        public Pavel_Denisa_Lab2Context (DbContextOptions<Pavel_Denisa_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Pavel_Denisa_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Pavel_Denisa_Lab2.Models.Publisher>? Publisher { get; set; }
    }
}
