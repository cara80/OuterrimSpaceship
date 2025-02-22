using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Web_OuterrimSpaceship.Entities;

[Table("Aircraft_Spezifications")]
public class AircraftSpezifications
{
    [Key]
    public int SpezificationId { get; set; }
    public int Structure { get; set; }
    public int FuelTankCapacity { get; set; }
    public int MinSpeed { get; set; }
    public int MaxSpeed { get; set; }
    public int MaxAltitude { get; set; }
    public string SpezificationCode { get; set; }
}