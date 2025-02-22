using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Web_OuterrimSpaceship.Entities;

namespace Web_OuterrimSpaceship.DB;

public class AircraftContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=AircraftContext.db"); //keine ahnung ob das jetzt schon so stimmt, wird nochmal überprüft
    }

    public AircraftContext(DbContextOptions<AircraftContext> options) : base(options)
    {
        
    }
    
    //Tables

    public DbSet<Aircrafts> Aircrafts { get; set; }
    public DbSet<AircraftSpezifications> AircraftSpezifications { get; set; }
    public DbSet<Machineries> Machineries { get; set; }
    public DbSet<Mercenaries> Mercenaries { get; set; }
    
    //Beziehungen
    
    
}