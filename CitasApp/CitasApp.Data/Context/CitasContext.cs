
using CitasApp.Data.Entitites;
using Microsoft.EntityFrameworkCore;

namespace CitasApp.Data.Context
{
    public class CitasContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("CitasDB");
        }
        public DbSet<Citas> Cita { get; set; }
    }
}
