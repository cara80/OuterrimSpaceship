using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Web_OuterrimSpaceship.Entities;

[Table("Aircrafts")]
public class Aircrafts
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AircraftId { get; set; }
    public int Fuel { get; set; }
    public int Speed { get; set; }
    public int Altitude { get; set; }
    public string Name { get; set; }

    public AircraftSpezifications AircraftSpezifications { get; set; }
    public int SpezificationId { get; set; }
    
    
}