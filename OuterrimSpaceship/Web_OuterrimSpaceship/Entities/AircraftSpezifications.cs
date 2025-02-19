using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Web_OuterrimSpaceship.Entities;

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