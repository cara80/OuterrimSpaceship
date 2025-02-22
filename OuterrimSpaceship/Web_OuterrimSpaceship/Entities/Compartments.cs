using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_OuterrimSpaceship.Entities;

[Table("Compartments")]
public class Compartments
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CompartmentId { get; set; }
    
    [ForeignKey("AircraftId")]
    public Aircrafts Aircraft { get; set; }
    public int AircraftId { get; set; }
}