using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Web_OuterrimSpaceship.Entities;

namespace Web_OuterrimSpaceship.DB;

public class AircraftContext : DbContext
{

    public AircraftContext(DbContextOptions<AircraftContext> options) : base(options)
    {
        
    }
    
    //Tables
    public DbSet<AircraftSpezifications> AircraftSpezifications { get; set; }
    public DbSet<Aircrafts> Aircrafts { get; set; }
    public DbSet<Compartments> Compartments { get; set; }
    public DbSet<AMachineries> Machineries { get; set; }
    public DbSet<Weapons> Weapons { get; set; }
    public DbSet<EnvironmentalSystems> EnvironmentalSystems { get; set; }
    public DbSet<EnergySystems> EnergySystems { get; set; }
    public DbSet<AircraftCrewJT> AircraftCrewJT { get; set; }
    public DbSet<Mercenaries> Mercenaries { get; set; }
    public DbSet<CrimeSyndicates> CrimeSyndicates { get; set; }
    public DbSet<MercenaryReputations> MercenaryReputations { get; set; }
    
    //Beziehungen
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AMachineries>()
            .HasIndex(m => m.Label)
            .IsUnique();
        
        
        
        modelBuilder.Entity<Aircrafts>()
            .HasOne(a => a.AircraftSpezifications)
            .WithMany()
            .HasForeignKey(a => a.SpezificationId);
        
        modelBuilder.Entity<Compartments>()
            .HasOne(c => c.Aircraft)
            .WithMany()
            .HasForeignKey(c => c.AircraftId);
        
        modelBuilder.Entity<AMachineries>()
            .HasOne(m => m.Compartment)
            .WithMany()
            .HasForeignKey(m => m.CompartmentId);

        modelBuilder.Entity<AMachineries>()
            .HasDiscriminator<string>("Type")
            .HasValue<AMachineries>("Machines")
            .HasValue<Weapons>("Weapons")
            .HasValue<EnergySystems>("Energy_Systems")
            .HasValue<EnvironmentalSystems>("Environmental_Systems");

        modelBuilder.Entity<AircraftCrewJT>()
            .HasOne(ac => ac.Aircraft)
            .WithMany()
            .HasForeignKey(ac => ac.AircraftId);

        modelBuilder.Entity<AircraftCrewJT>()
            .HasOne(ac => ac.Mercenary)
            .WithMany()
            .HasForeignKey(ac => ac.MercenaryId);
        
        modelBuilder.Entity<AircraftCrewJT>()
            .HasKey(ac => new { ac.AircraftId, ac.MercenaryId });
        
        modelBuilder.Entity<MercenaryReputations>()
            .HasOne(mr => mr.Mercenary)
            .WithMany()
            .HasForeignKey(mr => mr.MercenaryId);
        
        modelBuilder.Entity<MercenaryReputations>()
            .HasOne(mr => mr.Syndicate)
            .WithMany()
            .HasForeignKey(mr => mr.SyndicateId);
        
        modelBuilder.Entity<MercenaryReputations>()
            .HasKey(mr => new { mr.SyndicateId, mr.MercenaryId });


    }
}