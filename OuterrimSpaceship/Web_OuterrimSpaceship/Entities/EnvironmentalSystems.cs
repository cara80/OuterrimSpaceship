using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_OuterrimSpaceship.Entities;

[Table("Environmental_Systems")]
public class EnvironmentalSystems
{
    [Key, ForeignKey("MachineryId")]
    public int MachineryId { get; set; }
}