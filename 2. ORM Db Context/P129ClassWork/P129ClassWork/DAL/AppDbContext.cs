using Microsoft.EntityFrameworkCore;
using P129ClassWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P129ClassWork.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Qrup> Qrups { get; set; }
        public DbSet<Telebe> Telebes { get; set; }
        public DbSet<Human> Humen { get; set; }
        public DbSet<PersonalCard> PersonalCards { get; set; }
    }
}
