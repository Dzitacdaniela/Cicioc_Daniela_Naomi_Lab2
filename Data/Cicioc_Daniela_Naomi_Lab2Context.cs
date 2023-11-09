using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cicioc_Daniela_Naomi_Lab2.Models;

namespace Cicioc_Daniela_Naomi_Lab2.Data
{
    public class Cicioc_Daniela_Naomi_Lab2Context : DbContext
    {
        public Cicioc_Daniela_Naomi_Lab2Context (DbContextOptions<Cicioc_Daniela_Naomi_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Cicioc_Daniela_Naomi_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Cicioc_Daniela_Naomi_Lab2.Models.Publisher>? Publisher { get; set; }
    }
}
