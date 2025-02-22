using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_OuterrimSpaceship.Entities;

[Table("Aircraft_Crew_JT")]
public class AircraftCrewJT
{
    [Key]
    public int AircraftId { get; set; }
    [Key]
    public int MercenaryId { get; set; }
    public DateTime JoinedAt { get; set; }
    
    [ForeignKey("AircraftId")]
    public Aircrafts Aircraft { get; set; }
    
    [ForeignKey("MercenaryId")]
    public Mercenaries Mercenary { get; set; }
}