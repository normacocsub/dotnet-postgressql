using System;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class PruebaContext : DbContext
    {
        public PruebaContext(DbContextOptions options) : base(options){}

        public DbSet<Persona> Personas { get; set; }

       
    }
}
